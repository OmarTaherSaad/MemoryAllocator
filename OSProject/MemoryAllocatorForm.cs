using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
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

            ProcessSelector.DisplayMember = "Name";
            ProcessSelector.ValueMember = "Number";

            AllocateProcessSelector.DisplayMember = "Name";
            AllocateProcessSelector.ValueMember = "Number";

            //DataGridViews Bindings
            RefreshDataGridViews();


            ReInitializeProcesses();
        }

        private void RefreshDataGridViews()
        {
            HolesDataGridView.DataSource = null;
            HolesDataGridView.DataSource = MainMemory.Holes;
            SegmentsDataGridView.DataSource = MainMemory.Segments;
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

            //Reinitialize Processes
            ReInitializeProcesses();

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
                    MainMemory.Holes = MainMemory.Holes.OrderBy(h => h.Size).ToList();
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

            DeallocateProcessSelector.DataSource = MainMemory.Processes.Where(p => p.Allocated);
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
                return;
            }

            var p = panel1;
            var g = p.CreateGraphics();
            //Total size and mapping it to total width
            var totalSize = MainMemory.Size;
            //var ratio = (p.Width - 5)/ totalSize;
            var ratio = 10;

            p.Height = (2+totalSize)* ratio;

            var w = 10;
            var font = new Font(new FontFamily(GenericFontFamilies.Serif), 13);

            g.Clear(Color.White);

            /*Draw Memory addresses*/
            //Start and End
            //Start Address
            var separator1 = new Rectangle(w, ratio, (int)(p.Width * 0.5),1);

            var brush1 = new SolidBrush(Color.Black);
            g.DrawString(@"Mem Start:0", font, brush1, (int)(p.Width * 0.6),ratio/3);
            g.FillRectangle(new SolidBrush(Color.Black), separator1);

            separator1 = new Rectangle(w, (1+MainMemory.Size )* ratio, (int)(p.Width * 0.5), 1);

            g.DrawString(@"Mem End:"+MainMemory.Size, font, brush1, (int)(p.Width * 0.5), (MainMemory.Size + 1)* ratio);
            g.FillRectangle(new SolidBrush(Color.Black), separator1);

            //Draw the hole memory
            var WholeMemory = new Rectangle(w, ratio, (int)(p.Width * 0.5), MainMemory.Size * ratio);
            g.DrawRectangle(new Pen(Color.Black), WholeMemory);
            g.FillRectangle(new SolidBrush(Color.Black), WholeMemory);

            //Draw All Holes
            foreach (var hole in MainMemory.Holes)
            {
                var startPosition = 30 + hole.StartAddress * ratio;
                //Allocation rectangle
                var rectangle = new Rectangle(w, startPosition, (int)(p.Width * 0.5), hole.Size * ratio);
                g.DrawRectangle(new Pen(Color.Black), rectangle);
                g.FillRectangle(new SolidBrush(Color.Brown), rectangle);

                //Start Address
                var separator = new Rectangle(w, startPosition, (int)(p.Width * 0.5), 1);

                var brush = new SolidBrush(Color.Black);
                g.DrawString(@"Hole Start:" + hole.StartAddress, font, brush, (int)(p.Width * 0.55), startPosition - ratio/2);
                g.FillRectangle(new SolidBrush(Color.Black), separator);


                //End Address
                separator = new Rectangle(w, startPosition + hole.Size * ratio, (int)(p.Width * 0.5), 1);

                g.DrawString(@"Hole End:" + (int)(hole.StartAddress+hole.Size), font, brush, (int)(p.Width * 0.55), startPosition + hole.Size * ratio + ratio/2);
                g.FillRectangle(new SolidBrush(Color.Black), separator);
            }

            //Draw allocated processes
            foreach (var process in MainMemory.Processes)
            {
                foreach (var segment in process.Segments.Where(s => s.IsAllocated))
                {
                    //Draw..


                    var startPosition = 30 + segment.AllocationStart * ratio;
                    //Allocation rectangle
                    var rectangle = new Rectangle(w, startPosition, (int)(p.Width* 0.5), segment.Size * ratio);
                    g.DrawRectangle(new Pen(Color.Black), rectangle);
                    g.FillRectangle(new SolidBrush(Color.Red), rectangle);
                    //Process Title
                    g.DrawString(process.Name+" | "+segment.Name, font, new SolidBrush(Color.Blue), w, startPosition);

                    //Start Address
                    var separator = new Rectangle(w, startPosition, (int)(p.Width * 0.5),1);
                    
                    var brush = new SolidBrush(Color.Black);
                    g.DrawString(@"Addr: " + segment.AllocationStart, font, brush, (int)(p.Width* 0.55), startPosition - 30);
                    g.FillRectangle(new SolidBrush(Color.Black), separator);


                    //End Address
                    separator = new Rectangle(w,startPosition + segment.Size* ratio, (int)(p.Width * 0.5),1);

                    g.DrawString(@"Addr: " + segment.AllocationEnd, font, brush, (int)(p.Width * 0.55), startPosition + segment.Size* ratio - 30);
                    g.FillRectangle(new SolidBrush(Color.Black), separator);
                }
            }
        }

        private void ReInitializeProcesses()
        {
            foreach (var segment in MainMemory.Segments.Where(s => s.IsAllocated == true))
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
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MemorySize.Enabled = true;
            SetSizeBtn.Enabled = true;

            MainMemory.Processes.Clear();
            RefreshDataGridViews();
            MainMemory.Reset();
            panel1.Invalidate();
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
            var process = MainMemory.Processes[ProcessSelector.SelectedIndex];
            process.AddSegment(SegmentName.Text, (int) SegmentSize.Value);

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

            DrawTimeline();
        }
    }
}
