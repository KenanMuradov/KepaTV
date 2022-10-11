namespace WinformsH6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnResetFilters = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CheckBox8 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox7 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox9 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox10 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelFilters, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 45);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(12, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(867, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(885, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedColor = System.Drawing.Color.Gray;
            this.btnSearch.Size = new System.Drawing.Size(77, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 360);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelFilters
            // 
            this.panelFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilters.Controls.Add(this.btnResetFilters);
            this.panelFilters.Controls.Add(this.guna2CheckBox8);
            this.panelFilters.Controls.Add(this.guna2CheckBox7);
            this.panelFilters.Controls.Add(this.guna2CheckBox6);
            this.panelFilters.Controls.Add(this.guna2CheckBox5);
            this.panelFilters.Controls.Add(this.guna2CheckBox10);
            this.panelFilters.Controls.Add(this.guna2CheckBox9);
            this.panelFilters.Controls.Add(this.guna2CheckBox4);
            this.panelFilters.Controls.Add(this.guna2CheckBox3);
            this.panelFilters.Controls.Add(this.guna2CheckBox2);
            this.panelFilters.Controls.Add(this.guna2CheckBox1);
            this.panelFilters.Location = new System.Drawing.Point(0, 45);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(974, 45);
            this.panelFilters.TabIndex = 2;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnResetFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnResetFilters.BorderColor = System.Drawing.Color.Transparent;
            this.btnResetFilters.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetFilters.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetFilters.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetFilters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetFilters.FillColor = System.Drawing.Color.Transparent;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetFilters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetFilters.Location = new System.Drawing.Point(885, 6);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.PressedColor = System.Drawing.Color.Gray;
            this.btnResetFilters.Size = new System.Drawing.Size(77, 27);
            this.btnResetFilters.TabIndex = 1;
            this.btnResetFilters.Text = "Reset";
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // guna2CheckBox8
            // 
            this.guna2CheckBox8.Animated = true;
            this.guna2CheckBox8.AutoSize = true;
            this.guna2CheckBox8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox8.CheckedState.BorderRadius = 0;
            this.guna2CheckBox8.CheckedState.BorderThickness = 0;
            this.guna2CheckBox8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox8.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox8.Location = new System.Drawing.Point(517, 14);
            this.guna2CheckBox8.Name = "guna2CheckBox8";
            this.guna2CheckBox8.Size = new System.Drawing.Size(73, 19);
            this.guna2CheckBox8.TabIndex = 0;
            this.guna2CheckBox8.Text = "Fantastic";
            this.guna2CheckBox8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox8.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox8.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox8.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox7
            // 
            this.guna2CheckBox7.Animated = true;
            this.guna2CheckBox7.AutoSize = true;
            this.guna2CheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox7.CheckedState.BorderRadius = 0;
            this.guna2CheckBox7.CheckedState.BorderThickness = 0;
            this.guna2CheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox7.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox7.Location = new System.Drawing.Point(445, 14);
            this.guna2CheckBox7.Name = "guna2CheckBox7";
            this.guna2CheckBox7.Size = new System.Drawing.Size(66, 19);
            this.guna2CheckBox7.TabIndex = 0;
            this.guna2CheckBox7.Text = "Fantasy";
            this.guna2CheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox7.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox7.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox7.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox6
            // 
            this.guna2CheckBox6.Animated = true;
            this.guna2CheckBox6.AutoSize = true;
            this.guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.CheckedState.BorderRadius = 0;
            this.guna2CheckBox6.CheckedState.BorderThickness = 0;
            this.guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox6.Location = new System.Drawing.Point(377, 14);
            this.guna2CheckBox6.Name = "guna2CheckBox6";
            this.guna2CheckBox6.Size = new System.Drawing.Size(62, 19);
            this.guna2CheckBox6.TabIndex = 0;
            this.guna2CheckBox6.Text = "Thriller";
            this.guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox6.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox6.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox6.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox5
            // 
            this.guna2CheckBox5.Animated = true;
            this.guna2CheckBox5.AutoSize = true;
            this.guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.CheckedState.BorderRadius = 0;
            this.guna2CheckBox5.CheckedState.BorderThickness = 0;
            this.guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox5.Location = new System.Drawing.Point(310, 14);
            this.guna2CheckBox5.Name = "guna2CheckBox5";
            this.guna2CheckBox5.Size = new System.Drawing.Size(61, 19);
            this.guna2CheckBox5.TabIndex = 0;
            this.guna2CheckBox5.Text = "Horror";
            this.guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox5.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox5.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox4
            // 
            this.guna2CheckBox4.Animated = true;
            this.guna2CheckBox4.AutoSize = true;
            this.guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.CheckedState.BorderRadius = 0;
            this.guna2CheckBox4.CheckedState.BorderThickness = 0;
            this.guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox4.Location = new System.Drawing.Point(223, 14);
            this.guna2CheckBox4.Name = "guna2CheckBox4";
            this.guna2CheckBox4.Size = new System.Drawing.Size(81, 19);
            this.guna2CheckBox4.TabIndex = 0;
            this.guna2CheckBox4.Text = "Adventure";
            this.guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox4.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox4.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox3
            // 
            this.guna2CheckBox3.Animated = true;
            this.guna2CheckBox3.AutoSize = true;
            this.guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.CheckedState.BorderRadius = 0;
            this.guna2CheckBox3.CheckedState.BorderThickness = 0;
            this.guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox3.Location = new System.Drawing.Point(156, 14);
            this.guna2CheckBox3.Name = "guna2CheckBox3";
            this.guna2CheckBox3.Size = new System.Drawing.Size(61, 19);
            this.guna2CheckBox3.TabIndex = 0;
            this.guna2CheckBox3.Text = "Action";
            this.guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox3.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox3.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.Animated = true;
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox2.Location = new System.Drawing.Point(89, 14);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(61, 19);
            this.guna2CheckBox2.TabIndex = 0;
            this.guna2CheckBox2.Text = "Drama";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Animated = true;
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox1.Location = new System.Drawing.Point(12, 14);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(71, 19);
            this.guna2CheckBox1.TabIndex = 0;
            this.guna2CheckBox1.Text = "Comedy";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox9
            // 
            this.guna2CheckBox9.Animated = true;
            this.guna2CheckBox9.AutoSize = true;
            this.guna2CheckBox9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox9.CheckedState.BorderRadius = 0;
            this.guna2CheckBox9.CheckedState.BorderThickness = 0;
            this.guna2CheckBox9.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox9.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox9.Location = new System.Drawing.Point(596, 14);
            this.guna2CheckBox9.Name = "guna2CheckBox9";
            this.guna2CheckBox9.Size = new System.Drawing.Size(82, 19);
            this.guna2CheckBox9.TabIndex = 0;
            this.guna2CheckBox9.Text = "Animation";
            this.guna2CheckBox9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox9.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox9.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox9.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // guna2CheckBox10
            // 
            this.guna2CheckBox10.Animated = true;
            this.guna2CheckBox10.AutoSize = true;
            this.guna2CheckBox10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox10.CheckedState.BorderRadius = 0;
            this.guna2CheckBox10.CheckedState.BorderThickness = 0;
            this.guna2CheckBox10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox10.CheckMarkColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox10.Location = new System.Drawing.Point(684, 14);
            this.guna2CheckBox10.Name = "guna2CheckBox10";
            this.guna2CheckBox10.Size = new System.Drawing.Size(91, 19);
            this.guna2CheckBox10.TabIndex = 0;
            this.guna2CheckBox10.Text = "Documental";
            this.guna2CheckBox10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox10.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox10.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox10.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "KepaTV";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox txtSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelFilters;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox8;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox7;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox6;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox5;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox4;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2Button btnResetFilters;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox10;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox9;
    }
}