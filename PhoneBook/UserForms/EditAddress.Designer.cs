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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(637, 699);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pnlTop);
            panel2.Controls.Add(pnlGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(635, 697);
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
            pnlTop.Location = new Point(5, 5);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(625, 269);
            pnlTop.TabIndex = 0;
            // 
            // houseControl
            // 
            houseControl.BackColor = Color.FromArgb(0, 71, 160);
            houseControl.Location = new Point(499, 129);
            houseControl.Margin = new Padding(3, 5, 3, 5);
            houseControl.Name = "houseControl";
            houseControl.Size = new Size(104, 72);
            houseControl.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(0, 71, 160);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(404, 210);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 40);
            btnDelete.TabIndex = 6;
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
            btnEdit.Location = new Point(235, 210);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 40);
            btnEdit.TabIndex = 5;
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
            btnAdd.Location = new Point(66, 210);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // streetNameControl
            // 
            streetNameControl.BackColor = Color.FromArgb(0, 71, 160);
            streetNameControl.Location = new Point(197, 129);
            streetNameControl.Margin = new Padding(3, 5, 3, 5);
            streetNameControl.Name = "streetNameControl";
            streetNameControl.Size = new Size(296, 72);
            streetNameControl.TabIndex = 2;
            // 
            // typeStreetControl
            // 
            typeStreetControl.BackColor = Color.FromArgb(0, 71, 160);
            typeStreetControl.Location = new Point(22, 129);
            typeStreetControl.Margin = new Padding(3, 5, 3, 5);
            typeStreetControl.Name = "typeStreetControl";
            typeStreetControl.Size = new Size(168, 72);
            typeStreetControl.TabIndex = 1;
            // 
            // localityControl
            // 
            localityControl.BackColor = Color.FromArgb(0, 71, 160);
            localityControl.Location = new Point(22, 49);
            localityControl.Margin = new Padding(3, 5, 3, 5);
            localityControl.Name = "localityControl";
            localityControl.Size = new Size(360, 72);
            localityControl.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(587, -1);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 39);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(8, 8);
            labelHeader.MaximumSize = new Size(571, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(289, 23);
            labelHeader.TabIndex = 9;
            labelHeader.Text = "Редактирование адреса n:";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(gridAddresses);
            pnlGrid.Dock = DockStyle.Bottom;
            pnlGrid.Location = new Point(5, 274);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(625, 418);
            pnlGrid.TabIndex = 1;
            // 
            // gridAddresses
            // 
            gridAddresses.BackColor = Color.White;
            gridAddresses.Dock = DockStyle.Fill;
            gridAddresses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridAddresses.ForeColor = Color.FromArgb(0, 71, 160);
            gridAddresses.Location = new Point(0, 0);
            gridAddresses.Margin = new Padding(3, 4, 3, 4);
            gridAddresses.Name = "gridAddresses";
            gridAddresses.Padding = new Padding(0, 7, 0, 0);
            gridAddresses.Size = new Size(625, 418);
            gridAddresses.TabIndex = 0;
            // 
            // errorValidating
            // 
            errorValidating.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorValidating.ContainerControl = this;
            // 
            // EditAddress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(637, 699);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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