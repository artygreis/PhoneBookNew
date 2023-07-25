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
            this.tabControlAddAdv = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.addApartmentsTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.addressControlAddApartments = new PhoneBook.UserControls.AddressControl();
            this.cityControlAddApartments = new PhoneBook.UserControls.CityControl();
            this.countryControlAddApartments = new PhoneBook.UserControls.CountryControl();
            this.chkPrivateHouse = new System.Windows.Forms.CheckBox();
            this.btnEditAddressAdd = new System.Windows.Forms.Button();
            this.btnEditCityAdd = new System.Windows.Forms.Button();
            this.btnEditCountryAdd = new System.Windows.Forms.Button();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAddAdv)).BeginInit();
            this.tabControlAddAdv.SuspendLayout();
            this.addApartmentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAddAdv
            // 
            this.tabControlAddAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.tabControlAddAdv.BeforeTouchSize = new System.Drawing.Size(825, 250);
            this.tabControlAddAdv.Controls.Add(this.addApartmentsTab);
            this.tabControlAddAdv.Controls.Add(this.tabPageAdv2);
            this.tabControlAddAdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAddAdv.Location = new System.Drawing.Point(5, 5);
            this.tabControlAddAdv.Name = "tabControlAddAdv";
            this.tabControlAddAdv.Size = new System.Drawing.Size(825, 250);
            this.tabControlAddAdv.TabIndex = 0;
            this.tabControlAddAdv.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.tabControlAddAdv.SelectedIndexChanged += new System.EventHandler(this.tabControlAddAdv_SelectedIndexChanged);
            // 
            // addApartmentsTab
            // 
            this.addApartmentsTab.Controls.Add(this.addressControlAddApartments);
            this.addApartmentsTab.Controls.Add(this.cityControlAddApartments);
            this.addApartmentsTab.Controls.Add(this.countryControlAddApartments);
            this.addApartmentsTab.Controls.Add(this.chkPrivateHouse);
            this.addApartmentsTab.Controls.Add(this.btnEditAddressAdd);
            this.addApartmentsTab.Controls.Add(this.btnEditCityAdd);
            this.addApartmentsTab.Controls.Add(this.btnEditCountryAdd);
            this.addApartmentsTab.ForeColor = System.Drawing.Color.White;
            this.addApartmentsTab.Image = null;
            this.addApartmentsTab.ImageSize = new System.Drawing.Size(16, 16);
            this.addApartmentsTab.Location = new System.Drawing.Point(1, 31);
            this.addApartmentsTab.Name = "addApartmentsTab";
            this.addApartmentsTab.ShowCloseButton = true;
            this.addApartmentsTab.Size = new System.Drawing.Size(822, 217);
            this.addApartmentsTab.TabFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addApartmentsTab.TabForeColor = System.Drawing.Color.White;
            this.addApartmentsTab.TabIndex = 1;
            this.addApartmentsTab.Text = "Добавить квартиры";
            this.addApartmentsTab.ThemesEnabled = false;
            // 
            // addressControlAddApartments
            // 
            this.addressControlAddApartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.addressControlAddApartments.Location = new System.Drawing.Point(10, 69);
            this.addressControlAddApartments.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.addressControlAddApartments.Name = "addressControlAddApartments";
            this.addressControlAddApartments.Size = new System.Drawing.Size(523, 26);
            this.addressControlAddApartments.TabIndex = 20;
            // 
            // cityControlAddApartments
            // 
            this.cityControlAddApartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.cityControlAddApartments.Location = new System.Drawing.Point(291, 22);
            this.cityControlAddApartments.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cityControlAddApartments.Name = "cityControlAddApartments";
            this.cityControlAddApartments.Size = new System.Drawing.Size(242, 26);
            this.cityControlAddApartments.TabIndex = 19;
            // 
            // countryControlAddApartments
            // 
            this.countryControlAddApartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.countryControlAddApartments.Location = new System.Drawing.Point(3, 22);
            this.countryControlAddApartments.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.countryControlAddApartments.Name = "countryControlAddApartments";
            this.countryControlAddApartments.Size = new System.Drawing.Size(237, 26);
            this.countryControlAddApartments.TabIndex = 18;
            // 
            // chkPrivateHouse
            // 
            this.chkPrivateHouse.AutoSize = true;
            this.chkPrivateHouse.Enabled = false;
            this.chkPrivateHouse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPrivateHouse.Location = new System.Drawing.Point(92, 111);
            this.chkPrivateHouse.Name = "chkPrivateHouse";
            this.chkPrivateHouse.Size = new System.Drawing.Size(123, 20);
            this.chkPrivateHouse.TabIndex = 17;
            this.chkPrivateHouse.Text = "Частные дома";
            this.chkPrivateHouse.UseVisualStyleBackColor = true;
            // 
            // btnEditAddressAdd
            // 
            this.btnEditAddressAdd.BackColor = System.Drawing.Color.White;
            this.btnEditAddressAdd.FlatAppearance.BorderSize = 0;
            this.btnEditAddressAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAddressAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAddressAdd.Image")));
            this.btnEditAddressAdd.Location = new System.Drawing.Point(541, 65);
            this.btnEditAddressAdd.Name = "btnEditAddressAdd";
            this.btnEditAddressAdd.Size = new System.Drawing.Size(40, 35);
            this.btnEditAddressAdd.TabIndex = 16;
            this.btnEditAddressAdd.UseVisualStyleBackColor = false;
            // 
            // btnEditCityAdd
            // 
            this.btnEditCityAdd.BackColor = System.Drawing.Color.White;
            this.btnEditCityAdd.FlatAppearance.BorderSize = 0;
            this.btnEditCityAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCityAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCityAdd.Image")));
            this.btnEditCityAdd.Location = new System.Drawing.Point(541, 18);
            this.btnEditCityAdd.Name = "btnEditCityAdd";
            this.btnEditCityAdd.Size = new System.Drawing.Size(40, 35);
            this.btnEditCityAdd.TabIndex = 15;
            this.btnEditCityAdd.UseVisualStyleBackColor = false;
            // 
            // btnEditCountryAdd
            // 
            this.btnEditCountryAdd.BackColor = System.Drawing.Color.White;
            this.btnEditCountryAdd.FlatAppearance.BorderSize = 0;
            this.btnEditCountryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCountryAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCountryAdd.Image")));
            this.btnEditCountryAdd.Location = new System.Drawing.Point(248, 18);
            this.btnEditCountryAdd.Name = "btnEditCountryAdd";
            this.btnEditCountryAdd.Size = new System.Drawing.Size(40, 35);
            this.btnEditCountryAdd.TabIndex = 14;
            this.btnEditCountryAdd.UseVisualStyleBackColor = false;
            this.btnEditCountryAdd.Click += new System.EventHandler(this.btnEditCountryAdd_Click);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 31);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(822, 217);
            this.tabPageAdv2.TabFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageAdv2.TabForeColor = System.Drawing.Color.White;
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // AddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAddAdv);
            this.Name = "AddControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(835, 595);
            this.Load += new System.EventHandler(this.AddControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAddAdv)).EndInit();
            this.tabControlAddAdv.ResumeLayout(false);
            this.addApartmentsTab.ResumeLayout(false);
            this.addApartmentsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAddAdv;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addApartmentsTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Button btnEditCountryAdd;
        private Button btnEditAddressAdd;
        private Button btnEditCityAdd;
        private CheckBox chkPrivateHouse;
        private UserControls.CountryControl countryControlAddApartments;
        private UserControls.CityControl cityControlAddApartments;
        private UserControls.AddressControl addressControlAddApartments;
    }
}
