namespace GOLSource
{
    partial class Form1
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
            this.sliderButton1 = new GOLSource.SliderButton(this.Width);
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTickRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGrid = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanelCore = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonShape = new System.Windows.Forms.Button();
            this.buttonTick = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonRandSeed = new System.Windows.Forms.Button();
            this.buttonWorldSize = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.graphicsPanel1 = new GOLSource.GraphicsPanel();
            this.flowLayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFiniteToggle = new System.Windows.Forms.Button();
            this.buttonSpeed = new System.Windows.Forms.Button();
            this.buttonLineToggle = new System.Windows.Forms.Button();
            this.buttonAdjacentToggle = new System.Windows.Forms.Button();
            this.buttonHud = new System.Windows.Forms.Button();
            this.buttonStrip = new System.Windows.Forms.Button();
            this.buttonBackCol = new System.Windows.Forms.Button();
            this.buttonCellCol = new System.Windows.Forms.Button();
            this.buttonLineCol = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonCore = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.rightClickMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCols = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBackCol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCellCol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLineCol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTogLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTogAdjacent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTogHud = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTogStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanelCore.SuspendLayout();
            this.graphicsPanel1.SuspendLayout();
            this.flowLayoutPanelSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightClickMenuStrip.SuspendLayout();
            this.graphicsPanel1.Controls.Add(this.sliderButton1);
            this.SuspendLayout();
            // 
            // sliderButton1
            // 
            this.sliderButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sliderButton1.ClickCount = 0;
            this.sliderButton1.Location = new System.Drawing.Point(0, 146);
            this.sliderButton1.MoveDist = 0;
            this.sliderButton1.MovePercent = 0D;
            this.sliderButton1.MoveState = 0;
            this.sliderButton1.Name = "sliderButton1";
            this.sliderButton1.Size = new System.Drawing.Size(22, 67);
            this.sliderButton1.Sliding = false;
            this.sliderButton1.SplitObj = null;
            this.sliderButton1.SubTicks = 0;
            this.sliderButton1.TabIndex = 1;
            this.sliderButton1.Text = ">";
            this.sliderButton1.UseVisualStyleBackColor = true;
            this.sliderButton1.XMoveFrom = 0;
            this.sliderButton1.XOff = 0;
            this.sliderButton1.XStart = 83;
            this.sliderButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SliderButton1_MouseDown);
            this.sliderButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.sliderButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderButton1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelTickRate,
            this.toolStripStatusLabelCells,
            this.toolStripStatusLabelSeed,
            this.toolStripStatusLabelGrid});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusLabelTickRate
            // 
            this.toolStripStatusLabelTickRate.Name = "toolStripStatusLabelTickRate";
            this.toolStripStatusLabelTickRate.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabelTickRate.Text = "Tick Speed (ms) = 0";
            // 
            // toolStripStatusLabelCells
            // 
            this.toolStripStatusLabelCells.Name = "toolStripStatusLabelCells";
            this.toolStripStatusLabelCells.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabelCells.Text = "Cell Count = 0";
            // 
            // toolStripStatusLabelSeed
            // 
            this.toolStripStatusLabelSeed.Name = "toolStripStatusLabelSeed";
            this.toolStripStatusLabelSeed.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabelSeed.Text = "Seed = 0";
            // 
            // toolStripStatusLabelGrid
            // 
            this.toolStripStatusLabelGrid.Name = "toolStripStatusLabelGrid";
            this.toolStripStatusLabelGrid.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabelGrid.Text = "Universe Size = { 25, 25 }";
            // 
            // flowLayoutPanelCore
            // 
            this.flowLayoutPanelCore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelCore.AutoScroll = true;
            this.flowLayoutPanelCore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelCore.CausesValidation = false;
            this.flowLayoutPanelCore.Controls.Add(this.buttonPlay);
            this.flowLayoutPanelCore.Controls.Add(this.buttonShape);
            this.flowLayoutPanelCore.Controls.Add(this.buttonTick);
            this.flowLayoutPanelCore.Controls.Add(this.buttonClear);
            this.flowLayoutPanelCore.Controls.Add(this.buttonRandom);
            this.flowLayoutPanelCore.Controls.Add(this.buttonRandSeed);
            this.flowLayoutPanelCore.Location = new System.Drawing.Point(3, 104);
            this.flowLayoutPanelCore.Name = "flowLayoutPanelCore";
            this.flowLayoutPanelCore.Size = new System.Drawing.Size(66, 216);
            this.flowLayoutPanelCore.TabIndex = 0;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(3, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(60, 60);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonShape
            // 
            this.buttonShape.Location = new System.Drawing.Point(3, 69);
            this.buttonShape.Name = "buttonShape";
            this.buttonShape.Size = new System.Drawing.Size(60, 60);
            this.buttonShape.TabIndex = 4;
            this.buttonShape.Text = "Hexagon";
            this.buttonShape.UseVisualStyleBackColor = true;
            this.buttonShape.Click += new System.EventHandler(this.buttonShape_Click);
            // 
            // buttonTick
            // 
            this.buttonTick.Location = new System.Drawing.Point(3, 135);
            this.buttonTick.Name = "buttonTick";
            this.buttonTick.Size = new System.Drawing.Size(60, 60);
            this.buttonTick.TabIndex = 0;
            this.buttonTick.Text = "Tick";
            this.buttonTick.UseVisualStyleBackColor = true;
            this.buttonTick.Click += new System.EventHandler(this.ButtonTick_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(3, 201);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 60);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(3, 267);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(60, 60);
            this.buttonRandom.TabIndex = 5;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonRandSeed
            // 
            this.buttonRandSeed.Location = new System.Drawing.Point(3, 333);
            this.buttonRandSeed.Name = "buttonRandSeed";
            this.buttonRandSeed.Size = new System.Drawing.Size(60, 60);
            this.buttonRandSeed.TabIndex = 6;
            this.buttonRandSeed.Text = "Random Seed";
            this.buttonRandSeed.UseVisualStyleBackColor = true;
            this.buttonRandSeed.Click += new System.EventHandler(this.buttonRandSeed_Click);
            // 
            // buttonWorldSize
            // 
            this.buttonWorldSize.Location = new System.Drawing.Point(3, 3);
            this.buttonWorldSize.Name = "buttonWorldSize";
            this.buttonWorldSize.Size = new System.Drawing.Size(60, 60);
            this.buttonWorldSize.TabIndex = 1;
            this.buttonWorldSize.Text = "Universe Size";
            this.buttonWorldSize.UseVisualStyleBackColor = true;
            this.buttonWorldSize.Click += new System.EventHandler(this.buttonWorldSize_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(54, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(45, 45);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(105, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(45, 45);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.CellSize = 0F;
            this.graphicsPanel1.Controls.Add(this.sliderButton1);
            this.graphicsPanel1.HexRadius = 0F;
            this.graphicsPanel1.Location = new System.Drawing.Point(156, 3);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(417, 320);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.XOff = 0;
            this.graphicsPanel1.YOff = 0F;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicsPanel1_Paint);
            this.graphicsPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseDown);
            this.graphicsPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphicsPanel1_MouseClick);
            this.graphicsPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseUp);
            // 
            // flowLayoutPanelSettings
            // 
            this.flowLayoutPanelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelSettings.AutoScroll = true;
            this.flowLayoutPanelSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelSettings.CausesValidation = false;
            this.flowLayoutPanelSettings.Controls.Add(this.buttonWorldSize);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonFiniteToggle);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonSpeed);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonLineToggle);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonAdjacentToggle);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonHud);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonStrip);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonBackCol);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonCellCol);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonLineCol);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonReset);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonReload);
            this.flowLayoutPanelSettings.Location = new System.Drawing.Point(72, 104);
            this.flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            this.flowLayoutPanelSettings.Size = new System.Drawing.Size(78, 216);
            this.flowLayoutPanelSettings.TabIndex = 5;
            // 
            // buttonFiniteToggle
            // 
            this.buttonFiniteToggle.Location = new System.Drawing.Point(3, 69);
            this.buttonFiniteToggle.Name = "buttonFiniteToggle";
            this.buttonFiniteToggle.Size = new System.Drawing.Size(60, 60);
            this.buttonFiniteToggle.TabIndex = 11;
            this.buttonFiniteToggle.Text = "Toggle Finite Boundary";
            this.buttonFiniteToggle.UseVisualStyleBackColor = true;
            this.buttonFiniteToggle.Click += new System.EventHandler(this.buttonFiniteToggle_Click);
            // 
            // buttonSpeed
            // 
            this.buttonSpeed.Location = new System.Drawing.Point(3, 135);
            this.buttonSpeed.Name = "buttonSpeed";
            this.buttonSpeed.Size = new System.Drawing.Size(60, 60);
            this.buttonSpeed.TabIndex = 0;
            this.buttonSpeed.Text = "Tick Speed";
            this.buttonSpeed.UseVisualStyleBackColor = true;
            this.buttonSpeed.Click += new System.EventHandler(this.buttonSpeed_Click);
            // 
            // buttonLineToggle
            // 
            this.buttonLineToggle.Location = new System.Drawing.Point(3, 201);
            this.buttonLineToggle.Name = "buttonLineToggle";
            this.buttonLineToggle.Size = new System.Drawing.Size(60, 60);
            this.buttonLineToggle.TabIndex = 2;
            this.buttonLineToggle.Text = "Toggle Lines";
            this.buttonLineToggle.UseVisualStyleBackColor = true;
            this.buttonLineToggle.Click += new System.EventHandler(this.buttonLineToggle_Click);
            // 
            // buttonAdjacentToggle
            // 
            this.buttonAdjacentToggle.Location = new System.Drawing.Point(3, 267);
            this.buttonAdjacentToggle.Name = "buttonAdjacentToggle";
            this.buttonAdjacentToggle.Size = new System.Drawing.Size(60, 60);
            this.buttonAdjacentToggle.TabIndex = 3;
            this.buttonAdjacentToggle.Text = "Toggle Neighbor";
            this.buttonAdjacentToggle.UseVisualStyleBackColor = true;
            this.buttonAdjacentToggle.Click += new System.EventHandler(this.buttonAdjacentToggle_Click);
            // 
            // buttonHud
            // 
            this.buttonHud.Location = new System.Drawing.Point(3, 333);
            this.buttonHud.Name = "buttonHud";
            this.buttonHud.Size = new System.Drawing.Size(60, 60);
            this.buttonHud.TabIndex = 4;
            this.buttonHud.Text = "Toggle HUD";
            this.buttonHud.UseVisualStyleBackColor = true;
            this.buttonHud.Click += new System.EventHandler(this.buttonHud_Click);
            // 
            // buttonStrip
            // 
            this.buttonStrip.Location = new System.Drawing.Point(3, 399);
            this.buttonStrip.Name = "buttonStrip";
            this.buttonStrip.Size = new System.Drawing.Size(60, 60);
            this.buttonStrip.TabIndex = 9;
            this.buttonStrip.Text = "Toggle Strip";
            this.buttonStrip.UseVisualStyleBackColor = true;
            this.buttonStrip.Click += new System.EventHandler(this.buttonStrip_Click);
            // 
            // buttonBackCol
            // 
            this.buttonBackCol.Location = new System.Drawing.Point(3, 465);
            this.buttonBackCol.Name = "buttonBackCol";
            this.buttonBackCol.Size = new System.Drawing.Size(60, 60);
            this.buttonBackCol.TabIndex = 10;
            this.buttonBackCol.Text = "Back Color";
            this.buttonBackCol.UseVisualStyleBackColor = true;
            this.buttonBackCol.Click += new System.EventHandler(this.buttonBackCol_Click);
            // 
            // buttonCellCol
            // 
            this.buttonCellCol.Location = new System.Drawing.Point(3, 531);
            this.buttonCellCol.Name = "buttonCellCol";
            this.buttonCellCol.Size = new System.Drawing.Size(60, 60);
            this.buttonCellCol.TabIndex = 5;
            this.buttonCellCol.Text = "Cell Color";
            this.buttonCellCol.UseVisualStyleBackColor = true;
            this.buttonCellCol.Click += new System.EventHandler(this.buttonCellCol_Click);
            // 
            // buttonLineCol
            // 
            this.buttonLineCol.Location = new System.Drawing.Point(3, 597);
            this.buttonLineCol.Name = "buttonLineCol";
            this.buttonLineCol.Size = new System.Drawing.Size(60, 60);
            this.buttonLineCol.TabIndex = 6;
            this.buttonLineCol.Text = "Line Color";
            this.buttonLineCol.UseVisualStyleBackColor = true;
            this.buttonLineCol.Click += new System.EventHandler(this.buttonLineCol_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(3, 663);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(60, 60);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset Settings";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(3, 729);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(60, 60);
            this.buttonReload.TabIndex = 8;
            this.buttonReload.Text = "Reload Settings";
            this.buttonReload.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.buttonImport);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonCore);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 98);
            this.panel1.TabIndex = 4;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(105, 50);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(45, 45);
            this.buttonImport.TabIndex = 10;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(54, 50);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(45, 45);
            this.buttonSettings.TabIndex = 9;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonCore
            // 
            this.buttonCore.Location = new System.Drawing.Point(3, 50);
            this.buttonCore.Name = "buttonCore";
            this.buttonCore.Size = new System.Drawing.Size(45, 45);
            this.buttonCore.TabIndex = 8;
            this.buttonCore.Text = "Core";
            this.buttonCore.UseVisualStyleBackColor = true;
            this.buttonCore.Click += new System.EventHandler(this.buttonCore_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(3, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(45, 45);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // rightClickMenuStrip
            // 
            this.rightClickMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCols,
            this.toolStripMenuItemView});
            this.rightClickMenuStrip.Name = "rightClickMenuStrip";
            this.rightClickMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rightClickMenuStrip.ShowCheckMargin = true;
            this.rightClickMenuStrip.ShowImageMargin = false;
            this.rightClickMenuStrip.Size = new System.Drawing.Size(109, 48);
            // 
            // toolStripMenuItemCols
            // 
            this.toolStripMenuItemCols.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackCol,
            this.toolStripMenuItemCellCol,
            this.toolStripMenuItemLineCol});
            this.toolStripMenuItemCols.Name = "toolStripMenuItemCols";
            this.toolStripMenuItemCols.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemCols.Text = "Colors";
            // 
            // toolStripMenuItemBackCol
            // 
            this.toolStripMenuItemBackCol.Name = "toolStripMenuItemBackCol";
            this.toolStripMenuItemBackCol.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItemBackCol.Text = "Back Color";
            this.toolStripMenuItemBackCol.Click += new System.EventHandler(this.toolStripMenuItemBackCol_Click);
            // 
            // toolStripMenuItemCellCol
            // 
            this.toolStripMenuItemCellCol.Name = "toolStripMenuItemCellCol";
            this.toolStripMenuItemCellCol.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItemCellCol.Text = "Cell Color";
            this.toolStripMenuItemCellCol.Click += new System.EventHandler(this.toolStripMenuItemCellCol_Click);
            // 
            // toolStripMenuItemLineCol
            // 
            this.toolStripMenuItemLineCol.Name = "toolStripMenuItemLineCol";
            this.toolStripMenuItemLineCol.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItemLineCol.Text = "Line Color";
            this.toolStripMenuItemLineCol.Click += new System.EventHandler(this.toolStripMenuItemLineCol_Click);
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTogLine,
            this.toolStripMenuItemTogAdjacent,
            this.toolStripMenuItemTogHud,
            this.toolStripMenuItemTogStrip});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemView.Text = "View";
            // 
            // toolStripMenuItemTogLine
            // 
            this.toolStripMenuItemTogLine.Name = "toolStripMenuItemTogLine";
            this.toolStripMenuItemTogLine.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemTogLine.Text = "Toggle Lines";
            this.toolStripMenuItemTogLine.Click += new System.EventHandler(this.toolStripMenuItemTogLine_Click);
            // 
            // toolStripMenuItemTogAdjacent
            // 
            this.toolStripMenuItemTogAdjacent.Name = "toolStripMenuItemTogAdjacent";
            this.toolStripMenuItemTogAdjacent.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemTogAdjacent.Text = "Toggle Neighbor";
            this.toolStripMenuItemTogAdjacent.Click += new System.EventHandler(this.toolStripMenuItemTogAdjacent_Click);
            // 
            // toolStripMenuItemTogHud
            // 
            this.toolStripMenuItemTogHud.Name = "toolStripMenuItemTogHud";
            this.toolStripMenuItemTogHud.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemTogHud.Text = "Toggle HUD";
            this.toolStripMenuItemTogHud.Click += new System.EventHandler(this.toolStripMenuItemTogHud_Click);
            // 
            // toolStripMenuItemTogStrip
            // 
            this.toolStripMenuItemTogStrip.Name = "toolStripMenuItemTogStrip";
            this.toolStripMenuItemTogStrip.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemTogStrip.Text = "Toggle Strip";
            this.toolStripMenuItemTogStrip.Click += new System.EventHandler(this.toolStripMenuItemTogStrip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(573, 345);
            this.Controls.Add(this.flowLayoutPanelCore);
            this.Controls.Add(this.flowLayoutPanelSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.SizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanelCore.ResumeLayout(false);
            this.graphicsPanel1.ResumeLayout(false);
            this.flowLayoutPanelSettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightClickMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.Button buttonTick;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCore;
        private System.Windows.Forms.Button buttonShape;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNew;
        private SliderButton sliderButton1;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSettings;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonCore;
        private System.Windows.Forms.Button buttonRandSeed;
        private System.Windows.Forms.Button buttonSpeed;
        private System.Windows.Forms.Button buttonWorldSize;
        private System.Windows.Forms.Button buttonLineToggle;
        private System.Windows.Forms.Button buttonAdjacentToggle;
        private System.Windows.Forms.Button buttonHud;
        private System.Windows.Forms.Button buttonCellCol;
        private System.Windows.Forms.Button buttonLineCol;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTickRate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCells;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSeed;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonReload;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGrid;
        private System.Windows.Forms.Button buttonStrip;
        private System.Windows.Forms.ContextMenuStrip rightClickMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCols;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackCol;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCellCol;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLineCol;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTogLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTogAdjacent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTogHud;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTogStrip;
        private System.Windows.Forms.Button buttonBackCol;
        private System.Windows.Forms.Button buttonFiniteToggle;
    }
}
