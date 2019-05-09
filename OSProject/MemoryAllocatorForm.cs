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

        public MemoryAllocatorForm()
        {
            InitializeComponent();

            MainMemory = new Memory();

            RefreshDataGridViews();
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
                if (!process.HasAllData())
                {
                    MessageBox.Show(process.Name + @" didn't get all its segments data! Please fill more segments in it.");
                    return;
                }
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
            switch (TypeComboBox.SelectedIndex)
            {
                /*
                 * 0- First Fit
                 * 1- Best Fit
                 * 2- Worst Fit
                 */
                case 0: //First Fit
                    MainMemory.Holes = MainMemory.Holes.OrderBy(h => h.StartAddress).ToList();
                    break;
                case 1: //Best Fit
                    MainMemory.Holes = MainMemory.Holes.OrderBy(h => h.Size).ThenBy(h => h.StartAddress).ToList();
                    break;
                case 2: //Worst Fit
                    MainMemory.Holes = MainMemory.Holes.OrderByDescending(h => h.Size).ToList();
                    break;
            }

            Allocate();
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
                var process = MainMemory.Processes[AllocateProcessSelector.SelectedIndex];
                if (MainMemory.TryAllocateProcess(process))
                {
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

        private void DrawTimeline(bool drawProcesses = true, bool drawHoles = true, bool drawMemory = true)
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
            var ratio = 20;

            p.Height = (4+totalSize)* ratio;
            
            var w = 80;
            var drawWidth = (int) (p.Width * 0.4);
            var font = new Font(new FontFamily(GenericFontFamilies.SansSerif), 13,FontStyle.Italic);

            g.Clear(Color.White);

            //Check memory is set
            if (MainMemory.Size == 0)
            {
                return;
            }
            /*Draw Memory addresses*/
            if (drawMemory)
            {
                //Start and End
                //Start Address
                var brush1 = new SolidBrush(Color.Black);
                g.DrawString(@"Mem Start:0", font, brush1, w, 0);

                g.DrawString(@"Mem End:" + MainMemory.Size, font, brush1, w, (MainMemory.Size + 2) * ratio);

                //Draw the hole memory
                var wholeMemory = new Rectangle(w-2, 2*ratio, drawWidth+3, MainMemory.Size * ratio);
                g.DrawRectangle(new Pen(Color.Black), wholeMemory);
                g.FillRectangle(new SolidBrush(Color.Black), wholeMemory);
            }

            //Draw All Holes
            if (drawHoles)
            {
                foreach (var hole in MainMemory.Holes)
                {
                    var startPosition = (2 + hole.StartAddress)* ratio;
                    //Allocation rectangle
                    var rectangle = new Rectangle(w, startPosition, drawWidth, hole.Size * ratio);
                    g.DrawRectangle(new Pen(Color.Black), rectangle);
                    g.FillRectangle(new SolidBrush(Color.Blue), rectangle);

                    //Start Address
                    var separator = new Rectangle(w, startPosition, (int)(drawWidth * 1.1), 2);

                    var brush = new SolidBrush(Color.Black);
                    g.DrawString(@"Hole Start:" + hole.StartAddress, font, brush, w + (int)(drawWidth*1.1), startPosition - font.Height/2);
                    g.FillRectangle(new SolidBrush(Color.Blue), separator);


                    //End Address
                    separator = new Rectangle(w, startPosition + hole.Size * ratio, (int)(drawWidth * 1.4), 2);

                    g.DrawString(@"Hole End:" + (hole.StartAddress + hole.Size), font, brush, w + (int)(drawWidth * 1.4), startPosition + hole.Size * ratio - font.Height/2);
                    g.FillRectangle(new SolidBrush(Color.Blue), separator);
                }
            }

            //Draw allocated processes
            if (drawProcesses)
            {
                foreach (var process in MainMemory.Processes.Where(proc => proc.Allocated))
                {
                    foreach (var segment in process.Segments.Where(s => s.IsAllocated))
                    {
                        //Draw..


                        var startPosition = (2 + segment.AllocationStart )* ratio;
                        //Allocation rectangle
                        var rectangle = new Rectangle(w, startPosition, drawWidth, segment.Size * ratio);
                        g.DrawRectangle(new Pen(Color.Black), rectangle);
                        g.FillRectangle(new SolidBrush(Color.Red), rectangle);
                        //Process Title
                        g.DrawString(process.Name + " | " + segment.Name, font, new SolidBrush(Color.Blue), w, startPosition);

                        //Start Address
                        var separator = new Rectangle(w, startPosition, drawWidth, 1);

                        var brush = new SolidBrush(Color.Black);
                        g.DrawString(@"Addr:" + segment.AllocationStart, font, brush, 1, startPosition - font.Height/2);
                        g.FillRectangle(new SolidBrush(Color.Black), separator);


                        //End Address
                        separator = new Rectangle(w, startPosition + segment.Size * ratio, drawWidth, 1);

                        g.DrawString(@"Addr:" + segment.AllocationEnd, font, brush, 1, startPosition + segment.Size * ratio - font.Height / 2);
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

            DrawTimeline(false,false);
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
            DrawTimeline();
        }

        private void RefreshDeallocateSelector()
        {
            DeallocateProcessSelector.DataSource = MainMemory.Processes.Any(p => p.Allocated) ? MainMemory.Processes.Where(p => p.Allocated).ToList() : null;
            DeallocateProcessSelector.DisplayMember = "Name";
            DeallocateProcessSelector.ValueMember = "Number";
        }

        private void MemoryAllocatorForm_Load(object sender, EventArgs e)
        {
            ProcessSelector.DisplayMember = "Name";
            ProcessSelector.ValueMember = "Number";

            AllocateProcessSelector.DisplayMember = "Name";
            AllocateProcessSelector.ValueMember = "Number";

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
    }
}
