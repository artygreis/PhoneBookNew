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
            this.tabControlAdv = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.searchByAddressTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnClearResultSearch = new System.Windows.Forms.Button();
            this.btnListResultAddresses = new System.Windows.Forms.Button();
            this.btnAddSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlFilterPrivateHouse = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbOdd = new System.Windows.Forms.RadioButton();
            this.rdbEven = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.chkPrivateHouse = new System.Windows.Forms.CheckBox();
            this.grpApartment = new System.Windows.Forms.GroupBox();
            this.txtSingle = new System.Windows.Forms.TextBox();
            this.grpApartments = new System.Windows.Forms.GroupBox();
            this.lblTo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.autoCompleteControlAddress = new PhoneBook.UserControls.AutoCompleteControl();
            this.lblAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblCity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoCompleteControlCity = new PhoneBook.UserControls.AutoCompleteControl();
            this.lblCountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoCompleteControlCountry = new PhoneBook.UserControls.AutoCompleteControl();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gridPhones = new PhoneBook.UserControls.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv)).BeginInit();
            this.tabControlAdv.SuspendLayout();
            this.searchByAddressTab.SuspendLayout();
            this.pnlFilterPrivateHouse.SuspendLayout();
            this.grpApartment.SuspendLayout();
            this.grpApartments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv
            // 
            this.tabControlAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.tabControlAdv.BeforeTouchSize = new System.Drawing.Size(825, 250);
            this.tabControlAdv.Controls.Add(this.searchByAddressTab);
            this.tabControlAdv.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAdv.Location = new System.Drawing.Point(5, 5);
            this.tabControlAdv.Name = "tabControlAdv";
            this.tabControlAdv.Size = new System.Drawing.Size(825, 250);
            this.tabControlAdv.TabIndex = 4;
            this.tabControlAdv.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv_SelectedIndexChanged);
            // 
            // searchByAddressTab
            // 
            this.searchByAddressTab.Controls.Add(this.btnClearResultSearch);
            this.searchByAddressTab.Controls.Add(this.btnListResultAddresses);
            this.searchByAddressTab.Controls.Add(this.btnAddSearch);
            this.searchByAddressTab.Controls.Add(this.btnSearch);
            this.searchByAddressTab.Controls.Add(this.pnlFilterPrivateHouse);
            this.searchByAddressTab.Controls.Add(this.chkPrivateHouse);
            this.searchByAddressTab.Controls.Add(this.grpApartment);
            this.searchByAddressTab.Controls.Add(this.grpApartments);
            this.searchByAddressTab.Controls.Add(this.autoCompleteControlAddress);
            this.searchByAddressTab.Controls.Add(this.lblAddress);
            this.searchByAddressTab.Controls.Add(this.lblCity);
            this.searchByAddressTab.Controls.Add(this.autoCompleteControlCity);
            this.searchByAddressTab.Controls.Add(this.lblCountry);
            this.searchByAddressTab.Controls.Add(this.autoCompleteControlCountry);
            this.searchByAddressTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchByAddressTab.ForeColor = System.Drawing.Color.White;
            this.searchByAddressTab.Image = null;
            this.searchByAddressTab.ImageSize = new System.Drawing.Size(16, 16);
            this.searchByAddressTab.Location = new System.Drawing.Point(1, 31);
            this.searchByAddressTab.Name = "searchByAddressTab";
            this.searchByAddressTab.ShowCloseButton = true;
            this.searchByAddressTab.Size = new System.Drawing.Size(822, 217);
            this.searchByAddressTab.TabFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchByAddressTab.TabForeColor = System.Drawing.Color.White;
            this.searchByAddressTab.TabIndex = 1;
            this.searchByAddressTab.Text = "Поиск по адресу";
            this.searchByAddressTab.ThemesEnabled = false;
            // 
            // btnClearResultSearch
            // 
            this.btnClearResultSearch.BackColor = System.Drawing.Color.White;
            this.btnClearResultSearch.Enabled = false;
            this.btnClearResultSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearResultSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearResultSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClearResultSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClearResultSearch.Image")));
            this.btnClearResultSearch.Location = new System.Drawing.Point(571, 146);
            this.btnClearResultSearch.Name = "btnClearResultSearch";
            this.btnClearResultSearch.Size = new System.Drawing.Size(35, 32);
            this.btnClearResultSearch.TabIndex = 14;
            this.btnClearResultSearch.UseVisualStyleBackColor = false;
            this.btnClearResultSearch.Click += new System.EventHandler(this.btnClearResultSearch_Click);
            // 
            // btnListResultAddresses
            // 
            this.btnListResultAddresses.BackColor = System.Drawing.Color.White;
            this.btnListResultAddresses.Enabled = false;
            this.btnListResultAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListResultAddresses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListResultAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnListResultAddresses.Image = ((System.Drawing.Image)(resources.GetObject("btnListResultAddresses.Image")));
            this.btnListResultAddresses.Location = new System.Drawing.Point(530, 146);
            this.btnListResultAddresses.Name = "btnListResultAddresses";
            this.btnListResultAddresses.Size = new System.Drawing.Size(35, 32);
            this.btnListResultAddresses.TabIndex = 13;
            this.btnListResultAddresses.UseVisualStyleBackColor = false;
            this.btnListResultAddresses.Click += new System.EventHandler(this.btnListResultAddresses_Click);
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.BackColor = System.Drawing.Color.White;
            this.btnAddSearch.Enabled = false;
            this.btnAddSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSearch.Image")));
            this.btnAddSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSearch.Location = new System.Drawing.Point(323, 146);
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(201, 32);
            this.btnAddSearch.TabIndex = 12;
            this.btnAddSearch.Text = "     Добавить к поиску";
            this.btnAddSearch.UseVisualStyleBackColor = false;
            this.btnAddSearch.Click += new System.EventHandler(this.btnAddSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(216, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "     Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlFilterPrivateHouse
            // 
            this.pnlFilterPrivateHouse.Controls.Add(this.panel4);
            this.pnlFilterPrivateHouse.Controls.Add(this.panel3);
            this.pnlFilterPrivateHouse.Controls.Add(this.panel2);
            this.pnlFilterPrivateHouse.Controls.Add(this.panel1);
            this.pnlFilterPrivateHouse.Controls.Add(this.rdbOdd);
            this.pnlFilterPrivateHouse.Controls.Add(this.rdbEven);
            this.pnlFilterPrivateHouse.Controls.Add(this.rdbAll);
            this.pnlFilterPrivateHouse.Enabled = false;
            this.pnlFilterPrivateHouse.Location = new System.Drawing.Point(517, 104);
            this.pnlFilterPrivateHouse.Name = "pnlFilterPrivateHouse";
            this.pnlFilterPrivateHouse.Size = new System.Drawing.Size(295, 29);
            this.pnlFilterPrivateHouse.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(294, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 27);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 27);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 1);
            this.panel1.TabIndex = 3;
            // 
            // rdbOdd
            // 
            this.rdbOdd.AutoSize = true;
            this.rdbOdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbOdd.Location = new System.Drawing.Point(187, 4);
            this.rdbOdd.Name = "rdbOdd";
            this.rdbOdd.Size = new System.Drawing.Size(90, 20);
            this.rdbOdd.TabIndex = 2;
            this.rdbOdd.TabStop = true;
            this.rdbOdd.Text = "Нечетные";
            this.rdbOdd.UseVisualStyleBackColor = true;
            // 
            // rdbEven
            // 
            this.rdbEven.AutoSize = true;
            this.rdbEven.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbEven.Location = new System.Drawing.Point(94, 4);
            this.rdbEven.Name = "rdbEven";
            this.rdbEven.Size = new System.Drawing.Size(74, 20);
            this.rdbEven.TabIndex = 1;
            this.rdbEven.TabStop = true;
            this.rdbEven.Text = "Четные";
            this.rdbEven.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbAll.Location = new System.Drawing.Point(26, 4);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(49, 20);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Все";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // chkPrivateHouse
            // 
            this.chkPrivateHouse.AutoSize = true;
            this.chkPrivateHouse.Enabled = false;
            this.chkPrivateHouse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPrivateHouse.Location = new System.Drawing.Point(93, 108);
            this.chkPrivateHouse.Name = "chkPrivateHouse";
            this.chkPrivateHouse.Size = new System.Drawing.Size(123, 20);
            this.chkPrivateHouse.TabIndex = 9;
            this.chkPrivateHouse.Text = "Частные дома";
            this.chkPrivateHouse.UseVisualStyleBackColor = true;
            this.chkPrivateHouse.CheckedChanged += new System.EventHandler(this.chkPrivateHouse_CheckedChanged);
            // 
            // grpApartment
            // 
            this.grpApartment.Controls.Add(this.txtSingle);
            this.grpApartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpApartment.ForeColor = System.Drawing.Color.White;
            this.grpApartment.Location = new System.Drawing.Point(517, 13);
            this.grpApartment.Name = "grpApartment";
            this.grpApartment.Size = new System.Drawing.Size(112, 85);
            this.grpApartment.TabIndex = 8;
            this.grpApartment.TabStop = false;
            this.grpApartment.Text = "Квартира:";
            // 
            // txtSingle
            // 
            this.txtSingle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtSingle.Location = new System.Drawing.Point(31, 35);
            this.txtSingle.Name = "txtSingle";
            this.txtSingle.Size = new System.Drawing.Size(50, 27);
            this.txtSingle.TabIndex = 3;
            this.txtSingle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSingle.TextChanged += new System.EventHandler(this.txtSingle_TextChanged);
            // 
            // grpApartments
            // 
            this.grpApartments.Controls.Add(this.lblTo);
            this.grpApartments.Controls.Add(this.lblFrom);
            this.grpApartments.Controls.Add(this.txtTo);
            this.grpApartments.Controls.Add(this.txtFrom);
            this.grpApartments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpApartments.ForeColor = System.Drawing.Color.White;
            this.grpApartments.Location = new System.Drawing.Point(635, 13);
            this.grpApartments.Name = "grpApartments";
            this.grpApartments.Size = new System.Drawing.Size(177, 85);
            this.grpApartments.TabIndex = 7;
            this.grpApartments.TabStop = false;
            this.grpApartments.Text = "Квартиры:";
            // 
            // lblTo
            // 
            this.lblTo.DX = -33;
            this.lblTo.DY = 2;
            this.lblTo.LabeledControl = this.txtTo;
            this.lblTo.Location = new System.Drawing.Point(84, 37);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 19);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "по";
            // 
            // txtTo
            // 
            this.txtTo.Enabled = false;
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtTo.Location = new System.Drawing.Point(117, 35);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(50, 27);
            this.txtTo.TabIndex = 4;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblFrom.DX = -23;
            this.lblFrom.DY = 2;
            this.lblFrom.LabeledControl = this.txtFrom;
            this.lblFrom.Location = new System.Drawing.Point(6, 37);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(19, 19);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "с";
            // 
            // txtFrom
            // 
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtFrom.Location = new System.Drawing.Point(29, 35);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(50, 27);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // autoCompleteControlAddress
            // 
            this.autoCompleteControlAddress.AutoSize = true;
            this.autoCompleteControlAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlAddress.Location = new System.Drawing.Point(93, 72);
            this.autoCompleteControlAddress.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlAddress.Name = "autoCompleteControlAddress";
            this.autoCompleteControlAddress.Size = new System.Drawing.Size(407, 26);
            this.autoCompleteControlAddress.TabIndex = 2;
            this.autoCompleteControlAddress.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lblAddress
            // 
            this.lblAddress.DX = -70;
            this.lblAddress.DY = 3;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.LabeledControl = this.autoCompleteControlAddress;
            this.lblAddress.Location = new System.Drawing.Point(23, 75);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 19);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адрес:";
            // 
            // lblCity
            // 
            this.lblCity.DX = -65;
            this.lblCity.DY = 3;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.LabeledControl = this.autoCompleteControlCity;
            this.lblCity.Location = new System.Drawing.Point(264, 25);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 19);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "Город:";
            // 
            // autoCompleteControlCity
            // 
            this.autoCompleteControlCity.AutoSize = true;
            this.autoCompleteControlCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlCity.Location = new System.Drawing.Point(329, 22);
            this.autoCompleteControlCity.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlCity.Name = "autoCompleteControlCity";
            this.autoCompleteControlCity.Size = new System.Drawing.Size(171, 26);
            this.autoCompleteControlCity.TabIndex = 1;
            this.autoCompleteControlCity.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lblCountry
            // 
            this.lblCountry.DX = -80;
            this.lblCountry.DY = 3;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.LabeledControl = this.autoCompleteControlCountry;
            this.lblCountry.Location = new System.Drawing.Point(12, 25);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(76, 19);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Страна:";
            // 
            // autoCompleteControlCountry
            // 
            this.autoCompleteControlCountry.AutoSize = true;
            this.autoCompleteControlCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlCountry.Location = new System.Drawing.Point(92, 22);
            this.autoCompleteControlCountry.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlCountry.Name = "autoCompleteControlCountry";
            this.autoCompleteControlCountry.Size = new System.Drawing.Size(150, 26);
            this.autoCompleteControlCountry.TabIndex = 0;
            this.autoCompleteControlCountry.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 31);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(822, 217);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // gridPhones
            // 
            this.gridPhones.BackColor = System.Drawing.Color.White;
            this.gridPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridPhones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.gridPhones.Location = new System.Drawing.Point(5, 255);
            this.gridPhones.Name = "gridPhones";
            this.gridPhones.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.gridPhones.Size = new System.Drawing.Size(825, 335);
            this.gridPhones.TabIndex = 5;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridPhones);
            this.Controls.Add(this.tabControlAdv);
            this.Name = "SearchControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(835, 595);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv)).EndInit();
            this.tabControlAdv.ResumeLayout(false);
            this.searchByAddressTab.ResumeLayout(false);
            this.searchByAddressTab.PerformLayout();
            this.pnlFilterPrivateHouse.ResumeLayout(false);
            this.pnlFilterPrivateHouse.PerformLayout();
            this.grpApartment.ResumeLayout(false);
            this.grpApartment.PerformLayout();
            this.grpApartments.ResumeLayout(false);
            this.grpApartments.PerformLayout();
            this.ResumeLayout(false);

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
