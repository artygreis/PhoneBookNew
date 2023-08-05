
using Syncfusion.Windows.Forms.Tools;

namespace PhoneBook.Forms
{
    partial class EditCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCity));
            lblCityName = new AutoLabel();
            txtCityName = new TextBox();
            lblCityCode = new AutoLabel();
            txtCityCode = new MaskedTextBox();
            lblFormatNumber = new AutoLabel();
            txtFormatNumber = new MaskedTextBox();
            pnlGrid = new Panel();
            gridCities = new UserControls.GridControl();
            panel1 = new Panel();
            btnClose = new Button();
            lblCountry = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            errorValidating = new ErrorProvider(components);
            panel2 = new Panel();
            panel3 = new Panel();
            pnlGrid.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidating).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblCityName
            // 
            lblCityName.DX = -149;
            lblCityName.DY = 2;
            lblCityName.ForeColor = Color.White;
            lblCityName.Gap = 10;
            lblCityName.LabeledControl = txtCityName;
            lblCityName.Location = new Point(83, 68);
            lblCityName.Name = "lblCityName";
            lblCityName.Size = new Size(139, 20);
            lblCityName.TabIndex = 0;
            lblCityName.Text = "Наименование:";
            // 
            // txtCityName
            // 
            txtCityName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCityName.ForeColor = Color.FromArgb(0, 71, 160);
            txtCityName.Location = new Point(232, 66);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(184, 24);
            txtCityName.TabIndex = 0;
            txtCityName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCityCode
            // 
            lblCityCode.DX = -122;
            lblCityCode.DY = 3;
            lblCityCode.ForeColor = Color.White;
            lblCityCode.Gap = 10;
            lblCityCode.LabeledControl = txtCityCode;
            lblCityCode.Location = new Point(110, 103);
            lblCityCode.Name = "lblCityCode";
            lblCityCode.Size = new Size(112, 20);
            lblCityCode.TabIndex = 0;
            lblCityCode.Text = "Код города:";
            // 
            // txtCityCode
            // 
            txtCityCode.ForeColor = Color.FromArgb(0, 71, 160);
            txtCityCode.HidePromptOnLeave = true;
            txtCityCode.Location = new Point(232, 100);
            txtCityCode.Mask = "0000000";
            txtCityCode.Name = "txtCityCode";
            txtCityCode.Size = new Size(184, 26);
            txtCityCode.TabIndex = 1;
            txtCityCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFormatNumber
            // 
            lblFormatNumber.DX = -159;
            lblFormatNumber.DY = 3;
            lblFormatNumber.ForeColor = Color.White;
            lblFormatNumber.Gap = 10;
            lblFormatNumber.LabeledControl = txtFormatNumber;
            lblFormatNumber.Location = new Point(73, 136);
            lblFormatNumber.Name = "lblFormatNumber";
            lblFormatNumber.Size = new Size(149, 20);
            lblFormatNumber.TabIndex = 0;
            lblFormatNumber.Text = "Формат номера:";
            // 
            // txtFormatNumber
            // 
            txtFormatNumber.ForeColor = Color.FromArgb(0, 71, 160);
            txtFormatNumber.Location = new Point(232, 133);
            txtFormatNumber.Name = "txtFormatNumber";
            txtFormatNumber.Size = new Size(184, 26);
            txtFormatNumber.TabIndex = 2;
            txtFormatNumber.TextAlign = HorizontalAlignment.Center;
            txtFormatNumber.Enter += txtFormatNumber_Enter;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(0, 71, 160);
            pnlGrid.Controls.Add(gridCities);
            pnlGrid.Dock = DockStyle.Bottom;
            pnlGrid.Location = new Point(4, 211);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(464, 274);
            pnlGrid.TabIndex = 0;
            // 
            // gridCities
            // 
            gridCities.BackColor = Color.White;
            gridCities.Dock = DockStyle.Fill;
            gridCities.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridCities.ForeColor = Color.FromArgb(0, 71, 160);
            gridCities.Location = new Point(0, 0);
            gridCities.Margin = new Padding(4);
            gridCities.Name = "gridCities";
            gridCities.Padding = new Padding(0, 5, 0, 0);
            gridCities.Size = new Size(464, 274);
            gridCities.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(txtFormatNumber);
            panel1.Controls.Add(txtCityCode);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblCountry);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtCityName);
            panel1.Controls.Add(lblCityName);
            panel1.Controls.Add(lblCityCode);
            panel1.Controls.Add(lblFormatNumber);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 207);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(434, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 29);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.Location = new Point(182, 36);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(146, 20);
            lblCountry.TabIndex = 7;
            lblCountry.Text = "Беларусь (+375)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 20);
            label1.TabIndex = 7;
            label1.Text = "Редактирование списка городов для";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(0, 71, 160);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(312, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 32);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.BackColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(0, 71, 160);
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(164, 166);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 32);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Изменить";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(0, 71, 160);
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(16, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorValidating
            // 
            errorValidating.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorValidating.ContainerControl = this;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(115, 115, 115);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(474, 491);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(pnlGrid);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(4);
            panel3.Size = new Size(472, 489);
            panel3.TabIndex = 10;
            // 
            // EditCity
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(474, 491);
            ControlBox = false;
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "EditCity";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += EditCity_Load;
            pnlGrid.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidating).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGrid;
        private Panel panel1;
        private TextBox txtCityName;
        private AutoLabel lblCityName;
        private AutoLabel lblCityCode;
        private AutoLabel lblFormatNumber;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private UserControls.GridControl gridCities;
        private Button btnClose;
        private Label label1;
        private Label lblCountry;
        private ErrorProvider errorValidating;
        private Panel panel2;
        private Panel panel3;
        private MaskedTextBox txtCityCode;
        private MaskedTextBox txtFormatNumber;
    }
}