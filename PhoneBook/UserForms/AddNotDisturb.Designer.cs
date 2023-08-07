namespace PhoneBook.UserForms
{
    partial class AddNotDisturb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNotDisturb));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            chkNotEnter = new CheckBox();
            chkNotCall = new CheckBox();
            txtNote = new TextBox();
            lblAddress = new Label();
            btnClose = new Button();
            lblHeader = new Label();
            btnSave = new Button();
            lblNote = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(400, 290);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(398, 288);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Controls.Add(chkNotEnter);
            panel3.Controls.Add(chkNotCall);
            panel3.Controls.Add(txtNote);
            panel3.Controls.Add(lblAddress);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(lblHeader);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(lblNote);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 280);
            panel3.TabIndex = 0;
            // 
            // chkNotEnter
            // 
            chkNotEnter.AutoSize = true;
            chkNotEnter.Location = new Point(193, 88);
            chkNotEnter.Name = "chkNotEnter";
            chkNotEnter.Size = new Size(126, 23);
            chkNotEnter.TabIndex = 21;
            chkNotEnter.Text = "Не заходить";
            chkNotEnter.UseVisualStyleBackColor = true;
            // 
            // chkNotCall
            // 
            chkNotCall.AutoSize = true;
            chkNotCall.Location = new Point(72, 88);
            chkNotCall.Name = "chkNotCall";
            chkNotCall.Size = new Size(115, 23);
            chkNotCall.TabIndex = 20;
            chkNotCall.Text = "Не звонить";
            chkNotCall.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNote.ForeColor = Color.FromArgb(0, 71, 160);
            txtNote.Location = new Point(26, 145);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(338, 85);
            txtNote.TabIndex = 19;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddress.Location = new Point(29, 44);
            lblAddress.MaximumSize = new Size(350, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(273, 19);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Добавление данных по адресу: ";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(360, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 29);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblHeader.Location = new Point(10, 14);
            lblHeader.MaximumSize = new Size(350, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(273, 19);
            lblHeader.TabIndex = 17;
            lblHeader.Text = "Добавление данных по адресу: ";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(0, 71, 160);
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(247, 241);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblNote
            // 
            lblNote.DY = -24;
            lblNote.ForeColor = Color.White;
            lblNote.Gap = 5;
            lblNote.LabeledControl = txtNote;
            lblNote.Location = new Point(26, 121);
            lblNote.Name = "lblNote";
            lblNote.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            lblNote.Size = new Size(118, 19);
            lblNote.TabIndex = 13;
            lblNote.Text = "Примечание:";
            // 
            // AddNotDisturb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 290);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "AddNotDisturb";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNotDisturb";
            Load += AddNotDisturb_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblAddress;
        private Button btnClose;
        private Label lblHeader;
        private Button btnSave;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNote;
        private CheckBox chkNotEnter;
        private CheckBox chkNotCall;
        private TextBox txtNote;
    }
}