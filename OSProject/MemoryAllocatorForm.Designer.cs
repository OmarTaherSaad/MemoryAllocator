namespace OSProject
{
    partial class MemoryAllocatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.ProcessSegmentsCountLabel = new System.Windows.Forms.Label();
            this.ProcessSegmentsCount = new System.Windows.Forms.NumericUpDown();
            this.AddProcessBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllocateBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemorySize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.HolesGroupBox = new System.Windows.Forms.GroupBox();
            this.HolesDataGridView = new System.Windows.Forms.DataGridView();
            this.HolesSizeLabel = new System.Windows.Forms.Label();
            this.HolesStartingAddressLabel = new System.Windows.Forms.Label();
            this.HoleStartingAddress = new System.Windows.Forms.NumericUpDown();
            this.HolesSize = new System.Windows.Forms.NumericUpDown();
            this.AddHolesBtn = new System.Windows.Forms.Button();
            this.SegmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.SegmentName = new System.Windows.Forms.TextBox();
            this.SegmentSizeLabel = new System.Windows.Forms.Label();
            this.ProcessSelectorLabel = new System.Windows.Forms.Label();
            this.SegmentNameLabel = new System.Windows.Forms.Label();
            this.SegmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.SegmentSize = new System.Windows.Forms.NumericUpDown();
            this.AddSegmentBtn = new System.Windows.Forms.Button();
            this.ProcessSelector = new System.Windows.Forms.ComboBox();
            this.SetSizeBtn = new System.Windows.Forms.Button();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.AllocateProcessSelector = new System.Windows.Forms.ComboBox();
            this.AllocateAll = new System.Windows.Forms.CheckBox();
            this.DeallocateGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeallocateBtn = new System.Windows.Forms.Button();
            this.DeallocateProcessSelector = new System.Windows.Forms.ComboBox();
            this.AllocateGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessSegmentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemorySize)).BeginInit();
            this.HolesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoleStartingAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolesSize)).BeginInit();
            this.SegmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentSize)).BeginInit();
            this.DeallocateGroupBox.SuspendLayout();
            this.AllocateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.Items.AddRange(new object[] {
            "First Fit",
            "Best Fit",
            "Worst Fit"});
            this.TypeComboBox.Location = new System.Drawing.Point(539, 20);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(164, 37);
            this.TypeComboBox.TabIndex = 0;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(340, 23);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(194, 29);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type of Allocator";
            // 
            // ProcessGroupBox
            // 
            this.ProcessGroupBox.Controls.Add(this.ProcessSegmentsCountLabel);
            this.ProcessGroupBox.Controls.Add(this.ProcessSegmentsCount);
            this.ProcessGroupBox.Controls.Add(this.AddProcessBtn);
            this.ProcessGroupBox.Location = new System.Drawing.Point(9, 68);
            this.ProcessGroupBox.Name = "ProcessGroupBox";
            this.ProcessGroupBox.Size = new System.Drawing.Size(416, 86);
            this.ProcessGroupBox.TabIndex = 3;
            this.ProcessGroupBox.TabStop = false;
            this.ProcessGroupBox.Text = "Processes";
            // 
            // ProcessSegmentsCountLabel
            // 
            this.ProcessSegmentsCountLabel.AutoSize = true;
            this.ProcessSegmentsCountLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProcessSegmentsCountLabel.Location = new System.Drawing.Point(6, 32);
            this.ProcessSegmentsCountLabel.Name = "ProcessSegmentsCountLabel";
            this.ProcessSegmentsCountLabel.Size = new System.Drawing.Size(184, 35);
            this.ProcessSegmentsCountLabel.TabIndex = 2;
            this.ProcessSegmentsCountLabel.Text = "Number of Segments";
            // 
            // ProcessSegmentsCount
            // 
            this.ProcessSegmentsCount.Location = new System.Drawing.Point(196, 32);
            this.ProcessSegmentsCount.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.ProcessSegmentsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProcessSegmentsCount.Name = "ProcessSegmentsCount";
            this.ProcessSegmentsCount.Size = new System.Drawing.Size(100, 34);
            this.ProcessSegmentsCount.TabIndex = 1;
            this.ProcessSegmentsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddProcessBtn
            // 
            this.AddProcessBtn.Location = new System.Drawing.Point(330, 29);
            this.AddProcessBtn.Name = "AddProcessBtn";
            this.AddProcessBtn.Size = new System.Drawing.Size(79, 41);
            this.AddProcessBtn.TabIndex = 4;
            this.AddProcessBtn.Text = "Add";
            this.AddProcessBtn.UseVisualStyleBackColor = true;
            this.AddProcessBtn.Click += new System.EventHandler(this.AddProcessBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 743);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brought to you by: Omar Taher Saad - Khaled Mohammed ElFateh - Khaled AbdelGleel";
            // 
            // AllocateBtn
            // 
            this.AllocateBtn.Location = new System.Drawing.Point(91, 114);
            this.AllocateBtn.Name = "AllocateBtn";
            this.AllocateBtn.Size = new System.Drawing.Size(138, 37);
            this.AllocateBtn.TabIndex = 5;
            this.AllocateBtn.Text = "Allocate";
            this.AllocateBtn.UseVisualStyleBackColor = true;
            this.AllocateBtn.Click += new System.EventHandler(this.AllocateBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(1186, 76);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(103, 39);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(OSProject.Program);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // ParentPanel
            // 
            this.ParentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentPanel.AutoScroll = true;
            this.ParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParentPanel.Controls.Add(this.panel1);
            this.ParentPanel.Location = new System.Drawing.Point(788, 125);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(10);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(501, 608);
            this.ParentPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MemorySize
            // 
            this.MemorySize.Location = new System.Drawing.Point(891, 22);
            this.MemorySize.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.MemorySize.Name = "MemorySize";
            this.MemorySize.Size = new System.Drawing.Size(120, 34);
            this.MemorySize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(731, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Memory Size";
            // 
            // HolesGroupBox
            // 
            this.HolesGroupBox.Controls.Add(this.HolesDataGridView);
            this.HolesGroupBox.Controls.Add(this.HolesSizeLabel);
            this.HolesGroupBox.Controls.Add(this.HolesStartingAddressLabel);
            this.HolesGroupBox.Controls.Add(this.HoleStartingAddress);
            this.HolesGroupBox.Controls.Add(this.HolesSize);
            this.HolesGroupBox.Controls.Add(this.AddHolesBtn);
            this.HolesGroupBox.Location = new System.Drawing.Point(429, 68);
            this.HolesGroupBox.Name = "HolesGroupBox";
            this.HolesGroupBox.Size = new System.Drawing.Size(352, 498);
            this.HolesGroupBox.TabIndex = 12;
            this.HolesGroupBox.TabStop = false;
            this.HolesGroupBox.Text = "Holes";
            // 
            // HolesDataGridView
            // 
            this.HolesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.HolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HolesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HolesDataGridView.Location = new System.Drawing.Point(6, 104);
            this.HolesDataGridView.Name = "HolesDataGridView";
            this.HolesDataGridView.RowTemplate.Height = 24;
            this.HolesDataGridView.Size = new System.Drawing.Size(340, 388);
            this.HolesDataGridView.TabIndex = 5;
            // 
            // HolesSizeLabel
            // 
            this.HolesSizeLabel.AutoSize = true;
            this.HolesSizeLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HolesSizeLabel.Location = new System.Drawing.Point(180, 26);
            this.HolesSizeLabel.Name = "HolesSizeLabel";
            this.HolesSizeLabel.Size = new System.Drawing.Size(48, 35);
            this.HolesSizeLabel.TabIndex = 2;
            this.HolesSizeLabel.Text = "Size";
            // 
            // HolesStartingAddressLabel
            // 
            this.HolesStartingAddressLabel.AutoSize = true;
            this.HolesStartingAddressLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HolesStartingAddressLabel.Location = new System.Drawing.Point(6, 26);
            this.HolesStartingAddressLabel.Name = "HolesStartingAddressLabel";
            this.HolesStartingAddressLabel.Size = new System.Drawing.Size(151, 35);
            this.HolesStartingAddressLabel.TabIndex = 2;
            this.HolesStartingAddressLabel.Text = "Starting Address";
            // 
            // HoleStartingAddress
            // 
            this.HoleStartingAddress.Location = new System.Drawing.Point(6, 64);
            this.HoleStartingAddress.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.HoleStartingAddress.Name = "HoleStartingAddress";
            this.HoleStartingAddress.Size = new System.Drawing.Size(133, 34);
            this.HoleStartingAddress.TabIndex = 1;
            // 
            // HolesSize
            // 
            this.HolesSize.Location = new System.Drawing.Point(155, 64);
            this.HolesSize.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.HolesSize.Name = "HolesSize";
            this.HolesSize.Size = new System.Drawing.Size(100, 34);
            this.HolesSize.TabIndex = 1;
            // 
            // AddHolesBtn
            // 
            this.AddHolesBtn.Location = new System.Drawing.Point(267, 57);
            this.AddHolesBtn.Name = "AddHolesBtn";
            this.AddHolesBtn.Size = new System.Drawing.Size(79, 41);
            this.AddHolesBtn.TabIndex = 4;
            this.AddHolesBtn.Text = "Add";
            this.AddHolesBtn.UseVisualStyleBackColor = true;
            this.AddHolesBtn.Click += new System.EventHandler(this.AddHolesBtn_Click);
            // 
            // SegmentsGroupBox
            // 
            this.SegmentsGroupBox.Controls.Add(this.SegmentName);
            this.SegmentsGroupBox.Controls.Add(this.SegmentSizeLabel);
            this.SegmentsGroupBox.Controls.Add(this.ProcessSelectorLabel);
            this.SegmentsGroupBox.Controls.Add(this.SegmentNameLabel);
            this.SegmentsGroupBox.Controls.Add(this.SegmentsDataGridView);
            this.SegmentsGroupBox.Controls.Add(this.SegmentSize);
            this.SegmentsGroupBox.Controls.Add(this.AddSegmentBtn);
            this.SegmentsGroupBox.Controls.Add(this.ProcessSelector);
            this.SegmentsGroupBox.Location = new System.Drawing.Point(12, 160);
            this.SegmentsGroupBox.Name = "SegmentsGroupBox";
            this.SegmentsGroupBox.Size = new System.Drawing.Size(413, 406);
            this.SegmentsGroupBox.TabIndex = 12;
            this.SegmentsGroupBox.TabStop = false;
            this.SegmentsGroupBox.Text = "Segments";
            // 
            // SegmentName
            // 
            this.SegmentName.Location = new System.Drawing.Point(75, 72);
            this.SegmentName.Name = "SegmentName";
            this.SegmentName.Size = new System.Drawing.Size(241, 34);
            this.SegmentName.TabIndex = 5;
            // 
            // SegmentSizeLabel
            // 
            this.SegmentSizeLabel.AutoSize = true;
            this.SegmentSizeLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SegmentSizeLabel.Location = new System.Drawing.Point(268, 34);
            this.SegmentSizeLabel.Name = "SegmentSizeLabel";
            this.SegmentSizeLabel.Size = new System.Drawing.Size(48, 35);
            this.SegmentSizeLabel.TabIndex = 2;
            this.SegmentSizeLabel.Text = "Size";
            // 
            // ProcessSelectorLabel
            // 
            this.ProcessSelectorLabel.AutoSize = true;
            this.ProcessSelectorLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProcessSelectorLabel.Location = new System.Drawing.Point(6, 32);
            this.ProcessSelectorLabel.Name = "ProcessSelectorLabel";
            this.ProcessSelectorLabel.Size = new System.Drawing.Size(128, 35);
            this.ProcessSelectorLabel.TabIndex = 2;
            this.ProcessSelectorLabel.Text = "Select Process";
            // 
            // SegmentNameLabel
            // 
            this.SegmentNameLabel.AutoSize = true;
            this.SegmentNameLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SegmentNameLabel.Location = new System.Drawing.Point(5, 72);
            this.SegmentNameLabel.Name = "SegmentNameLabel";
            this.SegmentNameLabel.Size = new System.Drawing.Size(64, 35);
            this.SegmentNameLabel.TabIndex = 2;
            this.SegmentNameLabel.Text = "Name";
            // 
            // SegmentsDataGridView
            // 
            this.SegmentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SegmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SegmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SegmentsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SegmentsDataGridView.Location = new System.Drawing.Point(0, 113);
            this.SegmentsDataGridView.Name = "SegmentsDataGridView";
            this.SegmentsDataGridView.RowTemplate.Height = 24;
            this.SegmentsDataGridView.Size = new System.Drawing.Size(407, 287);
            this.SegmentsDataGridView.TabIndex = 0;
            // 
            // SegmentSize
            // 
            this.SegmentSize.Location = new System.Drawing.Point(322, 33);
            this.SegmentSize.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.SegmentSize.Name = "SegmentSize";
            this.SegmentSize.Size = new System.Drawing.Size(85, 34);
            this.SegmentSize.TabIndex = 1;
            // 
            // AddSegmentBtn
            // 
            this.AddSegmentBtn.Enabled = false;
            this.AddSegmentBtn.Location = new System.Drawing.Point(322, 71);
            this.AddSegmentBtn.Name = "AddSegmentBtn";
            this.AddSegmentBtn.Size = new System.Drawing.Size(85, 36);
            this.AddSegmentBtn.TabIndex = 4;
            this.AddSegmentBtn.Text = "Add";
            this.AddSegmentBtn.UseVisualStyleBackColor = true;
            this.AddSegmentBtn.Click += new System.EventHandler(this.AddSegmentBtn_Click);
            // 
            // ProcessSelector
            // 
            this.ProcessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessSelector.Location = new System.Drawing.Point(136, 30);
            this.ProcessSelector.Margin = new System.Windows.Forms.Padding(5);
            this.ProcessSelector.Name = "ProcessSelector";
            this.ProcessSelector.Size = new System.Drawing.Size(128, 37);
            this.ProcessSelector.TabIndex = 0;
            // 
            // SetSizeBtn
            // 
            this.SetSizeBtn.Location = new System.Drawing.Point(1018, 19);
            this.SetSizeBtn.Name = "SetSizeBtn";
            this.SetSizeBtn.Size = new System.Drawing.Size(78, 39);
            this.SetSizeBtn.TabIndex = 6;
            this.SetSizeBtn.Text = "Set Size";
            this.SetSizeBtn.UseVisualStyleBackColor = true;
            this.SetSizeBtn.Click += new System.EventHandler(this.SetSizeBtn_Click);
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MemoryLabel.Location = new System.Drawing.Point(979, 76);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(139, 39);
            this.MemoryLabel.TabIndex = 13;
            this.MemoryLabel.Text = "Memory";
            // 
            // AllocateProcessSelector
            // 
            this.AllocateProcessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllocateProcessSelector.Location = new System.Drawing.Point(142, 30);
            this.AllocateProcessSelector.Margin = new System.Windows.Forms.Padding(5);
            this.AllocateProcessSelector.Name = "AllocateProcessSelector";
            this.AllocateProcessSelector.Size = new System.Drawing.Size(144, 37);
            this.AllocateProcessSelector.TabIndex = 0;
            // 
            // AllocateAll
            // 
            this.AllocateAll.AutoSize = true;
            this.AllocateAll.Location = new System.Drawing.Point(12, 75);
            this.AllocateAll.Name = "AllocateAll";
            this.AllocateAll.Size = new System.Drawing.Size(287, 33);
            this.AllocateAll.TabIndex = 14;
            this.AllocateAll.Text = "Or Check to Allocate All";
            this.AllocateAll.UseVisualStyleBackColor = true;
            // 
            // DeallocateGroupBox
            // 
            this.DeallocateGroupBox.Controls.Add(this.label5);
            this.DeallocateGroupBox.Controls.Add(this.label6);
            this.DeallocateGroupBox.Controls.Add(this.DeallocateBtn);
            this.DeallocateGroupBox.Controls.Add(this.DeallocateProcessSelector);
            this.DeallocateGroupBox.Location = new System.Drawing.Point(328, 573);
            this.DeallocateGroupBox.Name = "DeallocateGroupBox";
            this.DeallocateGroupBox.Size = new System.Drawing.Size(447, 165);
            this.DeallocateGroupBox.TabIndex = 12;
            this.DeallocateGroupBox.TabStop = false;
            this.DeallocateGroupBox.Text = "Deallocate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Process";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(5, 80);
            this.label6.MaximumSize = new System.Drawing.Size(400, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 70);
            this.label6.TabIndex = 2;
            this.label6.Text = "Or to deallocate old process, just insert a hole in its address with the desired " +
    "size";
            // 
            // DeallocateBtn
            // 
            this.DeallocateBtn.Location = new System.Drawing.Point(303, 30);
            this.DeallocateBtn.Name = "DeallocateBtn";
            this.DeallocateBtn.Size = new System.Drawing.Size(138, 36);
            this.DeallocateBtn.TabIndex = 4;
            this.DeallocateBtn.Text = "Deallocate";
            this.DeallocateBtn.UseVisualStyleBackColor = true;
            this.DeallocateBtn.Click += new System.EventHandler(this.DeallocateBtn_Click);
            // 
            // DeallocateProcessSelector
            // 
            this.DeallocateProcessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeallocateProcessSelector.Location = new System.Drawing.Point(142, 30);
            this.DeallocateProcessSelector.Margin = new System.Windows.Forms.Padding(5);
            this.DeallocateProcessSelector.Name = "DeallocateProcessSelector";
            this.DeallocateProcessSelector.Size = new System.Drawing.Size(155, 37);
            this.DeallocateProcessSelector.TabIndex = 0;
            // 
            // AllocateGroupBox
            // 
            this.AllocateGroupBox.Controls.Add(this.label4);
            this.AllocateGroupBox.Controls.Add(this.AllocateAll);
            this.AllocateGroupBox.Controls.Add(this.AllocateProcessSelector);
            this.AllocateGroupBox.Controls.Add(this.AllocateBtn);
            this.AllocateGroupBox.Location = new System.Drawing.Point(12, 572);
            this.AllocateGroupBox.Name = "AllocateGroupBox";
            this.AllocateGroupBox.Size = new System.Drawing.Size(309, 166);
            this.AllocateGroupBox.TabIndex = 12;
            this.AllocateGroupBox.TabStop = false;
            this.AllocateGroupBox.Text = "Allocate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Process";
            // 
            // MemoryAllocatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 764);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.AllocateGroupBox);
            this.Controls.Add(this.DeallocateGroupBox);
            this.Controls.Add(this.SegmentsGroupBox);
            this.Controls.Add(this.HolesGroupBox);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MemorySize);
            this.Controls.Add(this.SetSizeBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessGroupBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MemoryAllocatorForm";
            this.Padding = new System.Windows.Forms.Padding(35, 109, 35, 36);
            this.Text = "Memory Allocation Project";
            this.ProcessGroupBox.ResumeLayout(false);
            this.ProcessGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessSegmentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ParentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemorySize)).EndInit();
            this.HolesGroupBox.ResumeLayout(false);
            this.HolesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoleStartingAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolesSize)).EndInit();
            this.SegmentsGroupBox.ResumeLayout(false);
            this.SegmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentSize)).EndInit();
            this.DeallocateGroupBox.ResumeLayout(false);
            this.DeallocateGroupBox.PerformLayout();
            this.AllocateGroupBox.ResumeLayout(false);
            this.AllocateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.GroupBox ProcessGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AllocateBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown MemorySize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox HolesGroupBox;
        private System.Windows.Forms.Label HolesSizeLabel;
        private System.Windows.Forms.Label HolesStartingAddressLabel;
        private System.Windows.Forms.NumericUpDown HoleStartingAddress;
        private System.Windows.Forms.NumericUpDown HolesSize;
        private System.Windows.Forms.Button AddHolesBtn;
        private System.Windows.Forms.Label ProcessSegmentsCountLabel;
        private System.Windows.Forms.NumericUpDown ProcessSegmentsCount;
        private System.Windows.Forms.Button AddProcessBtn;
        private System.Windows.Forms.GroupBox SegmentsGroupBox;
        private System.Windows.Forms.TextBox SegmentName;
        private System.Windows.Forms.Label SegmentSizeLabel;
        private System.Windows.Forms.Label SegmentNameLabel;
        private System.Windows.Forms.DataGridView SegmentsDataGridView;
        private System.Windows.Forms.NumericUpDown SegmentSize;
        private System.Windows.Forms.Button AddSegmentBtn;
        private System.Windows.Forms.Button SetSizeBtn;
        private System.Windows.Forms.ComboBox ProcessSelector;
        private System.Windows.Forms.Label ProcessSelectorLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.ComboBox AllocateProcessSelector;
        private System.Windows.Forms.CheckBox AllocateAll;
        private System.Windows.Forms.DataGridView HolesDataGridView;
        private System.Windows.Forms.GroupBox DeallocateGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeallocateBtn;
        private System.Windows.Forms.ComboBox DeallocateProcessSelector;
        private System.Windows.Forms.GroupBox AllocateGroupBox;
        private System.Windows.Forms.Label label4;
    }
}

