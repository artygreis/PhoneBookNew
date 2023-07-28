
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCountry));
            this.lblCountryName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.lblCountryCode = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCountryCode = new System.Windows.Forms.MaskedTextBox();
            this.lblCountDigits = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCountDigits = new System.Windows.Forms.MaskedTextBox();
            this.lblExample = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtExample = new System.Windows.Forms.MaskedTextBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gridCountries = new PhoneBook.UserControls.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorValidating = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountryName
            // 
            this.lblCountryName.DX = -148;
            this.lblCountryName.DY = 3;
            this.lblCountryName.ForeColor = System.Drawing.Color.White;
            this.lblCountryName.Gap = 10;
            this.lblCountryName.LabeledControl = this.txtCountryName;
            this.lblCountryName.Location = new System.Drawing.Point(123, 46);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(138, 19);
            this.lblCountryName.TabIndex = 0;
            this.lblCountryName.Text = "Наименование:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCountryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtCountryName.Location = new System.Drawing.Point(271, 43);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(184, 26);
            this.txtCountryName.TabIndex = 0;
            this.txtCountryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.DX = -119;
            this.lblCountryCode.DY = 4;
            this.lblCountryCode.ForeColor = System.Drawing.Color.White;
            this.lblCountryCode.Gap = 10;
            this.lblCountryCode.LabeledControl = this.txtCountryCode;
            this.lblCountryCode.Location = new System.Drawing.Point(152, 79);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(109, 19);
            this.lblCountryCode.TabIndex = 0;
            this.lblCountryCode.Text = "Код страны:";
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtCountryCode.HidePromptOnLeave = true;
            this.txtCountryCode.Location = new System.Drawing.Point(271, 75);
            this.txtCountryCode.Mask = "+00000";
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(184, 27);
            this.txtCountryCode.TabIndex = 1;
            this.txtCountryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCountDigits
            // 
            this.lblCountDigits.DX = -251;
            this.lblCountDigits.DY = 4;
            this.lblCountDigits.ForeColor = System.Drawing.Color.White;
            this.lblCountDigits.Gap = 10;
            this.lblCountDigits.LabeledControl = this.txtCountDigits;
            this.lblCountDigits.Location = new System.Drawing.Point(20, 112);
            this.lblCountDigits.Name = "lblCountDigits";
            this.lblCountDigits.Size = new System.Drawing.Size(241, 19);
            this.lblCountDigits.TabIndex = 0;
            this.lblCountDigits.Text = "Количество цифр в номере:";
            // 
            // txtCountDigits
            // 
            this.txtCountDigits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtCountDigits.HidePromptOnLeave = true;
            this.txtCountDigits.Location = new System.Drawing.Point(271, 108);
            this.txtCountDigits.Mask = "00";
            this.txtCountDigits.Name = "txtCountDigits";
            this.txtCountDigits.Size = new System.Drawing.Size(184, 27);
            this.txtCountDigits.TabIndex = 2;
            this.txtCountDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblExample
            // 
            this.lblExample.DX = -158;
            this.lblExample.DY = 4;
            this.lblExample.ForeColor = System.Drawing.Color.White;
            this.lblExample.Gap = 10;
            this.lblExample.LabeledControl = this.txtExample;
            this.lblExample.Location = new System.Drawing.Point(113, 145);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(148, 19);
            this.lblExample.TabIndex = 0;
            this.lblExample.Text = "Пример номера:";
            // 
            // txtExample
            // 
            this.txtExample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtExample.Location = new System.Drawing.Point(271, 141);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(184, 27);
            this.txtExample.TabIndex = 3;
            this.txtExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExample.Enter += new System.EventHandler(this.txtExample_Enter);
            this.txtExample.Validated += new System.EventHandler(this.txtExample_Validated);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlGrid.Controls.Add(this.gridCountries);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.Location = new System.Drawing.Point(4, 233);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(488, 292);
            this.pnlGrid.TabIndex = 0;
            // 
            // gridCountries
            // 
            this.gridCountries.BackColor = System.Drawing.Color.White;
            this.gridCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCountries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.gridCountries.Location = new System.Drawing.Point(0, 0);
            this.gridCountries.Margin = new System.Windows.Forms.Padding(4);
            this.gridCountries.Name = "gridCountries";
            this.gridCountries.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.gridCountries.Size = new System.Drawing.Size(488, 292);
            this.gridCountries.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.txtExample);
            this.panel1.Controls.Add(this.txtCountryCode);
            this.panel1.Controls.Add(this.txtCountDigits);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtCountryName);
            this.panel1.Controls.Add(this.lblCountryName);
            this.panel1.Controls.Add(this.lblCountryCode);
            this.panel1.Controls.Add(this.lblCountDigits);
            this.panel1.Controls.Add(this.lblExample);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 229);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(452, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Редактирование списка стран:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Image = global::PhoneBook.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(321, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnEdit.Image = global::PhoneBook.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(173, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 32);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAdd.Image = global::PhoneBook.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(25, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorValidating
            // 
            this.errorValidating.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorValidating.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(498, 531);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(496, 529);
            this.panel3.TabIndex = 9;
            // 
            // EditCountry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 531);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCountry";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditCountry_Load);
            this.pnlGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCountryName;
        private AutoLabel lblCountryName;
        private AutoLabel lblCountryCode;
        private AutoLabel lblCountDigits;
        private AutoLabel lblExample;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private UserControls.GridControl gridCountries;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCountDigits;
        private System.Windows.Forms.ErrorProvider errorValidating;
        private Panel panel2;
        private Panel panel3;
        private MaskedTextBox txtCountryCode;
        private MaskedTextBox txtExample;
    }
}