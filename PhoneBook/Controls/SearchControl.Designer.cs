namespace PhoneBook.Controls
{
    partial class SearchControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            tabControlAdv = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            searchByAddressTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            btnClearResultSearch = new Button();
            btnListResultAddresses = new Button();
            btnAddSearch = new Button();
            btnSearch = new Button();
            pnlFilterPrivateHouse = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            rdbOdd = new RadioButton();
            rdbEven = new RadioButton();
            rdbAll = new RadioButton();
            chkPrivateHouse = new CheckBox();
            grpApartment = new GroupBox();
            txtSingle = new TextBox();
            grpApartments = new GroupBox();
            lblTo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtTo = new TextBox();
            lblFrom = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtFrom = new TextBox();
            autoCompleteControlAddress = new UserControls.AutoCompleteControl();
            lblAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblCity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoCompleteControlCity = new UserControls.AutoCompleteControl();
            lblCountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoCompleteControlCountry = new UserControls.AutoCompleteControl();
            tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            gridPhones = new UserControls.GridControl();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv).BeginInit();
            tabControlAdv.SuspendLayout();
            searchByAddressTab.SuspendLayout();
            pnlFilterPrivateHouse.SuspendLayout();
            grpApartment.SuspendLayout();
            grpApartments.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAdv
            // 
            tabControlAdv.BackColor = Color.FromArgb(0, 71, 160);
            tabControlAdv.BeforeTouchSize = new Size(825, 250);
            tabControlAdv.Controls.Add(searchByAddressTab);
            tabControlAdv.Controls.Add(tabPageAdv2);
            tabControlAdv.Dock = DockStyle.Top;
            tabControlAdv.Location = new Point(5, 5);
            tabControlAdv.Name = "tabControlAdv";
            tabControlAdv.Size = new Size(825, 250);
            tabControlAdv.TabIndex = 4;
            tabControlAdv.SelectedIndexChanged += tabControlAdv_SelectedIndexChanged;
            // 
            // searchByAddressTab
            // 
            searchByAddressTab.Controls.Add(btnClearResultSearch);
            searchByAddressTab.Controls.Add(btnListResultAddresses);
            searchByAddressTab.Controls.Add(btnAddSearch);
            searchByAddressTab.Controls.Add(btnSearch);
            searchByAddressTab.Controls.Add(pnlFilterPrivateHouse);
            searchByAddressTab.Controls.Add(chkPrivateHouse);
            searchByAddressTab.Controls.Add(grpApartment);
            searchByAddressTab.Controls.Add(grpApartments);
            searchByAddressTab.Controls.Add(autoCompleteControlAddress);
            searchByAddressTab.Controls.Add(lblAddress);
            searchByAddressTab.Controls.Add(lblCity);
            searchByAddressTab.Controls.Add(autoCompleteControlCity);
            searchByAddressTab.Controls.Add(lblCountry);
            searchByAddressTab.Controls.Add(autoCompleteControlCountry);
            searchByAddressTab.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchByAddressTab.ForeColor = Color.White;
            searchByAddressTab.Image = null;
            searchByAddressTab.ImageSize = new Size(16, 16);
            searchByAddressTab.Location = new Point(1, 31);
            searchByAddressTab.Name = "searchByAddressTab";
            searchByAddressTab.ShowCloseButton = true;
            searchByAddressTab.Size = new Size(822, 217);
            searchByAddressTab.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchByAddressTab.TabForeColor = Color.White;
            searchByAddressTab.TabIndex = 1;
            searchByAddressTab.Text = "Поиск по адресу";
            searchByAddressTab.ThemesEnabled = false;
            // 
            // btnClearResultSearch
            // 
            btnClearResultSearch.BackColor = Color.White;
            btnClearResultSearch.Enabled = false;
            btnClearResultSearch.FlatStyle = FlatStyle.Flat;
            btnClearResultSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearResultSearch.ForeColor = Color.FromArgb(0, 71, 160);
            btnClearResultSearch.Image = (Image)resources.GetObject("btnClearResultSearch.Image");
            btnClearResultSearch.Location = new Point(571, 146);
            btnClearResultSearch.Name = "btnClearResultSearch";
            btnClearResultSearch.Size = new Size(35, 32);
            btnClearResultSearch.TabIndex = 14;
            btnClearResultSearch.UseVisualStyleBackColor = false;
            btnClearResultSearch.Click += btnClearResultSearch_Click;
            // 
            // btnListResultAddresses
            // 
            btnListResultAddresses.BackColor = Color.White;
            btnListResultAddresses.Enabled = false;
            btnListResultAddresses.FlatStyle = FlatStyle.Flat;
            btnListResultAddresses.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListResultAddresses.ForeColor = Color.FromArgb(0, 71, 160);
            btnListResultAddresses.Image = (Image)resources.GetObject("btnListResultAddresses.Image");
            btnListResultAddresses.Location = new Point(530, 146);
            btnListResultAddresses.Name = "btnListResultAddresses";
            btnListResultAddresses.Size = new Size(35, 32);
            btnListResultAddresses.TabIndex = 13;
            btnListResultAddresses.UseVisualStyleBackColor = false;
            btnListResultAddresses.Click += btnListResultAddresses_Click;
            // 
            // btnAddSearch
            // 
            btnAddSearch.BackColor = Color.White;
            btnAddSearch.Enabled = false;
            btnAddSearch.FlatStyle = FlatStyle.Flat;
            btnAddSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSearch.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddSearch.Image = (Image)resources.GetObject("btnAddSearch.Image");
            btnAddSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSearch.Location = new Point(323, 146);
            btnAddSearch.Name = "btnAddSearch";
            btnAddSearch.Size = new Size(201, 32);
            btnAddSearch.TabIndex = 12;
            btnAddSearch.Text = "     Добавить к поиску";
            btnAddSearch.UseVisualStyleBackColor = false;
            btnAddSearch.Click += btnAddSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(0, 71, 160);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(216, 146);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 32);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "     Найти";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlFilterPrivateHouse
            // 
            pnlFilterPrivateHouse.Controls.Add(panel4);
            pnlFilterPrivateHouse.Controls.Add(panel3);
            pnlFilterPrivateHouse.Controls.Add(panel2);
            pnlFilterPrivateHouse.Controls.Add(panel1);
            pnlFilterPrivateHouse.Controls.Add(rdbOdd);
            pnlFilterPrivateHouse.Controls.Add(rdbEven);
            pnlFilterPrivateHouse.Controls.Add(rdbAll);
            pnlFilterPrivateHouse.Enabled = false;
            pnlFilterPrivateHouse.Location = new Point(517, 104);
            pnlFilterPrivateHouse.Name = "pnlFilterPrivateHouse";
            pnlFilterPrivateHouse.Size = new Size(295, 29);
            pnlFilterPrivateHouse.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(294, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 27);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 27);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 1);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 1);
            panel1.TabIndex = 3;
            // 
            // rdbOdd
            // 
            rdbOdd.AutoSize = true;
            rdbOdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbOdd.Location = new Point(187, 4);
            rdbOdd.Name = "rdbOdd";
            rdbOdd.Size = new Size(90, 20);
            rdbOdd.TabIndex = 2;
            rdbOdd.TabStop = true;
            rdbOdd.Text = "Нечетные";
            rdbOdd.UseVisualStyleBackColor = true;
            // 
            // rdbEven
            // 
            rdbEven.AutoSize = true;
            rdbEven.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbEven.Location = new Point(94, 4);
            rdbEven.Name = "rdbEven";
            rdbEven.Size = new Size(74, 20);
            rdbEven.TabIndex = 1;
            rdbEven.TabStop = true;
            rdbEven.Text = "Четные";
            rdbEven.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Checked = true;
            rdbAll.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAll.Location = new Point(26, 4);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(49, 20);
            rdbAll.TabIndex = 0;
            rdbAll.TabStop = true;
            rdbAll.Text = "Все";
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // chkPrivateHouse
            // 
            chkPrivateHouse.AutoSize = true;
            chkPrivateHouse.Enabled = false;
            chkPrivateHouse.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkPrivateHouse.Location = new Point(93, 108);
            chkPrivateHouse.Name = "chkPrivateHouse";
            chkPrivateHouse.Size = new Size(123, 20);
            chkPrivateHouse.TabIndex = 9;
            chkPrivateHouse.Text = "Частные дома";
            chkPrivateHouse.UseVisualStyleBackColor = true;
            chkPrivateHouse.CheckedChanged += chkPrivateHouse_CheckedChanged;
            // 
            // grpApartment
            // 
            grpApartment.Controls.Add(txtSingle);
            grpApartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpApartment.ForeColor = Color.White;
            grpApartment.Location = new Point(517, 13);
            grpApartment.Name = "grpApartment";
            grpApartment.Size = new Size(112, 85);
            grpApartment.TabIndex = 8;
            grpApartment.TabStop = false;
            grpApartment.Text = "Квартира:";
            // 
            // txtSingle
            // 
            txtSingle.ForeColor = Color.FromArgb(0, 71, 160);
            txtSingle.Location = new Point(31, 35);
            txtSingle.Name = "txtSingle";
            txtSingle.Size = new Size(50, 27);
            txtSingle.TabIndex = 3;
            txtSingle.TextAlign = HorizontalAlignment.Center;
            txtSingle.TextChanged += txtSingle_TextChanged;
            // 
            // grpApartments
            // 
            grpApartments.Controls.Add(lblTo);
            grpApartments.Controls.Add(lblFrom);
            grpApartments.Controls.Add(txtTo);
            grpApartments.Controls.Add(txtFrom);
            grpApartments.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpApartments.ForeColor = Color.White;
            grpApartments.Location = new Point(635, 13);
            grpApartments.Name = "grpApartments";
            grpApartments.Size = new Size(177, 85);
            grpApartments.TabIndex = 7;
            grpApartments.TabStop = false;
            grpApartments.Text = "Квартиры:";
            // 
            // lblTo
            // 
            lblTo.DX = -33;
            lblTo.DY = 2;
            lblTo.LabeledControl = txtTo;
            lblTo.Location = new Point(84, 37);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(29, 19);
            lblTo.TabIndex = 3;
            lblTo.Text = "по";
            // 
            // txtTo
            // 
            txtTo.Enabled = false;
            txtTo.ForeColor = Color.FromArgb(0, 71, 160);
            txtTo.Location = new Point(117, 35);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(50, 27);
            txtTo.TabIndex = 4;
            txtTo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFrom
            // 
            lblFrom.BackColor = Color.FromArgb(0, 71, 160);
            lblFrom.DX = -23;
            lblFrom.DY = 2;
            lblFrom.LabeledControl = txtFrom;
            lblFrom.Location = new Point(6, 37);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(19, 19);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "с";
            // 
            // txtFrom
            // 
            txtFrom.ForeColor = Color.FromArgb(0, 71, 160);
            txtFrom.Location = new Point(29, 35);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(50, 27);
            txtFrom.TabIndex = 3;
            txtFrom.TextAlign = HorizontalAlignment.Center;
            txtFrom.TextChanged += txtFrom_TextChanged;
            // 
            // autoCompleteControlAddress
            // 
            autoCompleteControlAddress.AutoSize = true;
            autoCompleteControlAddress.BackColor = Color.FromArgb(0, 71, 160);
            autoCompleteControlAddress.Location = new Point(93, 72);
            autoCompleteControlAddress.MinimumSize = new Size(150, 26);
            autoCompleteControlAddress.Name = "autoCompleteControlAddress";
            autoCompleteControlAddress.Size = new Size(407, 26);
            autoCompleteControlAddress.TabIndex = 2;
            autoCompleteControlAddress.TextBoxFont = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lblAddress
            // 
            lblAddress.DX = -70;
            lblAddress.DY = 3;
            lblAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.LabeledControl = autoCompleteControlAddress;
            lblAddress.Location = new Point(23, 75);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 19);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Адрес:";
            // 
            // lblCity
            // 
            lblCity.DX = -65;
            lblCity.DY = 3;
            lblCity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.LabeledControl = autoCompleteControlCity;
            lblCity.Location = new Point(264, 25);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(61, 19);
            lblCity.TabIndex = 4;
            lblCity.Text = "Город:";
            // 
            // autoCompleteControlCity
            // 
            autoCompleteControlCity.AutoSize = true;
            autoCompleteControlCity.BackColor = Color.FromArgb(0, 71, 160);
            autoCompleteControlCity.Location = new Point(329, 22);
            autoCompleteControlCity.MinimumSize = new Size(150, 26);
            autoCompleteControlCity.Name = "autoCompleteControlCity";
            autoCompleteControlCity.Size = new Size(171, 26);
            autoCompleteControlCity.TabIndex = 1;
            autoCompleteControlCity.TextBoxFont = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lblCountry
            // 
            lblCountry.DX = -80;
            lblCountry.DY = 3;
            lblCountry.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.LabeledControl = autoCompleteControlCountry;
            lblCountry.Location = new Point(12, 25);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(76, 19);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "Страна:";
            // 
            // autoCompleteControlCountry
            // 
            autoCompleteControlCountry.AutoSize = true;
            autoCompleteControlCountry.BackColor = Color.FromArgb(0, 71, 160);
            autoCompleteControlCountry.Location = new Point(92, 22);
            autoCompleteControlCountry.MinimumSize = new Size(150, 26);
            autoCompleteControlCountry.Name = "autoCompleteControlCountry";
            autoCompleteControlCountry.Size = new Size(150, 26);
            autoCompleteControlCountry.TabIndex = 0;
            autoCompleteControlCountry.TextBoxFont = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // tabPageAdv2
            // 
            tabPageAdv2.Image = null;
            tabPageAdv2.ImageSize = new Size(16, 16);
            tabPageAdv2.Location = new Point(1, 31);
            tabPageAdv2.Name = "tabPageAdv2";
            tabPageAdv2.ShowCloseButton = true;
            tabPageAdv2.Size = new Size(822, 217);
            tabPageAdv2.TabIndex = 2;
            tabPageAdv2.Text = "tabPageAdv2";
            tabPageAdv2.ThemesEnabled = false;
            // 
            // gridPhones
            // 
            gridPhones.BackColor = Color.White;
            gridPhones.Dock = DockStyle.Fill;
            gridPhones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridPhones.ForeColor = Color.FromArgb(0, 71, 160);
            gridPhones.Location = new Point(5, 255);
            gridPhones.Name = "gridPhones";
            gridPhones.Padding = new Padding(0, 5, 0, 0);
            gridPhones.Size = new Size(825, 335);
            gridPhones.TabIndex = 5;
            // 
            // SearchControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gridPhones);
            Controls.Add(tabControlAdv);
            Name = "SearchControl";
            Padding = new Padding(5);
            Size = new Size(835, 595);
            Load += SearchControl_Load;
            ((System.ComponentModel.ISupportInitialize)tabControlAdv).EndInit();
            tabControlAdv.ResumeLayout(false);
            searchByAddressTab.ResumeLayout(false);
            searchByAddressTab.PerformLayout();
            pnlFilterPrivateHouse.ResumeLayout(false);
            pnlFilterPrivateHouse.PerformLayout();
            grpApartment.ResumeLayout(false);
            grpApartment.PerformLayout();
            grpApartments.ResumeLayout(false);
            grpApartments.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv searchByAddressTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private UserControls.GridControl gridPhones;
        private UserControls.AutoCompleteControl autoCompleteControlCountry;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCountry;
        private UserControls.AutoCompleteControl autoCompleteControlCity;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCity;
        private GroupBox grpApartments;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTo;
        private TextBox txtTo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblFrom;
        private TextBox txtFrom;
        private UserControls.AutoCompleteControl autoCompleteControlAddress;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblAddress;
        private GroupBox grpApartment;
        private TextBox txtSingle;
        private Panel pnlFilterPrivateHouse;
        private RadioButton rdbOdd;
        private RadioButton rdbEven;
        private RadioButton rdbAll;
        private CheckBox chkPrivateHouse;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnAddSearch;
        private Button btnSearch;
        private Button btnListResultAddresses;
        private Button btnClearResultSearch;
    }
}
