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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.ProcessSegmentsCountLabel = new System.Windows.Forms.Label();
            this.ProcessSegmentsCount = new System.Windows.Forms.NumericUpDown();
            this.AddProcessBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllocateBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemorySize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.HolesGroupBox = new System.Windows.Forms.GroupBox();
            this.HolesSizeLabel = new System.Windows.Forms.Label();
            this.HolesStartingAddressLabel = new System.Windows.Forms.Label();
            this.HoleStartingAddress = new System.Windows.Forms.NumericUpDown();
            this.HolesSize = new System.Windows.Forms.NumericUpDown();
            this.HolesDataGridView = new System.Windows.Forms.DataGridView();
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
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemorySize)).BeginInit();
            this.HolesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoleStartingAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolesSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolesDataGridView)).BeginInit();
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
            this.TypeComboBox.Location = new System.Drawing.Point(171, 58);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(153, 35);
            this.TypeComboBox.TabIndex = 0;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.TypeLabel.Location = new System.Drawing.Point(14, 59);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(156, 35);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type of Allocator";
            // 
            // ProcessGroupBox
            // 
            this.ProcessGroupBox.Controls.Add(this.ProcessSegmentsCountLabel);
            this.ProcessGroupBox.Controls.Add(this.ProcessSegmentsCount);
            this.ProcessGroupBox.Controls.Add(this.AddProcessBtn);
            this.ProcessGroupBox.Location = new System.Drawing.Point(8, 97);
            this.ProcessGroupBox.Name = "ProcessGroupBox";
            this.ProcessGroupBox.Size = new System.Drawing.Size(406, 80);
            this.ProcessGroupBox.TabIndex = 3;
            this.ProcessGroupBox.TabStop = false;
            this.ProcessGroupBox.Text = "Processes";
            // 
            // ProcessSegmentsCountLabel
            // 
            this.ProcessSegmentsCountLabel.AutoSize = true;
            this.ProcessSegmentsCountLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.ProcessSegmentsCountLabel.Location = new System.Drawing.Point(6, 30);
            this.ProcessSegmentsCountLabel.Name = "ProcessSegmentsCountLabel";
            this.ProcessSegmentsCountLabel.Size = new System.Drawing.Size(184, 35);
            this.ProcessSegmentsCountLabel.TabIndex = 2;
            this.ProcessSegmentsCountLabel.Text = "Number of Segments";
            // 
            // ProcessSegmentsCount
            // 
            this.ProcessSegmentsCount.Location = new System.Drawing.Point(192, 30);
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
            this.ProcessSegmentsCount.Size = new System.Drawing.Size(93, 34);
            this.ProcessSegmentsCount.TabIndex = 1;
            this.ProcessSegmentsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddProcessBtn
            // 
            this.AddProcessBtn.Location = new System.Drawing.Point(306, 27);
            this.AddProcessBtn.Name = "AddProcessBtn";
            this.AddProcessBtn.Size = new System.Drawing.Size(73, 38);
            this.AddProcessBtn.TabIndex = 4;
            this.AddProcessBtn.Text = "Add";
            this.AddProcessBtn.UseVisualStyleBackColor = true;
            this.AddProcessBtn.Click += new System.EventHandler(this.AddProcessBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 729);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brought to you by: Omar Taher Saad - Khaled Mohammed ElFateh - Khaled AbdelGleel";
            // 
            // AllocateBtn
            // 
            this.AllocateBtn.Location = new System.Drawing.Point(84, 106);
            this.AllocateBtn.Name = "AllocateBtn";
            this.AllocateBtn.Size = new System.Drawing.Size(128, 34);
            this.AllocateBtn.TabIndex = 5;
            this.AllocateBtn.Text = "Allocate";
            this.AllocateBtn.UseVisualStyleBackColor = true;
            this.AllocateBtn.Click += new System.EventHandler(this.AllocateBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(670, 57);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(107, 35);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset All";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ParentPanel
            // 
            this.ParentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentPanel.AutoScroll = true;
            this.ParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParentPanel.Controls.Add(this.panel1);
            this.ParentPanel.Location = new System.Drawing.Point(753, 116);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(9);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(473, 633);
            this.ParentPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 618);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MemorySize
            // 
            this.MemorySize.Location = new System.Drawing.Point(472, 58);
            this.MemorySize.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.MemorySize.Name = "MemorySize";
            this.MemorySize.Size = new System.Drawing.Size(111, 34);
            this.MemorySize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(338, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Memory Size";
            // 
            // HolesGroupBox
            // 
            this.HolesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HolesGroupBox.Controls.Add(this.HolesSizeLabel);
            this.HolesGroupBox.Controls.Add(this.HolesStartingAddressLabel);
            this.HolesGroupBox.Controls.Add(this.HoleStartingAddress);
            this.HolesGroupBox.Controls.Add(this.HolesSize);
            this.HolesGroupBox.Controls.Add(this.HolesDataGridView);
            this.HolesGroupBox.Controls.Add(this.AddHolesBtn);
            this.HolesGroupBox.Location = new System.Drawing.Point(420, 97);
            this.HolesGroupBox.Name = "HolesGroupBox";
            this.HolesGroupBox.Size = new System.Drawing.Size(327, 464);
            this.HolesGroupBox.TabIndex = 12;
            this.HolesGroupBox.TabStop = false;
            this.HolesGroupBox.Text = "Holes";
            // 
            // HolesSizeLabel
            // 
            this.HolesSizeLabel.AutoSize = true;
            this.HolesSizeLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.HolesSizeLabel.Location = new System.Drawing.Point(167, 24);
            this.HolesSizeLabel.Name = "HolesSizeLabel";
            this.HolesSizeLabel.Size = new System.Drawing.Size(48, 35);
            this.HolesSizeLabel.TabIndex = 2;
            this.HolesSizeLabel.Text = "Size";
            // 
            // HolesStartingAddressLabel
            // 
            this.HolesStartingAddressLabel.AutoSize = true;
            this.HolesStartingAddressLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.HolesStartingAddressLabel.Location = new System.Drawing.Point(6, 24);
            this.HolesStartingAddressLabel.Name = "HolesStartingAddressLabel";
            this.HolesStartingAddressLabel.Size = new System.Drawing.Size(151, 35);
            this.HolesStartingAddressLabel.TabIndex = 2;
            this.HolesStartingAddressLabel.Text = "Starting Address";
            // 
            // HoleStartingAddress
            // 
            this.HoleStartingAddress.Location = new System.Drawing.Point(6, 60);
            this.HoleStartingAddress.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.HoleStartingAddress.Name = "HoleStartingAddress";
            this.HoleStartingAddress.Size = new System.Drawing.Size(123, 34);
            this.HoleStartingAddress.TabIndex = 1;
            // 
            // HolesSize
            // 
            this.HolesSize.Location = new System.Drawing.Point(144, 60);
            this.HolesSize.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.HolesSize.Name = "HolesSize";
            this.HolesSize.Size = new System.Drawing.Size(93, 34);
            this.HolesSize.TabIndex = 1;
            // 
            // HolesDataGridView
            // 
            this.HolesDataGridView.AllowUserToAddRows = false;
            this.HolesDataGridView.AllowUserToDeleteRows = false;
            this.HolesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HolesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.HolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HolesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HolesDataGridView.Location = new System.Drawing.Point(6, 100);
            this.HolesDataGridView.Name = "HolesDataGridView";
            this.HolesDataGridView.ReadOnly = true;
            this.HolesDataGridView.RowTemplate.Height = 24;
            this.HolesDataGridView.Size = new System.Drawing.Size(315, 358);
            this.HolesDataGridView.TabIndex = 0;
            // 
            // AddHolesBtn
            // 
            this.AddHolesBtn.Location = new System.Drawing.Point(248, 53);
            this.AddHolesBtn.Name = "AddHolesBtn";
            this.AddHolesBtn.Size = new System.Drawing.Size(73, 38);
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
            this.SegmentsGroupBox.Location = new System.Drawing.Point(11, 183);
            this.SegmentsGroupBox.Name = "SegmentsGroupBox";
            this.SegmentsGroupBox.Size = new System.Drawing.Size(403, 378);
            this.SegmentsGroupBox.TabIndex = 12;
            this.SegmentsGroupBox.TabStop = false;
            this.SegmentsGroupBox.Text = "Segments";
            // 
            // SegmentName
            // 
            this.SegmentName.Location = new System.Drawing.Point(70, 67);
            this.SegmentName.Name = "SegmentName";
            this.SegmentName.Size = new System.Drawing.Size(217, 34);
            this.SegmentName.TabIndex = 5;
            // 
            // SegmentSizeLabel
            // 
            this.SegmentSizeLabel.AutoSize = true;
            this.SegmentSizeLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.SegmentSizeLabel.Location = new System.Drawing.Point(268, 32);
            this.SegmentSizeLabel.Name = "SegmentSizeLabel";
            this.SegmentSizeLabel.Size = new System.Drawing.Size(48, 35);
            this.SegmentSizeLabel.TabIndex = 2;
            this.SegmentSizeLabel.Text = "Size";
            // 
            // ProcessSelectorLabel
            // 
            this.ProcessSelectorLabel.AutoSize = true;
            this.ProcessSelectorLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.ProcessSelectorLabel.Location = new System.Drawing.Point(6, 30);
            this.ProcessSelectorLabel.Name = "ProcessSelectorLabel";
            this.ProcessSelectorLabel.Size = new System.Drawing.Size(128, 35);
            this.ProcessSelectorLabel.TabIndex = 2;
            this.ProcessSelectorLabel.Text = "Select Process";
            // 
            // SegmentNameLabel
            // 
            this.SegmentNameLabel.AutoSize = true;
            this.SegmentNameLabel.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.SegmentNameLabel.Location = new System.Drawing.Point(5, 67);
            this.SegmentNameLabel.Name = "SegmentNameLabel";
            this.SegmentNameLabel.Size = new System.Drawing.Size(64, 35);
            this.SegmentNameLabel.TabIndex = 2;
            this.SegmentNameLabel.Text = "Name";
            // 
            // SegmentsDataGridView
            // 
            this.SegmentsDataGridView.AllowUserToAddRows = false;
            this.SegmentsDataGridView.AllowUserToDeleteRows = false;
            this.SegmentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SegmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SegmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SegmentsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SegmentsDataGridView.Location = new System.Drawing.Point(0, 105);
            this.SegmentsDataGridView.Name = "SegmentsDataGridView";
            this.SegmentsDataGridView.ReadOnly = true;
            this.SegmentsDataGridView.RowTemplate.Height = 24;
            this.SegmentsDataGridView.Size = new System.Drawing.Size(398, 267);
            this.SegmentsDataGridView.TabIndex = 0;
            // 
            // SegmentSize
            // 
            this.SegmentSize.Location = new System.Drawing.Point(319, 31);
            this.SegmentSize.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.SegmentSize.Name = "SegmentSize";
            this.SegmentSize.Size = new System.Drawing.Size(79, 34);
            this.SegmentSize.TabIndex = 1;
            // 
            // AddSegmentBtn
            // 
            this.AddSegmentBtn.Enabled = false;
            this.AddSegmentBtn.Location = new System.Drawing.Point(319, 66);
            this.AddSegmentBtn.Name = "AddSegmentBtn";
            this.AddSegmentBtn.Size = new System.Drawing.Size(80, 34);
            this.AddSegmentBtn.TabIndex = 4;
            this.AddSegmentBtn.Text = "Add";
            this.AddSegmentBtn.UseVisualStyleBackColor = true;
            this.AddSegmentBtn.Click += new System.EventHandler(this.AddSegmentBtn_Click);
            // 
            // ProcessSelector
            // 
            this.ProcessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessSelector.Location = new System.Drawing.Point(135, 28);
            this.ProcessSelector.Margin = new System.Windows.Forms.Padding(5);
            this.ProcessSelector.Name = "ProcessSelector";
            this.ProcessSelector.Size = new System.Drawing.Size(125, 35);
            this.ProcessSelector.TabIndex = 0;
            this.ProcessSelector.SelectedIndexChanged += new System.EventHandler(this.ProcessSelector_SelectedIndexChanged);
            // 
            // SetSizeBtn
            // 
            this.SetSizeBtn.Location = new System.Drawing.Point(590, 57);
            this.SetSizeBtn.Name = "SetSizeBtn";
            this.SetSizeBtn.Size = new System.Drawing.Size(72, 36);
            this.SetSizeBtn.TabIndex = 6;
            this.SetSizeBtn.Text = "Set Size";
            this.SetSizeBtn.UseVisualStyleBackColor = true;
            this.SetSizeBtn.Click += new System.EventHandler(this.SetSizeBtn_Click);
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Zeytoon", 20F, System.Drawing.FontStyle.Bold);
            this.MemoryLabel.Location = new System.Drawing.Point(917, 57);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(146, 59);
            this.MemoryLabel.TabIndex = 13;
            this.MemoryLabel.Text = "Memory";
            // 
            // AllocateProcessSelector
            // 
            this.AllocateProcessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllocateProcessSelector.Location = new System.Drawing.Point(136, 28);
            this.AllocateProcessSelector.Margin = new System.Windows.Forms.Padding(5);
            this.AllocateProcessSelector.Name = "AllocateProcessSelector";
            this.AllocateProcessSelector.Size = new System.Drawing.Size(134, 35);
            this.AllocateProcessSelector.TabIndex = 0;
            // 
            // AllocateAll
            // 
            this.AllocateAll.AutoSize = true;
            this.AllocateAll.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.AllocateAll.Location = new System.Drawing.Point(14, 70);
            this.AllocateAll.Name = "AllocateAll";
            this.AllocateAll.Size = new System.Drawing.Size(232, 39);
            this.AllocateAll.TabIndex = 14;
            this.AllocateAll.Text = "Or Check to Allocate All";
            this.AllocateAll.UseVisualStyleBackColor = true;
            // 
            // DeallocateGroupBox
            // 
            this.DeallocateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeallocateGroupBox.Controls.Add(this.label5);
            this.DeallocateGroupBox.Controls.Add(this.label6);
            this.DeallocateGroupBox.Controls.Add(this.DeallocateBtn);
            this.DeallocateGroupBox.Controls.Add(this.DeallocateProcessSelector);
            this.DeallocateGroupBox.Location = new System.Drawing.Point(305, 567);
            this.DeallocateGroupBox.Name = "DeallocateGroupBox";
            this.DeallocateGroupBox.Size = new System.Drawing.Size(415, 154);
            this.DeallocateGroupBox.TabIndex = 12;
            this.DeallocateGroupBox.TabStop = false;
            this.DeallocateGroupBox.Text = "Deallocate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Process";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.MaximumSize = new System.Drawing.Size(400, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 70);
            this.label6.TabIndex = 2;
            this.label6.Text = "Or to deallocate old process, just insert a hole in its address with the desired " +
    "size";
            // 
            // DeallocateBtn
            // 
            this.DeallocateBtn.Location = new System.Drawing.Point(282, 28);
            this.DeallocateBtn.Name = "DeallocateBtn";
            this.DeallocateBtn.Size = new System.Drawing.Size(128, 34);
            this.DeallocateBtn.TabIndex = 4;
            this.DeallocateBtn.Text = "Deallocate";
            this.DeallocateBtn.UseVisualStyleBackColor = true;
            this.DeallocateBtn.Click += new System.EventHandler(this.DeallocateBtn_Click);
            // 
            // DeallocateProcessSelector
            // 
            this.DeallocateProcessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeallocateProcessSelector.Location = new System.Drawing.Point(136, 28);
            this.DeallocateProcessSelector.Margin = new System.Windows.Forms.Padding(5);
            this.DeallocateProcessSelector.Name = "DeallocateProcessSelector";
            this.DeallocateProcessSelector.Size = new System.Drawing.Size(143, 35);
            this.DeallocateProcessSelector.TabIndex = 0;
            // 
            // AllocateGroupBox
            // 
            this.AllocateGroupBox.Controls.Add(this.label4);
            this.AllocateGroupBox.Controls.Add(this.AllocateAll);
            this.AllocateGroupBox.Controls.Add(this.AllocateProcessSelector);
            this.AllocateGroupBox.Controls.Add(this.AllocateBtn);
            this.AllocateGroupBox.Location = new System.Drawing.Point(11, 567);
            this.AllocateGroupBox.Name = "AllocateGroupBox";
            this.AllocateGroupBox.Size = new System.Drawing.Size(287, 155);
            this.AllocateGroupBox.TabIndex = 12;
            this.AllocateGroupBox.TabStop = false;
            this.AllocateGroupBox.Text = "Allocate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zeytoon", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Process";
            // 
            // MemoryAllocatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 751);
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
            this.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MemoryAllocatorForm";
            this.Padding = new System.Windows.Forms.Padding(32, 101, 32, 34);
            this.Resizable = false;
            this.Text = "Memory Allocation Project";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.MemoryAllocatorForm_Load);
            this.ProcessGroupBox.ResumeLayout(false);
            this.ProcessGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessSegmentsCount)).EndInit();
            this.ParentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemorySize)).EndInit();
            this.HolesGroupBox.ResumeLayout(false);
            this.HolesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoleStartingAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolesSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolesDataGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox DeallocateGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeallocateBtn;
        private System.Windows.Forms.ComboBox DeallocateProcessSelector;
        private System.Windows.Forms.GroupBox AllocateGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView HolesDataGridView;
    }
}

