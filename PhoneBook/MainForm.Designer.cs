namespace PhoneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btnSettings = new Button();
            panelSide = new Panel();
            btnAdd = new Button();
            btnSearch = new Button();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            lblCaption = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            pictureBox1 = new PictureBox();
            pnlControl = new Panel();
            pnlFooter = new Panel();
            pnlRight = new Panel();
            panel1.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(panelSide);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 799);
            panel1.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSettings.BackColor = Color.FromArgb(0, 71, 160);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 13.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(11, 713);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(7, 0, 0, 0);
            btnSettings.Size = new Size(194, 65);
            btnSettings.TabIndex = 7;
            btnSettings.Text = " Настройки";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click_1;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(2, 37);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(7, 65);
            panelSide.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 71, 160);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(11, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(7, 0, 0, 0);
            btnAdd.Size = new Size(194, 65);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "  Добавить";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 71, 160);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(11, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(7, 0, 0, 0);
            btnSearch.Size = new Size(194, 65);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "  Поиск";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(0, 71, 160);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(lblCaption);
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1170, 53);
            pnlTitleBar.TabIndex = 3;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1136, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 35);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1103, 8);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 35);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblCaption
            // 
            lblCaption.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaption.ForeColor = Color.White;
            lblCaption.Location = new Point(50, 8);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(357, 32);
            lblCaption.TabIndex = 1;
            lblCaption.Text = "Телефонный справочник";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 43);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlControl
            // 
            pnlControl.Dock = DockStyle.Fill;
            pnlControl.Location = new Point(211, 53);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(954, 794);
            pnlControl.TabIndex = 4;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(0, 71, 160);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(211, 847);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(954, 5);
            pnlFooter.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(0, 71, 160);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(1165, 53);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(5, 799);
            pnlRight.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 852);
            Controls.Add(pnlControl);
            Controls.Add(pnlFooter);
            Controls.Add(pnlRight);
            Controls.Add(panel1);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Телефонный справочник";
            panel1.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel pnlTitleBar;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnMinimize;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCaption;
        private Button btnSettings;
        private Panel panelSide;
        private Button btnAdd;
        private Button btnSearch;
        private Panel pnlControl;
        private Panel pnlFooter;
        private Panel pnlRight;
    }
}