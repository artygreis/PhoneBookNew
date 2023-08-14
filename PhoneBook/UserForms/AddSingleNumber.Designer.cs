namespace PhoneBook.UserForms
{
    partial class AddSingleNumber
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSingleNumber));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtNumber = new MaskedTextBox();
            lblAddress = new Label();
            txtApartment = new TextBox();
            btnClose = new Button();
            lblHeader = new Label();
            btnSave = new Button();
            lblApartment = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            errorValidating = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidating).BeginInit();
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
            panel1.Size = new Size(400, 268);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(398, 266);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Controls.Add(txtNumber);
            panel3.Controls.Add(lblAddress);
            panel3.Controls.Add(txtApartment);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(lblHeader);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(lblApartment);
            panel3.Controls.Add(lblNumber);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 258);
            panel3.TabIndex = 0;
            // 
            // txtNumber
            // 
            txtNumber.ForeColor = Color.FromArgb(0, 71, 160);
            txtNumber.Location = new Point(99, 166);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(184, 32);
            txtNumber.TabIndex = 1;
            txtNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddress.Location = new Point(29, 44);
            lblAddress.MaximumSize = new Size(350, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(344, 23);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Добавление данных по адресу: ";
            // 
            // txtApartment
            // 
            txtApartment.CharacterCasing = CharacterCasing.Upper;
            txtApartment.ForeColor = Color.FromArgb(0, 71, 160);
            txtApartment.Location = new Point(99, 107);
            txtApartment.Name = "txtApartment";
            txtApartment.Size = new Size(184, 32);
            txtApartment.TabIndex = 0;
            txtApartment.TextAlign = HorizontalAlignment.Center;
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
            lblHeader.Size = new Size(344, 23);
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
            btnSave.Location = new Point(233, 211);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblApartment
            // 
            lblApartment.DY = -28;
            lblApartment.ForeColor = Color.White;
            lblApartment.Gap = 5;
            lblApartment.LabeledControl = txtApartment;
            lblApartment.Location = new Point(99, 79);
            lblApartment.Name = "lblApartment";
            lblApartment.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            lblApartment.Size = new Size(148, 23);
            lblApartment.TabIndex = 13;
            lblApartment.Text = "Квартира, №:";
            // 
            // lblNumber
            // 
            lblNumber.DY = -28;
            lblNumber.ForeColor = Color.White;
            lblNumber.Gap = 5;
            lblNumber.LabeledControl = txtNumber;
            lblNumber.Location = new Point(99, 138);
            lblNumber.Name = "lblNumber";
            lblNumber.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            lblNumber.Size = new Size(197, 23);
            lblNumber.TabIndex = 14;
            lblNumber.Text = "Номер телефона:";
            // 
            // errorValidating
            // 
            errorValidating.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorValidating.ContainerControl = this;
            // 
            // AddSingleNumber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 268);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "AddSingleNumber";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSingleNumber";
            Load += AddSingleNumber_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidating).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblAddress;
        private TextBox txtApartment;
        private Button btnClose;
        private Label lblHeader;
        private Button btnSave;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblApartment;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumber;
        private MaskedTextBox txtNumber;
        private ErrorProvider errorValidating;
    }
}