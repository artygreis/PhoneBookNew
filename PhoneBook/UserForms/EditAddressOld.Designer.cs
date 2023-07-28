
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    partial class EditAddressOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAddressOld));
            this.lblTypeStreet = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxTypeStreet = new System.Windows.Forms.TextBox();
            this.lblStreetName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.lblHouse = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorValidating = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypeStreet
            // 
            this.lblTypeStreet.DY = -24;
            this.lblTypeStreet.ForeColor = System.Drawing.Color.White;
            this.lblTypeStreet.Gap = 5;
            this.lblTypeStreet.LabeledControl = this.textBoxTypeStreet;
            this.lblTypeStreet.Location = new System.Drawing.Point(34, 100);
            this.lblTypeStreet.Name = "lblTypeStreet";
            this.lblTypeStreet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblTypeStreet.Size = new System.Drawing.Size(95, 19);
            this.lblTypeStreet.TabIndex = 0;
            this.lblTypeStreet.Text = "Тип улицы:";
            // 
            // textBoxTypeStreet
            // 
            this.textBoxTypeStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxTypeStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxTypeStreet.Location = new System.Drawing.Point(34, 124);
            this.textBoxTypeStreet.Name = "textBoxTypeStreet";
            this.textBoxTypeStreet.Size = new System.Drawing.Size(141, 27);
            this.textBoxTypeStreet.TabIndex = 1;
            this.textBoxTypeStreet.Leave += new System.EventHandler(this.textBoxTypeStreet_Leave);
            // 
            // lblStreetName
            // 
            this.lblStreetName.DY = -24;
            this.lblStreetName.ForeColor = System.Drawing.Color.White;
            this.lblStreetName.Gap = 5;
            this.lblStreetName.LabeledControl = this.textBoxStreetName;
            this.lblStreetName.Location = new System.Drawing.Point(198, 100);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblStreetName.Size = new System.Drawing.Size(193, 19);
            this.lblStreetName.TabIndex = 0;
            this.lblStreetName.Text = "Наименование улицы:";
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxStreetName.Location = new System.Drawing.Point(198, 124);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(253, 27);
            this.textBoxStreetName.TabIndex = 2;
            // 
            // lblHouse
            // 
            this.lblHouse.DY = -24;
            this.lblHouse.ForeColor = System.Drawing.Color.White;
            this.lblHouse.Gap = 5;
            this.lblHouse.LabeledControl = this.txtHouse;
            this.lblHouse.Location = new System.Drawing.Point(474, 100);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblHouse.Size = new System.Drawing.Size(74, 19);
            this.lblHouse.TabIndex = 0;
            this.lblHouse.Text = "Дом, №:";
            // 
            // txtHouse
            // 
            this.txtHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtHouse.Location = new System.Drawing.Point(474, 124);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(85, 27);
            this.txtHouse.TabIndex = 3;
            this.txtHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.Location = new System.Drawing.Point(4, 213);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(940, 327);
            this.pnlGrid.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlTop.Controls.Add(this.textBoxTypeStreet);
            this.pnlTop.Controls.Add(this.txtHouse);
            this.pnlTop.Controls.Add(this.textBoxStreetName);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.labelHeader);
            this.pnlTop.Controls.Add(this.btnDelete);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.lblTypeStreet);
            this.pnlTop.Controls.Add(this.lblStreetName);
            this.pnlTop.Controls.Add(this.lblHouse);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(940, 209);
            this.pnlTop.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(311, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(232, 19);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "Редактирование адреса n:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Image = global::PhoneBook.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(548, 163);
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
            this.btnEdit.Location = new System.Drawing.Point(400, 163);
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
            this.btnAdd.Location = new System.Drawing.Point(252, 163);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(950, 546);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnlTop);
            this.panel2.Controls.Add(this.pnlGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(948, 544);
            this.panel2.TabIndex = 0;
            // 
            // EditAddressOld
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 546);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditAddressOld";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditAddress_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlTop;
        private AutoLabel lblTypeStreet;
        private AutoLabel lblStreetName;
        private AutoLabel lblHouse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private UserControls.GridControl gridAddresses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelHeader;
        private TextBox txtHouse;
        private TextBox textBoxStreetName;
        private TextBox textBoxTypeStreet;
        private ErrorProvider errorValidating;
        private Panel panel1;
        private Panel panel2;
        private UserControls.LocalityControl localityControl;
    }
}