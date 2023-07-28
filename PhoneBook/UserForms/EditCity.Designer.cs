
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCity));
            this.lblCityName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.lblCityCode = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCityCode = new System.Windows.Forms.MaskedTextBox();
            this.lblFormatNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtFormatNumber = new System.Windows.Forms.MaskedTextBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gridCities = new PhoneBook.UserControls.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
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
            // lblCityName
            // 
            this.lblCityName.DX = -148;
            this.lblCityName.DY = 3;
            this.lblCityName.ForeColor = System.Drawing.Color.White;
            this.lblCityName.Gap = 10;
            this.lblCityName.LabeledControl = this.txtCityName;
            this.lblCityName.Location = new System.Drawing.Point(84, 69);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(138, 19);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "Наименование:";
            // 
            // txtCityName
            // 
            this.txtCityName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtCityName.Location = new System.Drawing.Point(232, 66);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(184, 26);
            this.txtCityName.TabIndex = 0;
            this.txtCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCityCode
            // 
            this.lblCityCode.DX = -115;
            this.lblCityCode.DY = 4;
            this.lblCityCode.ForeColor = System.Drawing.Color.White;
            this.lblCityCode.Gap = 10;
            this.lblCityCode.LabeledControl = this.txtCityCode;
            this.lblCityCode.Location = new System.Drawing.Point(117, 104);
            this.lblCityCode.Name = "lblCityCode";
            this.lblCityCode.Size = new System.Drawing.Size(105, 19);
            this.lblCityCode.TabIndex = 0;
            this.lblCityCode.Text = "Код города:";
            // 
            // txtCityCode
            // 
            this.txtCityCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtCityCode.HidePromptOnLeave = true;
            this.txtCityCode.Location = new System.Drawing.Point(232, 100);
            this.txtCityCode.Mask = "0000000";
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Size = new System.Drawing.Size(184, 27);
            this.txtCityCode.TabIndex = 1;
            this.txtCityCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFormatNumber
            // 
            this.lblFormatNumber.DX = -157;
            this.lblFormatNumber.DY = 4;
            this.lblFormatNumber.ForeColor = System.Drawing.Color.White;
            this.lblFormatNumber.Gap = 10;
            this.lblFormatNumber.LabeledControl = this.txtFormatNumber;
            this.lblFormatNumber.Location = new System.Drawing.Point(75, 137);
            this.lblFormatNumber.Name = "lblFormatNumber";
            this.lblFormatNumber.Size = new System.Drawing.Size(147, 19);
            this.lblFormatNumber.TabIndex = 0;
            this.lblFormatNumber.Text = "Формат номера:";
            // 
            // txtFormatNumber
            // 
            this.txtFormatNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtFormatNumber.Location = new System.Drawing.Point(232, 133);
            this.txtFormatNumber.Name = "txtFormatNumber";
            this.txtFormatNumber.Size = new System.Drawing.Size(184, 27);
            this.txtFormatNumber.TabIndex = 2;
            this.txtFormatNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFormatNumber.Enter += new System.EventHandler(this.txtFormatNumber_Enter);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlGrid.Controls.Add(this.gridCities);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.Location = new System.Drawing.Point(4, 213);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(472, 280);
            this.pnlGrid.TabIndex = 0;
            // 
            // gridCities
            // 
            this.gridCities.BackColor = System.Drawing.Color.White;
            this.gridCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.gridCities.Location = new System.Drawing.Point(0, 0);
            this.gridCities.Margin = new System.Windows.Forms.Padding(4);
            this.gridCities.Name = "gridCities";
            this.gridCities.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.gridCities.Size = new System.Drawing.Size(472, 280);
            this.gridCities.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.txtFormatNumber);
            this.panel1.Controls.Add(this.txtCityCode);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtCityName);
            this.panel1.Controls.Add(this.lblCityName);
            this.panel1.Controls.Add(this.lblCityCode);
            this.panel1.Controls.Add(this.lblFormatNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 209);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(450, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.Location = new System.Drawing.Point(182, 36);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(139, 19);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Беларусь (+375)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Редактирование списка городов для";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Image = global::PhoneBook.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(316, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 5;
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
            this.btnEdit.Location = new System.Drawing.Point(168, 167);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 32);
            this.btnEdit.TabIndex = 4;
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
            this.btnAdd.Location = new System.Drawing.Point(20, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 32);
            this.btnAdd.TabIndex = 3;
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
            this.panel2.Size = new System.Drawing.Size(482, 499);
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
            this.panel3.Size = new System.Drawing.Size(480, 497);
            this.panel3.TabIndex = 10;
            // 
            // EditCity
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 499);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditCity";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditCity_Load);
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
        private System.Windows.Forms.TextBox txtCityName;
        private AutoLabel lblCityName;
        private AutoLabel lblCityCode;
        private AutoLabel lblFormatNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private UserControls.GridControl gridCities;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ErrorProvider errorValidating;
        private Panel panel2;
        private Panel panel3;
        private MaskedTextBox txtCityCode;
        private MaskedTextBox txtFormatNumber;
    }
}