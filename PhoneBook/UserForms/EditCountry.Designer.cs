
using Syncfusion.Windows.Forms.Tools;

namespace PhoneBook.Forms
{
    partial class EditCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCountry));
            lblCountryName = new AutoLabel();
            txtCountryName = new TextBox();
            lblCountryCode = new AutoLabel();
            txtCountryCode = new MaskedTextBox();
            lblCountDigits = new AutoLabel();
            txtCountDigits = new MaskedTextBox();
            lblExample = new AutoLabel();
            txtExample = new MaskedTextBox();
            pnlGrid = new Panel();
            gridCountries = new UserControls.GridControl();
            panel1 = new Panel();
            btnClose = new Button();
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
            // lblCountryName
            // 
            lblCountryName.DX = -180;
            lblCountryName.DY = 3;
            lblCountryName.ForeColor = Color.White;
            lblCountryName.Gap = 10;
            lblCountryName.LabeledControl = txtCountryName;
            lblCountryName.Location = new Point(91, 46);
            lblCountryName.Name = "lblCountryName";
            lblCountryName.Size = new Size(170, 23);
            lblCountryName.TabIndex = 0;
            lblCountryName.Text = "Наименование:";
            // 
            // txtCountryName
            // 
            txtCountryName.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCountryName.ForeColor = Color.FromArgb(0, 71, 160);
            txtCountryName.Location = new Point(271, 43);
            txtCountryName.Name = "txtCountryName";
            txtCountryName.Size = new Size(184, 30);
            txtCountryName.TabIndex = 0;
            txtCountryName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCountryCode
            // 
            lblCountryCode.DX = -147;
            lblCountryCode.DY = 4;
            lblCountryCode.ForeColor = Color.White;
            lblCountryCode.Gap = 10;
            lblCountryCode.LabeledControl = txtCountryCode;
            lblCountryCode.Location = new Point(124, 79);
            lblCountryCode.Name = "lblCountryCode";
            lblCountryCode.Size = new Size(137, 23);
            lblCountryCode.TabIndex = 0;
            lblCountryCode.Text = "Код страны:";
            // 
            // txtCountryCode
            // 
            txtCountryCode.ForeColor = Color.FromArgb(0, 71, 160);
            txtCountryCode.HidePromptOnLeave = true;
            txtCountryCode.Location = new Point(271, 75);
            txtCountryCode.Mask = "+00000";
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.Size = new Size(184, 32);
            txtCountryCode.TabIndex = 1;
            txtCountryCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCountDigits
            // 
            lblCountDigits.DX = -261;
            lblCountDigits.DY = 4;
            lblCountDigits.ForeColor = Color.White;
            lblCountDigits.Gap = 10;
            lblCountDigits.LabeledControl = txtCountDigits;
            lblCountDigits.Location = new Point(10, 112);
            lblCountDigits.Name = "lblCountDigits";
            lblCountDigits.Size = new Size(251, 23);
            lblCountDigits.TabIndex = 0;
            lblCountDigits.Text = "Кол-во цифр в номере:";
            // 
            // txtCountDigits
            // 
            txtCountDigits.ForeColor = Color.FromArgb(0, 71, 160);
            txtCountDigits.HidePromptOnLeave = true;
            txtCountDigits.Location = new Point(271, 108);
            txtCountDigits.Mask = "00";
            txtCountDigits.Name = "txtCountDigits";
            txtCountDigits.Size = new Size(184, 32);
            txtCountDigits.TabIndex = 2;
            txtCountDigits.TextAlign = HorizontalAlignment.Center;
            // 
            // lblExample
            // 
            lblExample.DX = -193;
            lblExample.DY = 4;
            lblExample.ForeColor = Color.White;
            lblExample.Gap = 10;
            lblExample.LabeledControl = txtExample;
            lblExample.Location = new Point(78, 145);
            lblExample.Name = "lblExample";
            lblExample.Size = new Size(183, 23);
            lblExample.TabIndex = 0;
            lblExample.Text = "Пример номера:";
            // 
            // txtExample
            // 
            txtExample.ForeColor = Color.FromArgb(0, 71, 160);
            txtExample.Location = new Point(271, 141);
            txtExample.Name = "txtExample";
            txtExample.Size = new Size(184, 32);
            txtExample.TabIndex = 3;
            txtExample.TextAlign = HorizontalAlignment.Center;
            txtExample.Enter += txtExample_Enter;
            txtExample.Validated += txtExample_Validated;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(0, 71, 160);
            pnlGrid.Controls.Add(gridCountries);
            pnlGrid.Dock = DockStyle.Bottom;
            pnlGrid.Location = new Point(4, 257);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(488, 321);
            pnlGrid.TabIndex = 0;
            // 
            // gridCountries
            // 
            gridCountries.BackColor = Color.White;
            gridCountries.Dock = DockStyle.Fill;
            gridCountries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridCountries.ForeColor = Color.FromArgb(0, 71, 160);
            gridCountries.Location = new Point(0, 0);
            gridCountries.Margin = new Padding(4);
            gridCountries.Name = "gridCountries";
            gridCountries.Padding = new Padding(0, 5, 0, 0);
            gridCountries.Size = new Size(488, 321);
            gridCountries.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(txtExample);
            panel1.Controls.Add(txtCountryCode);
            panel1.Controls.Add(txtCountDigits);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtCountryName);
            panel1.Controls.Add(lblCountryName);
            panel1.Controls.Add(lblCountryCode);
            panel1.Controls.Add(lblCountDigits);
            panel1.Controls.Add(lblExample);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 253);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(454, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 29);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 23);
            label1.TabIndex = 7;
            label1.Text = "Редактирование списка стран:";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(0, 71, 160);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(321, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 40);
            btnDelete.TabIndex = 6;
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
            btnEdit.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(0, 71, 160);
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(173, 202);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 40);
            btnEdit.TabIndex = 5;
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
            btnAdd.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(0, 71, 160);
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(25, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 40);
            btnAdd.TabIndex = 4;
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
            panel2.Size = new Size(498, 584);
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
            panel3.Size = new Size(496, 582);
            panel3.TabIndex = 9;
            // 
            // EditCountry
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 584);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditCountry";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += EditCountry_Load;
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
        private TextBox txtCountryName;
        private AutoLabel lblCountryName;
        private AutoLabel lblCountryCode;
        private AutoLabel lblCountDigits;
        private AutoLabel lblExample;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private UserControls.GridControl gridCountries;
        private Button btnClose;
        private Label label1;
        private MaskedTextBox txtCountDigits;
        private ErrorProvider errorValidating;
        private Panel panel2;
        private Panel panel3;
        private MaskedTextBox txtCountryCode;
        private MaskedTextBox txtExample;
    }
}