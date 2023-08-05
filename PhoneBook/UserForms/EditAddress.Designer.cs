namespace PhoneBook.UserForms
{
    partial class EditAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAddress));
            panel1 = new Panel();
            panel2 = new Panel();
            pnlTop = new Panel();
            houseControl = new UserControls.HouseControl();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            streetNameControl = new UserControls.StreetNameControl();
            typeStreetControl = new UserControls.TypeStreetControl();
            localityControl = new UserControls.LocalityControl();
            btnClose = new Button();
            labelHeader = new Label();
            pnlGrid = new Panel();
            gridAddresses = new UserControls.GridControl();
            errorValidating = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlGrid.SuspendLayout();
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
            panel1.Size = new Size(557, 524);
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
            panel2.Size = new Size(555, 522);
            panel2.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(0, 71, 160);
            pnlTop.Controls.Add(houseControl);
            pnlTop.Controls.Add(btnDelete);
            pnlTop.Controls.Add(btnEdit);
            pnlTop.Controls.Add(btnAdd);
            pnlTop.Controls.Add(streetNameControl);
            pnlTop.Controls.Add(typeStreetControl);
            pnlTop.Controls.Add(localityControl);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(labelHeader);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(4, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(547, 217);
            pnlTop.TabIndex = 0;
            // 
            // houseControl
            // 
            houseControl.BackColor = Color.FromArgb(0, 71, 160);
            houseControl.Location = new Point(437, 97);
            houseControl.Name = "houseControl";
            houseControl.Size = new Size(91, 54);
            houseControl.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(0, 71, 160);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(353, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 35);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Удалить";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(0, 71, 160);
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(205, 166);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 35);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Изменить";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(0, 71, 160);
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(57, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 35);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Добавить";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // streetNameControl
            // 
            streetNameControl.BackColor = Color.FromArgb(0, 71, 160);
            streetNameControl.Location = new Point(172, 97);
            streetNameControl.Name = "streetNameControl";
            streetNameControl.Size = new Size(259, 54);
            streetNameControl.TabIndex = 12;
            // 
            // typeStreetControl
            // 
            typeStreetControl.BackColor = Color.FromArgb(0, 71, 160);
            typeStreetControl.Location = new Point(19, 97);
            typeStreetControl.Name = "typeStreetControl";
            typeStreetControl.Size = new Size(147, 54);
            typeStreetControl.TabIndex = 11;
            // 
            // localityControl
            // 
            localityControl.BackColor = Color.FromArgb(0, 71, 160);
            localityControl.Location = new Point(19, 37);
            localityControl.Name = "localityControl";
            localityControl.Size = new Size(315, 54);
            localityControl.TabIndex = 10;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(517, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 29);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(7, 6);
            labelHeader.MaximumSize = new Size(500, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(232, 19);
            labelHeader.TabIndex = 9;
            labelHeader.Text = "Редактирование адреса n:";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(gridAddresses);
            pnlGrid.Dock = DockStyle.Bottom;
            pnlGrid.Location = new Point(4, 221);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(547, 297);
            pnlGrid.TabIndex = 1;
            // 
            // gridAddresses
            // 
            gridAddresses.BackColor = Color.White;
            gridAddresses.Dock = DockStyle.Fill;
            gridAddresses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridAddresses.ForeColor = Color.FromArgb(0, 71, 160);
            gridAddresses.Location = new Point(0, 0);
            gridAddresses.Name = "gridAddresses";
            gridAddresses.Padding = new Padding(0, 5, 0, 0);
            gridAddresses.Size = new Size(547, 297);
            gridAddresses.TabIndex = 0;
            // 
            // errorValidating
            // 
            errorValidating.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorValidating.ContainerControl = this;
            // 
            // EditAddress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(557, 524);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditAddress";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAddress";
            Load += EditAddress_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorValidating).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlTop;
        private Button btnClose;
        private Label labelHeader;
        private Panel pnlGrid;
        private UserControls.GridControl gridAddresses;
        private UserControls.StreetNameControl streetNameControl;
        private UserControls.TypeStreetControl typeStreetControl;
        private UserControls.LocalityControl localityControl;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private UserControls.HouseControl houseControl;
        private ErrorProvider errorValidating;
    }
}