namespace WinformsH6.UserControls
{
    partial class UC_Movie
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPoster = new System.Windows.Forms.Panel();
            this.pictureBoxPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCountryAndYear = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.panelGenres = new System.Windows.Forms.Panel();
            this.lblGenres = new System.Windows.Forms.Label();
            this.panelAgeAndRating = new System.Windows.Forms.Panel();
            this.lblRated = new System.Windows.Forms.Label();
            this.lblIMDBRating = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelGenres.SuspendLayout();
            this.panelAgeAndRating.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelPoster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelGenres, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelAgeAndRating, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.57616F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.90728F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(127, 302);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelPoster
            // 
            this.panelPoster.Controls.Add(this.pictureBoxPoster);
            this.panelPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPoster.Location = new System.Drawing.Point(0, 0);
            this.panelPoster.Margin = new System.Windows.Forms.Padding(0);
            this.panelPoster.Name = "panelPoster";
            this.panelPoster.Size = new System.Drawing.Size(127, 159);
            this.panelPoster.TabIndex = 1;
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPoster.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoster.ImageRotate = 0F;
            this.pictureBoxPoster.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPoster.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(127, 159);
            this.pictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPoster.TabIndex = 0;
            this.pictureBoxPoster.TabStop = false;
            this.pictureBoxPoster.Click += new System.EventHandler(this.UC_Movie_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.lblCountryAndYear);
            this.panelInfo.Controls.Add(this.lblMovieName);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 159);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(127, 60);
            this.panelInfo.TabIndex = 1;
            // 
            // lblCountryAndYear
            // 
            this.lblCountryAndYear.AutoSize = true;
            this.lblCountryAndYear.BackColor = System.Drawing.Color.Transparent;
            this.lblCountryAndYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountryAndYear.Location = new System.Drawing.Point(3, 35);
            this.lblCountryAndYear.Name = "lblCountryAndYear";
            this.lblCountryAndYear.Size = new System.Drawing.Size(75, 15);
            this.lblCountryAndYear.TabIndex = 0;
            this.lblCountryAndYear.Text = "Movie Name";
            this.lblCountryAndYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.BackColor = System.Drawing.Color.Transparent;
            this.lblMovieName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblMovieName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMovieName.Location = new System.Drawing.Point(3, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(103, 21);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Movie Name";
            this.lblMovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMovieName.Click += new System.EventHandler(this.UC_Movie_Click);
            // 
            // panelGenres
            // 
            this.panelGenres.BackColor = System.Drawing.Color.Transparent;
            this.panelGenres.Controls.Add(this.lblGenres);
            this.panelGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGenres.Location = new System.Drawing.Point(0, 259);
            this.panelGenres.Margin = new System.Windows.Forms.Padding(0);
            this.panelGenres.Name = "panelGenres";
            this.panelGenres.Size = new System.Drawing.Size(127, 43);
            this.panelGenres.TabIndex = 2;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.BackColor = System.Drawing.Color.Transparent;
            this.lblGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGenres.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenres.Location = new System.Drawing.Point(0, 0);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(43, 15);
            this.lblGenres.TabIndex = 0;
            this.lblGenres.Text = "Genres";
            // 
            // panelAgeAndRating
            // 
            this.panelAgeAndRating.BackColor = System.Drawing.Color.Transparent;
            this.panelAgeAndRating.Controls.Add(this.lblRated);
            this.panelAgeAndRating.Controls.Add(this.lblIMDBRating);
            this.panelAgeAndRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgeAndRating.Location = new System.Drawing.Point(0, 219);
            this.panelAgeAndRating.Margin = new System.Windows.Forms.Padding(0);
            this.panelAgeAndRating.Name = "panelAgeAndRating";
            this.panelAgeAndRating.Size = new System.Drawing.Size(127, 40);
            this.panelAgeAndRating.TabIndex = 2;
            // 
            // lblRated
            // 
            this.lblRated.AutoSize = true;
            this.lblRated.BackColor = System.Drawing.Color.Transparent;
            this.lblRated.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRated.Location = new System.Drawing.Point(3, 0);
            this.lblRated.Name = "lblRated";
            this.lblRated.Size = new System.Drawing.Size(37, 15);
            this.lblRated.TabIndex = 0;
            this.lblRated.Text = "Rated";
            this.lblRated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIMDBRating
            // 
            this.lblIMDBRating.AutoSize = true;
            this.lblIMDBRating.BackColor = System.Drawing.Color.Transparent;
            this.lblIMDBRating.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIMDBRating.Location = new System.Drawing.Point(3, 25);
            this.lblIMDBRating.Name = "lblIMDBRating";
            this.lblIMDBRating.Size = new System.Drawing.Size(38, 15);
            this.lblIMDBRating.TabIndex = 0;
            this.lblIMDBRating.Text = "IMDB";
            this.lblIMDBRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Movie";
            this.Size = new System.Drawing.Size(127, 302);
            this.Click += new System.EventHandler(this.UC_Movie_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelGenres.ResumeLayout(false);
            this.panelGenres.PerformLayout();
            this.panelAgeAndRating.ResumeLayout(false);
            this.panelAgeAndRating.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public Guna.UI2.WinForms.Guna2PictureBox pictureBoxPoster;
        public Panel panelPoster;
        public Panel panelInfo;
        public Label lblCountryAndYear;
        public Label lblMovieName;
        public Panel panelAgeAndRating;
        public Panel panelGenres;
        public Label lblGenres;
        public Label lblIMDBRating;
        public Label lblRated;
    }
}
