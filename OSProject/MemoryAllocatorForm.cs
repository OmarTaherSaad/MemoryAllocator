using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace OSProject
{
    public partial class MemoryAllocatorForm : MetroForm
    {
        public Memory MainMemory;

        public bool DrawMemory;
        public bool DrawHole;
        public bool DrawProcess;


        public MemoryAllocatorForm()
        {
            InitializeComponent();

            MainMemory = new Memory();

            RefreshDataGridViews();

            DrawMemory = true;
            DrawHole = true;
            DrawProcess = true;
        }

        private void RefreshDataGridViews()
        {
            HolesDataGridView.DataSource = MainMemory.HolesBindingList;
            SegmentsDataGridView.DataSource = MainMemory.SegmentsBindingList;

        }

        private void AddProcessBtn_Click(object sender, EventArgs e)
        {
            //Add Process
            var newProcess = new Process((int)ProcessSegmentsCount.Value,MainMemory.Processes.Count);
            MainMemory.Processes.Add(newProcess);

            //Update Processes dropdowns
            ProcessSelector.Items.Add(newProcess);
            AllocateProcessSelector.Items.Add(newProcess);

            //Allow to add segments
            AddSegmentBtn.Enabled = true;

            //Select a process in Process Selector if none is selected already
            if (ProcessSelector.SelectedIndex < 0)
            {
                ProcessSelector.SelectedIndex = 0;
            }
        }

        private void AllocateBtn_Click(object sender, EventArgs e)
        {
            //Check size of memory is set
            if (MainMemory.Size <= 0)
            {
                MessageBox.Show(@"You must set the memory size first!");
                return;
            }
            //Check existence of holes
            if (!MainMemory.Holes.Any())
            {
                MessageBox.Show(@"You cannot allocate in NO holes!", @"Please, enter any holes.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                //Check existence of processes
                if (!MainMemory.Processes.Any())
            {
                MessageBox.Show(@"You cannot allocate ZERO processes!", @"Please, enter any processes.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Check that allocation method selected
            if (TypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(@"You cannot allocate using NO Allocation method!", @"Please, choose any allocation method to start.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Reinitialize Processes if all
            if (AllocateAll.Checked)
            {
                ReInitializeProcesses();
            }
            

            //Make Sure all data was entered
            foreach (var process in MainMemory.Processes)
            {
                if (process.HasAllData()) continue;
                MessageBox.Show(process.Name + @" didn't get all its segments data! Please fill more segments in it.");
                return;
            }
            //Check that user chose a process to allocate or choose 'all'
            if (!AllocateAll.Checked && AllocateProcessSelector.SelectedIndex < 0)
            {
                   MessageBox.Show(@"You must choose the process to allocate or check the 'Allocate all' box!");
                return;
            }

                AllocateBtn.Text = @"Allocating..";
            AllocateBtn.Enabled = false;

            //Switching to start scheduling
            /*
             * 0- First Fit
             * 1- Best Fit
             * 2- Worst Fit
             */
            MainMemory.AllocationMethod = TypeComboBox.SelectedIndex;

            Allocate();

            DrawMemory = true;
            DrawHole = true;
            DrawProcess = true;
            DrawTimeline();

            AllocateBtn.Text = @"Allocate";
            AllocateBtn.Enabled = true;
        }

        private void Allocate()
        {
            if (AllocateAll.Checked)
            {
                //Allocate All
                foreach (var process in MainMemory.Processes)
                {
                    if (MainMemory.TryAllocateProcess(process))
                    {
                        AllocateProcessSelector.Items.Remove(process);

                        DrawMemory = true;
                        DrawHole = true;
                        DrawProcess = true;
                        DrawTimeline();
                    }
                    else
                    {
                        MessageBox.Show(@"The Process "+process.Name+@" cannot be allocated for now!");
                    }
                }
            }
            else
            {
                //Allocate One
                var process = MainMemory.Processes.First(p => p == (Process)AllocateProcessSelector.SelectedItem);
                if (MainMemory.TryAllocateProcess(process))
                {
                    AllocateProcessSelector.Items.Remove(process);

                    DrawMemory = true;
                    DrawHole = true;
                    DrawProcess = true;
                    DrawTimeline();
                }
                else
                {
                    MessageBox.Show(@"The Process " + process.Name + @" cannot be allocated for now!");
                }
            }

            RefreshDeallocateSelector();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawTimeline();
        }

        private void DrawTimeline()
        {
            if (!MainMemory.Segments.Any())
            {
                panel1.CreateGraphics().Clear(Color.White);
                
            }

            var p = panel1;
            var g = p.CreateGraphics();
            //Total size and mapping it to total width
            var totalSize = MainMemory.Size;
            //Drawing scale
            var ratio = 10;
            
            if (totalSize > 0)
            {
                ratio = p.Parent.Height * 2 / totalSize;
                if (ratio == 0)
                {
                    ratio = 1;
                }

                if (ratio > 10)
                {
                    ratio = 10;
                }
            }
            
            var w = 80;
            var drawWidth = (int) (p.Width * 0.4);
            var font = new Font(new FontFamily(GenericFontFamilies.SansSerif), 13,FontStyle.Italic);
            var drawingStart = font.Height / 2;

            p.Height = totalSize * ratio + font.Height;

            g.Clear(Color.White);

            //Check memory is set
            if (MainMemory.Size == 0)
            {
                return;
            }
            /*Draw Memory addresses*/
            if (DrawMemory)
            {
                //Start and End
                //Start Address
                var brush1 = new SolidBrush(Color.DarkGreen);
                if (showLabelsInDraw.Checked)
                {
                    g.DrawString(@"Mem:0", font, brush1, 1, drawingStart);
                    g.DrawString(@"Mem:" + MainMemory.Size, font, brush1, 1, MainMemory.Size* ratio - drawingStart);
                }

                //Draw the hole memory
                var wholeMemory = new Rectangle(w-2, drawingStart, drawWidth+3, MainMemory.Size * ratio);
                g.DrawRectangle(new Pen(Color.Black), wholeMemory);
                g.FillRectangle(new SolidBrush(Color.Black), wholeMemory);
            }

            //Draw All Holes
            if (DrawHole)
            {
                foreach (var hole in MainMemory.Holes)
                {
                    var startPosition = drawingStart + hole.StartAddress* ratio;
                    //Allocation rectangle
                    var rectangle = new Rectangle(w, startPosition, drawWidth, hole.Size * ratio);
                    g.DrawRectangle(new Pen(Color.Black), rectangle);
                    g.FillRectangle(new SolidBrush(Color.Blue), rectangle);

                    //Start Address
                    var separator = new Rectangle(w, startPosition, (int)(drawWidth * 1.1), 2);

                    var brush = new SolidBrush(Color.Black);

                    if (showLabelsInDraw.Checked)
                        g.DrawString(@"Hole Start:" + hole.StartAddress, font, brush, w + (int)(drawWidth*1.1), startPosition - drawingStart);

                    g.FillRectangle(new SolidBrush(Color.Blue), separator);


                    //End Address
                    separator = new Rectangle(w, startPosition + hole.Size * ratio, (int)(drawWidth * 1.4), 2);

                    if (showLabelsInDraw.Checked)
                        g.DrawString(@"Hole End:" + (hole.StartAddress + hole.Size), font, brush, w + (int)(drawWidth * 1.4), startPosition + hole.Size * ratio - drawingStart);

                    g.FillRectangle(new SolidBrush(Color.Blue), separator);
                }
            }

            //Draw allocated processes
            if (DrawProcess)
            {
                foreach (var process in MainMemory.Processes.Where(proc => proc.Allocated))
                {
                    foreach (var segment in process.Segments.Where(s => s.IsAllocated))
                    {
                        //Draw..


                        var startPosition = (drawingStart + segment.AllocationStart )* ratio;
                        //Allocation rectangle
                        var rectangle = new Rectangle(w, startPosition, drawWidth, segment.Size * ratio);
                        g.DrawRectangle(new Pen(Color.Black), rectangle);
                        g.FillRectangle(new SolidBrush(Color.Red), rectangle);

                        if (showLabelsInDraw.Checked)
                            //Process Title
                            g.DrawString(process.Name + " | " + segment.Name, font, new SolidBrush(Color.Blue), w, startPosition);

                        //Start Address
                        var separator = new Rectangle(w, startPosition, drawWidth, 1);

                        var brush = new SolidBrush(Color.Black);

                        if (showLabelsInDraw.Checked)
                            g.DrawString(@"Addr:" + segment.AllocationStart, font, brush, 1, startPosition - drawingStart);

                        g.FillRectangle(new SolidBrush(Color.Black), separator);


                        //End Address
                        separator = new Rectangle(w, startPosition + segment.Size * ratio, drawWidth, 1);

                        if (showLabelsInDraw.Checked)
                            g.DrawString(@"Addr:" + segment.AllocationEnd, font, brush, 1, startPosition + segment.Size * ratio - drawingStart);

                        g.FillRectangle(new SolidBrush(Color.Black), separator);
                    }
                }
            }
        }

        private void ReInitializeProcesses()
        {
            foreach (var segment in MainMemory.Segments.Where(s => s.IsAllocated))
            {
                var index = MainMemory.Holes.FindIndex(h => h == segment.Hole);
                MainMemory.Holes[index] = segment.Deallocate();
            }
        }

        private void SetSizeBtn_Click(object sender, EventArgs e)
        {
            //Check size of memory is not zero
            if ((int)MemorySize.Value <= 0)
            {
                MessageBox.Show(@"Memory size cannot be Zero!");
                return;
            }
            MainMemory.Size = (int) MemorySize.Value;
            //Prevent Changing memory size to avoid errors if segments/processes were added.
            MemorySize.Enabled = false;
            SetSizeBtn.Enabled = false;

            DrawMemory = true;
            DrawHole = false;
            DrawProcess = false;
            DrawTimeline();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MemorySize.Enabled = true;
            SetSizeBtn.Enabled = true;

            SegmentsGroupBox.Text = @"Segments";
            MainMemory.Reset();
            ResetProcessSelectors();
            RefreshDataGridViews();
            panel1.Invalidate();
        }

        private void ResetProcessSelectors()
        {
            
            ProcessSelector.Items.Clear();
            AllocateProcessSelector.Items.Clear();
            DeallocateProcessSelector.Items.Clear();

            ProcessSelector.DropDownHeight = 106;
            AllocateProcessSelector.DropDownHeight = 106;
            DeallocateProcessSelector.DropDownHeight = 106;

        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllocateBtn.Text = @"Allocate";
            AllocateBtn.Enabled = true;
        }

        private void AddSegmentBtn_Click(object sender, EventArgs e)
        {
            //Check that a process is selected
            if (ProcessSelector.SelectedIndex < 0)
            {
                MessageBox.Show(@"You must choose the process which this segment belongs to!");
                return;
            }

            if (SegmentName.Text.Length > 10)
            {
                MessageBox.Show(@"Segment name is too long! Please, provide a name of 10 letters as maximum.");
                return;
            }
            var process = MainMemory.Processes[ProcessSelector.SelectedIndex];
            process.AddSegment(SegmentName.Text, (int) SegmentSize.Value);

            RefreshSegmentsTitle();

            RefreshDataGridViews();
        }

        private void AddHolesBtn_Click(object sender, EventArgs e)
        {
            //Check size of memory is set
            if (MainMemory.Size <= 0)
            {
                MessageBox.Show(@"You must set the memory size first!");
                return;
            }
            var newHole = new Hole((int)HoleStartingAddress.Value,(int)HolesSize.Value);
            MainMemory.AddHole(newHole);

            RefreshDataGridViews();

            DrawMemory = true;
            DrawHole = true;
            DrawProcess = true;
            DrawTimeline();
        }

        private void DeallocateBtn_Click(object sender, EventArgs e)
        {
            //Check that a process is selected
            if (DeallocateProcessSelector.SelectedIndex < 0)
            {
                MessageBox.Show(@"You must choose a process to allocate!");
                return;
            }

            var index = MainMemory.Processes.IndexOf((Process) DeallocateProcessSelector.SelectedItem);
            foreach (var segment in MainMemory.Processes[index].Segments.Where(s => s.IsAllocated))
            {
                var index2 = MainMemory.Holes.FindIndex(h => h == segment.Hole);
                MainMemory.Holes[index2] = segment.Deallocate();
            }

            RefreshDeallocateSelector();
            AllocateProcessSelector.Items.Add(MainMemory.Processes[index]);

            DrawMemory = true;
            DrawHole = true;
            DrawProcess = true;
            DrawTimeline();
        }

        private void RefreshDeallocateSelector()
        {
            DeallocateProcessSelector.Items.Clear();
            if (MainMemory.Processes.Any(p => p.Allocated))
                DeallocateProcessSelector.Items.AddRange(MainMemory.Processes.Where(p => p.Allocated).ToArray());
        }

        private void MemoryAllocatorForm_Load(object sender, EventArgs e)
        {
            ProcessSelector.DisplayMember = "Name";

            AllocateProcessSelector.DisplayMember = "Name";

            DeallocateProcessSelector.DisplayMember = "Name";

            RefreshDeallocateSelector();

            //DataGridViews Bindings
            RefreshDataGridViews();


            ReInitializeProcesses();
        }

        private void ProcessSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSegmentsTitle();
        }

        private void RefreshSegmentsTitle()
        {
            var segmentsMissing = MainMemory.Processes[ProcessSelector.SelectedIndex].SegmentsCount -
                                  MainMemory.Processes[ProcessSelector.SelectedIndex].Segments.Count;
            if (segmentsMissing > 1)
            {
                SegmentsGroupBox.Text = @"Segments (" + segmentsMissing + @" segment(s) remaining)";
            }
            else if (segmentsMissing > 0)
            {
                SegmentsGroupBox.Text = @"Segments (1 segment remaining)";
            }
            else
            {
                SegmentsGroupBox.Text = @"Segments (No segments remaining)";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DrawTimeline();
        }
    }
}
