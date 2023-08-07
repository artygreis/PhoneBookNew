namespace PhoneBook.Controls
{
    partial class AddControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddControl));
            tabControlAddAdv = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            addNotDisturbTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            txtNumberPhone = new MaskedTextBox();
            lblNumberPhone = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnAddNotDisturbByNumberPhone = new Button();
            btnAddNotDisturbByAddress = new Button();
            apartmentControlAddNotDisturb = new UserControls.ApartmentControl();
            addressControlAddNotDisturb = new UserControls.AddressControl();
            cityControlAddNotDisturb = new UserControls.CityControl();
            countryControlAddNotDisturb = new UserControls.CountryControl();
            chkPrivateHouseAddNotDisturb = new CheckBox();
            addApartmentsTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            btnAddRange = new Button();
            btnEditNumber = new Button();
            btnAddSingle = new Button();
            addressControlAddApartments = new UserControls.AddressControl();
            cityControlAddApartments = new UserControls.CityControl();
            countryControlAddApartments = new UserControls.CountryControl();
            chkPrivateHouse = new CheckBox();
            btnEditAddressAdd = new Button();
            btnEditCityAdd = new Button();
            btnEditCountryAdd = new Button();
            gridPhones = new UserControls.GridControl();
            btnEditNotDisturb = new Button();
            ((System.ComponentModel.ISupportInitialize)tabControlAddAdv).BeginInit();
            tabControlAddAdv.SuspendLayout();
            addNotDisturbTab.SuspendLayout();
            addApartmentsTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddAdv
            // 
            tabControlAddAdv.BackColor = Color.FromArgb(0, 71, 160);
            tabControlAddAdv.BeforeTouchSize = new Size(825, 224);
            tabControlAddAdv.Controls.Add(addNotDisturbTab);
            tabControlAddAdv.Controls.Add(addApartmentsTab);
            tabControlAddAdv.Dock = DockStyle.Fill;
            tabControlAddAdv.Location = new Point(5, 5);
            tabControlAddAdv.Name = "tabControlAddAdv";
            tabControlAddAdv.Size = new Size(825, 224);
            tabControlAddAdv.TabIndex = 0;
            tabControlAddAdv.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            tabControlAddAdv.SelectedIndexChanged += tabControlAddAdv_SelectedIndexChanged;
            // 
            // addNotDisturbTab
            // 
            addNotDisturbTab.Controls.Add(btnEditNotDisturb);
            addNotDisturbTab.Controls.Add(txtNumberPhone);
            addNotDisturbTab.Controls.Add(lblNumberPhone);
            addNotDisturbTab.Controls.Add(btnAddNotDisturbByNumberPhone);
            addNotDisturbTab.Controls.Add(btnAddNotDisturbByAddress);
            addNotDisturbTab.Controls.Add(apartmentControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(addressControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(cityControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(countryControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(chkPrivateHouseAddNotDisturb);
            addNotDisturbTab.ForeColor = Color.White;
            addNotDisturbTab.Image = null;
            addNotDisturbTab.ImageSize = new Size(16, 16);
            addNotDisturbTab.Location = new Point(1, 31);
            addNotDisturbTab.Name = "addNotDisturbTab";
            addNotDisturbTab.ShowCloseButton = true;
            addNotDisturbTab.Size = new Size(822, 191);
            addNotDisturbTab.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addNotDisturbTab.TabForeColor = Color.White;
            addNotDisturbTab.TabIndex = 2;
            addNotDisturbTab.Text = "Добавить \"Не беспокоить\"";
            addNotDisturbTab.ThemesEnabled = false;
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPhone.Location = new Point(597, 68);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(156, 26);
            txtNumberPhone.TabIndex = 29;
            txtNumberPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumberPhone
            // 
            lblNumberPhone.DY = -33;
            lblNumberPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberPhone.Gap = 10;
            lblNumberPhone.LabeledControl = txtNumberPhone;
            lblNumberPhone.Location = new Point(597, 35);
            lblNumberPhone.Name = "lblNumberPhone";
            lblNumberPhone.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            lblNumberPhone.Size = new Size(156, 19);
            lblNumberPhone.TabIndex = 28;
            lblNumberPhone.Text = "Номер телефона:";
            // 
            // btnAddNotDisturbByNumberPhone
            // 
            btnAddNotDisturbByNumberPhone.BackColor = Color.White;
            btnAddNotDisturbByNumberPhone.FlatAppearance.BorderSize = 0;
            btnAddNotDisturbByNumberPhone.FlatStyle = FlatStyle.Flat;
            btnAddNotDisturbByNumberPhone.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNotDisturbByNumberPhone.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddNotDisturbByNumberPhone.Image = (Image)resources.GetObject("btnAddNotDisturbByNumberPhone.Image");
            btnAddNotDisturbByNumberPhone.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNotDisturbByNumberPhone.Location = new Point(551, 123);
            btnAddNotDisturbByNumberPhone.Name = "btnAddNotDisturbByNumberPhone";
            btnAddNotDisturbByNumberPhone.Size = new Size(248, 33);
            btnAddNotDisturbByNumberPhone.TabIndex = 27;
            btnAddNotDisturbByNumberPhone.Text = "     Добавить по номеру тел.";
            btnAddNotDisturbByNumberPhone.UseVisualStyleBackColor = false;
            btnAddNotDisturbByNumberPhone.Click += btnAddNotDisturbByNumberPhone_Click;
            // 
            // btnAddNotDisturbByAddress
            // 
            btnAddNotDisturbByAddress.BackColor = Color.White;
            btnAddNotDisturbByAddress.FlatAppearance.BorderSize = 0;
            btnAddNotDisturbByAddress.FlatStyle = FlatStyle.Flat;
            btnAddNotDisturbByAddress.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNotDisturbByAddress.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddNotDisturbByAddress.Image = (Image)resources.GetObject("btnAddNotDisturbByAddress.Image");
            btnAddNotDisturbByAddress.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNotDisturbByAddress.Location = new Point(92, 123);
            btnAddNotDisturbByAddress.Name = "btnAddNotDisturbByAddress";
            btnAddNotDisturbByAddress.Size = new Size(213, 33);
            btnAddNotDisturbByAddress.TabIndex = 26;
            btnAddNotDisturbByAddress.Text = "     Добавить по адресу";
            btnAddNotDisturbByAddress.UseVisualStyleBackColor = false;
            btnAddNotDisturbByAddress.Click += btnAddNotDisturbByAddress_Click;
            // 
            // apartmentControlAddNotDisturb
            // 
            apartmentControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            apartmentControlAddNotDisturb.Location = new Point(431, 68);
            apartmentControlAddNotDisturb.Margin = new Padding(0, 0, 5, 0);
            apartmentControlAddNotDisturb.Name = "apartmentControlAddNotDisturb";
            apartmentControlAddNotDisturb.Size = new Size(97, 26);
            apartmentControlAddNotDisturb.TabIndex = 25;
            // 
            // addressControlAddNotDisturb
            // 
            addressControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            addressControlAddNotDisturb.Location = new Point(22, 68);
            addressControlAddNotDisturb.Margin = new Padding(0, 0, 5, 0);
            addressControlAddNotDisturb.Name = "addressControlAddNotDisturb";
            addressControlAddNotDisturb.Size = new Size(404, 26);
            addressControlAddNotDisturb.TabIndex = 24;
            // 
            // cityControlAddNotDisturb
            // 
            cityControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            cityControlAddNotDisturb.Location = new Point(283, 21);
            cityControlAddNotDisturb.Margin = new Padding(0, 0, 5, 0);
            cityControlAddNotDisturb.Name = "cityControlAddNotDisturb";
            cityControlAddNotDisturb.Size = new Size(245, 26);
            cityControlAddNotDisturb.TabIndex = 23;
            // 
            // countryControlAddNotDisturb
            // 
            countryControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            countryControlAddNotDisturb.Location = new Point(14, 21);
            countryControlAddNotDisturb.Margin = new Padding(0, 0, 5, 0);
            countryControlAddNotDisturb.Name = "countryControlAddNotDisturb";
            countryControlAddNotDisturb.Size = new Size(264, 26);
            countryControlAddNotDisturb.TabIndex = 22;
            // 
            // chkPrivateHouseAddNotDisturb
            // 
            chkPrivateHouseAddNotDisturb.AutoSize = true;
            chkPrivateHouseAddNotDisturb.Enabled = false;
            chkPrivateHouseAddNotDisturb.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkPrivateHouseAddNotDisturb.Location = new Point(103, 97);
            chkPrivateHouseAddNotDisturb.Name = "chkPrivateHouseAddNotDisturb";
            chkPrivateHouseAddNotDisturb.Size = new Size(123, 20);
            chkPrivateHouseAddNotDisturb.TabIndex = 21;
            chkPrivateHouseAddNotDisturb.Text = "Частные дома";
            chkPrivateHouseAddNotDisturb.UseVisualStyleBackColor = true;
            chkPrivateHouseAddNotDisturb.CheckedChanged += chkPrivateHouseAddNotDisturb_CheckedChanged;
            // 
            // addApartmentsTab
            // 
            addApartmentsTab.Controls.Add(btnAddRange);
            addApartmentsTab.Controls.Add(btnEditNumber);
            addApartmentsTab.Controls.Add(btnAddSingle);
            addApartmentsTab.Controls.Add(addressControlAddApartments);
            addApartmentsTab.Controls.Add(cityControlAddApartments);
            addApartmentsTab.Controls.Add(countryControlAddApartments);
            addApartmentsTab.Controls.Add(chkPrivateHouse);
            addApartmentsTab.Controls.Add(btnEditAddressAdd);
            addApartmentsTab.Controls.Add(btnEditCityAdd);
            addApartmentsTab.Controls.Add(btnEditCountryAdd);
            addApartmentsTab.ForeColor = Color.White;
            addApartmentsTab.Image = null;
            addApartmentsTab.ImageSize = new Size(16, 16);
            addApartmentsTab.Location = new Point(1, 31);
            addApartmentsTab.Name = "addApartmentsTab";
            addApartmentsTab.ShowCloseButton = true;
            addApartmentsTab.Size = new Size(822, 191);
            addApartmentsTab.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addApartmentsTab.TabForeColor = Color.White;
            addApartmentsTab.TabIndex = 1;
            addApartmentsTab.Text = "Добавить квартиры";
            addApartmentsTab.ThemesEnabled = false;
            // 
            // btnAddRange
            // 
            btnAddRange.BackColor = Color.White;
            btnAddRange.FlatAppearance.BorderSize = 0;
            btnAddRange.FlatStyle = FlatStyle.Flat;
            btnAddRange.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRange.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddRange.Image = (Image)resources.GetObject("btnAddRange.Image");
            btnAddRange.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRange.Location = new Point(320, 137);
            btnAddRange.Name = "btnAddRange";
            btnAddRange.Size = new Size(252, 33);
            btnAddRange.TabIndex = 23;
            btnAddRange.Text = "      Добавить список квартир";
            btnAddRange.UseVisualStyleBackColor = false;
            btnAddRange.Click += btnAddRange_Click;
            // 
            // btnEditNumber
            // 
            btnEditNumber.BackColor = Color.White;
            btnEditNumber.FlatAppearance.BorderSize = 0;
            btnEditNumber.FlatStyle = FlatStyle.Flat;
            btnEditNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditNumber.ForeColor = Color.FromArgb(0, 71, 160);
            btnEditNumber.Image = (Image)resources.GetObject("btnEditNumber.Image");
            btnEditNumber.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditNumber.Location = new Point(578, 137);
            btnEditNumber.Name = "btnEditNumber";
            btnEditNumber.Size = new Size(168, 33);
            btnEditNumber.TabIndex = 21;
            btnEditNumber.Text = "     Редактировать";
            btnEditNumber.UseVisualStyleBackColor = false;
            btnEditNumber.Click += btnEditNumber_Click;
            // 
            // btnAddSingle
            // 
            btnAddSingle.BackColor = Color.White;
            btnAddSingle.FlatAppearance.BorderSize = 0;
            btnAddSingle.FlatStyle = FlatStyle.Flat;
            btnAddSingle.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSingle.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddSingle.Image = (Image)resources.GetObject("btnAddSingle.Image");
            btnAddSingle.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSingle.Location = new Point(101, 137);
            btnAddSingle.Name = "btnAddSingle";
            btnAddSingle.Size = new Size(213, 33);
            btnAddSingle.TabIndex = 22;
            btnAddSingle.Text = "     Добавить 1 квартиру";
            btnAddSingle.UseVisualStyleBackColor = false;
            btnAddSingle.Click += btnAddSingle_Click;
            // 
            // addressControlAddApartments
            // 
            addressControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            addressControlAddApartments.Location = new Point(129, 69);
            addressControlAddApartments.Margin = new Padding(0, 0, 5, 0);
            addressControlAddApartments.Name = "addressControlAddApartments";
            addressControlAddApartments.Size = new Size(523, 26);
            addressControlAddApartments.TabIndex = 20;
            // 
            // cityControlAddApartments
            // 
            cityControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            cityControlAddApartments.Location = new Point(410, 22);
            cityControlAddApartments.Margin = new Padding(0, 0, 5, 0);
            cityControlAddApartments.Name = "cityControlAddApartments";
            cityControlAddApartments.Size = new Size(242, 26);
            cityControlAddApartments.TabIndex = 19;
            // 
            // countryControlAddApartments
            // 
            countryControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            countryControlAddApartments.Location = new Point(122, 22);
            countryControlAddApartments.Margin = new Padding(0, 0, 5, 0);
            countryControlAddApartments.Name = "countryControlAddApartments";
            countryControlAddApartments.Size = new Size(237, 26);
            countryControlAddApartments.TabIndex = 18;
            // 
            // chkPrivateHouse
            // 
            chkPrivateHouse.AutoSize = true;
            chkPrivateHouse.Enabled = false;
            chkPrivateHouse.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkPrivateHouse.Location = new Point(211, 98);
            chkPrivateHouse.Name = "chkPrivateHouse";
            chkPrivateHouse.Size = new Size(130, 20);
            chkPrivateHouse.TabIndex = 17;
            chkPrivateHouse.Text = "Частные дома";
            chkPrivateHouse.UseVisualStyleBackColor = true;
            chkPrivateHouse.CheckedChanged += chkPrivateHouse_CheckedChanged;
            // 
            // btnEditAddressAdd
            // 
            btnEditAddressAdd.BackColor = Color.White;
            btnEditAddressAdd.FlatAppearance.BorderSize = 0;
            btnEditAddressAdd.FlatStyle = FlatStyle.Flat;
            btnEditAddressAdd.Image = (Image)resources.GetObject("btnEditAddressAdd.Image");
            btnEditAddressAdd.Location = new Point(660, 65);
            btnEditAddressAdd.Name = "btnEditAddressAdd";
            btnEditAddressAdd.Size = new Size(40, 35);
            btnEditAddressAdd.TabIndex = 16;
            btnEditAddressAdd.UseVisualStyleBackColor = false;
            btnEditAddressAdd.Click += btnEditAddressAdd_Click;
            // 
            // btnEditCityAdd
            // 
            btnEditCityAdd.BackColor = Color.White;
            btnEditCityAdd.FlatAppearance.BorderSize = 0;
            btnEditCityAdd.FlatStyle = FlatStyle.Flat;
            btnEditCityAdd.Image = (Image)resources.GetObject("btnEditCityAdd.Image");
            btnEditCityAdd.Location = new Point(660, 18);
            btnEditCityAdd.Name = "btnEditCityAdd";
            btnEditCityAdd.Size = new Size(40, 35);
            btnEditCityAdd.TabIndex = 15;
            btnEditCityAdd.UseVisualStyleBackColor = false;
            btnEditCityAdd.Click += btnEditCityAdd_Click;
            // 
            // btnEditCountryAdd
            // 
            btnEditCountryAdd.BackColor = Color.White;
            btnEditCountryAdd.FlatAppearance.BorderSize = 0;
            btnEditCountryAdd.FlatStyle = FlatStyle.Flat;
            btnEditCountryAdd.Image = (Image)resources.GetObject("btnEditCountryAdd.Image");
            btnEditCountryAdd.Location = new Point(367, 18);
            btnEditCountryAdd.Name = "btnEditCountryAdd";
            btnEditCountryAdd.Size = new Size(40, 35);
            btnEditCountryAdd.TabIndex = 14;
            btnEditCountryAdd.UseVisualStyleBackColor = false;
            btnEditCountryAdd.Click += btnEditCountryAdd_Click;
            // 
            // gridPhones
            // 
            gridPhones.BackColor = Color.White;
            gridPhones.Dock = DockStyle.Bottom;
            gridPhones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridPhones.ForeColor = Color.FromArgb(0, 71, 160);
            gridPhones.Location = new Point(5, 229);
            gridPhones.Name = "gridPhones";
            gridPhones.Padding = new Padding(0, 5, 0, 0);
            gridPhones.Size = new Size(825, 361);
            gridPhones.TabIndex = 1;
            // 
            // btnEditNotDisturb
            // 
            btnEditNotDisturb.BackColor = Color.White;
            btnEditNotDisturb.FlatAppearance.BorderSize = 0;
            btnEditNotDisturb.FlatStyle = FlatStyle.Flat;
            btnEditNotDisturb.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditNotDisturb.ForeColor = Color.FromArgb(0, 71, 160);
            btnEditNotDisturb.Image = (Image)resources.GetObject("btnEditNotDisturb.Image");
            btnEditNotDisturb.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditNotDisturb.Location = new Point(343, 123);
            btnEditNotDisturb.Name = "btnEditNotDisturb";
            btnEditNotDisturb.Size = new Size(168, 33);
            btnEditNotDisturb.TabIndex = 30;
            btnEditNotDisturb.Text = "     Редактировать";
            btnEditNotDisturb.UseVisualStyleBackColor = false;
            btnEditNotDisturb.Click += btnEditNotDisturb_Click;
            // 
            // AddControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddAdv);
            Controls.Add(gridPhones);
            Name = "AddControl";
            Padding = new Padding(5);
            Size = new Size(835, 595);
            Load += AddControl_Load;
            ((System.ComponentModel.ISupportInitialize)tabControlAddAdv).EndInit();
            tabControlAddAdv.ResumeLayout(false);
            addNotDisturbTab.ResumeLayout(false);
            addNotDisturbTab.PerformLayout();
            addApartmentsTab.ResumeLayout(false);
            addApartmentsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAddAdv;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addApartmentsTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addNotDisturbTab;
        private Button btnEditCountryAdd;
        private Button btnEditAddressAdd;
        private Button btnEditCityAdd;
        private CheckBox chkPrivateHouse;
        private UserControls.CountryControl countryControlAddApartments;
        private UserControls.CityControl cityControlAddApartments;
        private UserControls.AddressControl addressControlAddApartments;
        private UserControls.GridControl gridPhones;
        private Button btnAddRange;
        private Button btnEditNumber;
        private Button btnAddSingle;
        private UserControls.AddressControl addressControlAddNotDisturb;
        private UserControls.CityControl cityControlAddNotDisturb;
        private UserControls.CountryControl countryControlAddNotDisturb;
        private CheckBox chkPrivateHouseAddNotDisturb;
        private UserControls.ApartmentControl apartmentControlAddNotDisturb;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumberPhone;
        private Button btnAddNotDisturbByNumberPhone;
        private Button btnAddNotDisturbByAddress;
        private MaskedTextBox txtNumberPhone;
        private Button btnEditNotDisturb;
    }
}
