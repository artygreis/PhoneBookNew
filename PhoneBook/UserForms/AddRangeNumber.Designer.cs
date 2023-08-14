namespace PhoneBook.UserForms
{
    partial class AddRangeNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRangeNumber));
            panel1 = new Panel();
            panel2 = new Panel();
            pnlTop = new Panel();
            lblAddress = new Label();
            btnClose = new Button();
            lblHeader = new Label();
            btnSave = new Button();
            pnlGrid = new Panel();
            gridNumberPhones = new UserControls.GridControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlGrid.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(115, 115, 115);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(378, 599);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pnlTop);
            panel2.Controls.Add(pnlGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(376, 597);
            panel2.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(0, 71, 160);
            pnlTop.Controls.Add(lblAddress);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(lblHeader);
            pnlTop.Controls.Add(btnSave);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(4, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(368, 169);
            pnlTop.TabIndex = 0;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(56, 67);
            lblAddress.MaximumSize = new Size(300, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(255, 46);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Добавление данных по адресу: ";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(338, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 29);
            btnClose.TabIndex = 14;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(7, 9);
            lblHeader.MaximumSize = new Size(300, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(255, 46);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "Добавление данных по адресу: ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(0, 71, 160);
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(207, 123);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 40);
            btnSave.TabIndex = 13;
            btnSave.Text = "Сохранить";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(gridNumberPhones);
            pnlGrid.Dock = DockStyle.Bottom;
            pnlGrid.Location = new Point(4, 173);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(368, 420);
            pnlGrid.TabIndex = 1;
            // 
            // gridNumberPhones
            // 
            gridNumberPhones.BackColor = Color.White;
            gridNumberPhones.Dock = DockStyle.Fill;
            gridNumberPhones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridNumberPhones.ForeColor = Color.FromArgb(0, 71, 160);
            gridNumberPhones.Location = new Point(0, 0);
            gridNumberPhones.Name = "gridNumberPhones";
            gridNumberPhones.Padding = new Padding(0, 5, 0, 0);
            gridNumberPhones.Size = new Size(368, 420);
            gridNumberPhones.TabIndex = 0;
            // 
            // AddRangeNumber
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(378, 599);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AddRangeNumber";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddRangeNumber";
            Load += AddRangeNumber_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlTop;
        private Panel pnlGrid;
        private UserControls.GridControl gridNumberPhones;
        private Label lblAddress;
        private Button btnClose;
        private Label lblHeader;
        private Button btnSave;
    }
}