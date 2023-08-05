using PhoneBook.Forms;
using PhoneBook.Properties;
using PhoneBook.Types;
using PhoneBook.UserForms;
using Syncfusion.WinForms.DataGrid;

namespace PhoneBook.Controls
{
    public partial class AddControl : UserControl
    {
        private string _maskNumber = "";
        private NumberPhoneView? currentNumberPhone => gridPhones.DataGrid.SelectedItem as NumberPhoneView;

        public AddControl()
        {
            InitializeComponent();

            countryControlAddApartments.CountryChanged += CountryControlAddApartments_CountryChanged;
            cityControlAddApartments.CityChanged += CityControlAddApartments_CityChanged;
            addressControlAddApartments.AddressChanged += AddressControlAddApartments_AddressChanged;

            gridPhones.DataGrid.ShowRowHeader = true;
            gridPhones.DataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
            gridPhones.DataGrid.DrawCell += DataGrid_DrawCell;
            gridPhones.DataGrid.CellClick += DataGrid_CellClick;
        }

        private void AddControl_Load(object sender, EventArgs e)
        {
            tabControlAddAdv_SelectedIndexChanged(tabControlAddAdv, new EventArgs());
        }

        private void UpdateData(List<NumberPhoneView> numberPhones)
        {
            gridPhones.DataGrid.DataSource = numberPhones;
            gridPhones.DataGrid.Columns["Locality"].Width = 150;
            gridPhones.DataGrid.Columns["TypeName"].Width = 90;
            gridPhones.DataGrid.Columns["StreetName"].AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            gridPhones.DataGrid.Columns["House"].Width = 50;
            gridPhones.DataGrid.Columns["House"].Visible = !chkPrivateHouse.Checked;
            gridPhones.DataGrid.Columns["Apartment"].Width = 70;
            gridPhones.DataGrid.Columns["Number"].Width = 180;
        }

        private void CountryControlAddApartments_CountryChanged(int countryId)
        {
            ClearDataOnAddApartmentsTab("CountryControl");
            cityControlAddApartments.LoadCity(countryId);
        }

        private void CityControlAddApartments_CityChanged(int cityId)
        {
            ClearDataOnAddApartmentsTab("CityControl");

            _maskNumber = City.GetMaskNumberbyCityId(cityId);

            addressControlAddApartments.LoadAddress(cityId, chkPrivateHouse.Checked);

            chkPrivateHouse.Enabled = true;
        }

        private void AddressControlAddApartments_AddressChanged(int addressId)
        {
            using (var db = new ApplicationContext())
            {
                var numberPhones = db.NumberPhoneView
                    .Where(n => n.AddressId == addressId)
                    .ToList();
                numberPhones.Sort();
                UpdateData(numberPhones);
            }
        }

        private void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Number" && !string.IsNullOrEmpty(_maskNumber))
            {
                e.Column = new GridMaskColumn() { MappingName = "Number", HeaderText = "Номер телефона", Mask = _maskNumber };
            }
        }

        private void DataGrid_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (gridPhones.DataGrid.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.Handled = true;
                    Rectangle rect = new Rectangle(e.Bounds.X + 7, e.Bounds.Y + 7, e.Bounds.Width - 14, e.Bounds.Height - 12);
                    e.Graphics.FillRectangle(new SolidBrush(gridPhones.DataGrid.Style.RowHeaderStyle.BackColor),
                        new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2));
                    e.Graphics.DrawImage(new Bitmap(Resources.remove), rect);
                }
            }
        }

        private void DataGrid_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataColumn.ColumnIndex == 0)
            {
                var res = MessageBox.Show("Вы действительно хотите удалить данную запись?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    int deletingRowIndex = gridPhones.DataGrid.TableControl.ResolveToRecordIndex(e.DataRow.RowIndex);
                    using (var db = new ApplicationContext())
                    {
                        var deleteRow = gridPhones.DataGrid.View.Records[deletingRowIndex].Data as NumberPhoneView;

                        if (deleteRow == null) return;

                        var deleteRecord = db.NumberPhone.Where(n => n.Id == deleteRow.Id).FirstOrDefault();
                        if (deleteRecord != null)
                        {
                            db.NumberPhone.Remove(deleteRecord);
                            db.SaveChanges();

                            var numberPhones = db.NumberPhoneView
                                .Where(n => n.AddressId == addressControlAddApartments.GetAddressId())
                                .ToList();
                            UpdateData(numberPhones);
                        }
                    }
                    e.Cancel = true;
                    var recordsCount = gridPhones.DataGrid.View.Records.Count;
                    if (recordsCount != 0)
                    {
                        gridPhones.DataGrid.SelectedItem = gridPhones.DataGrid.View.Records[0];

                    }
                }
            }
        }

        private void tabControlAddAdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAddAdv.SelectedTab.Name == "addApartmentsTab")
            {
                countryControlAddApartments.LoadCountry();
            }
        }

        private void ClearDataOnAddApartmentsTab(string nameControl)
        {
            switch (nameControl)
            {
                case "CountryControl":
                    cityControlAddApartments.ClearDataCity();
                    chkPrivateHouse.Enabled = false;
                    goto case "CityControl";
                case "CityControl":
                    addressControlAddApartments.ClearDataAddress();
                    goto case "AddressControl";
                case "AddressControl":
                    UpdateData(new List<NumberPhoneView>());
                    break;
            }
        }

        private void btnEditCountryAdd_Click(object sender, EventArgs e)
        {
            var editCountryForm = new EditCountry();
            if (editCountryForm.ShowDialog() == DialogResult.OK)
            {
                countryControlAddApartments.ClearDataCountry();
                ClearDataOnAddApartmentsTab("CountryControl");
                countryControlAddApartments.LoadCountry();
            }
        }

        private void btnEditCityAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countryControlAddApartments.GetTextCountry()))
            {
                MessageBox.Show("Укажите Страну.", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var editCityForm = new EditCity();
                var countryId = countryControlAddApartments.GetCountryId();
                using (var db = new ApplicationContext())
                {
                    editCityForm.Country = db.Country.Where(c => c.Id == countryId).FirstOrDefault() ?? new Country();
                }
                if (editCityForm.ShowDialog() == DialogResult.OK)
                {
                    cityControlAddApartments.ClearDataCity();
                    ClearDataOnAddApartmentsTab("CityControl");
                    cityControlAddApartments.LoadCity(countryId);
                }
            }
        }

        private void btnEditAddressAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countryControlAddApartments.GetTextCountry()) || string.IsNullOrEmpty(cityControlAddApartments.GetTextCity()))
            {
                MessageBox.Show("Укажите Страну и Город.", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var editAddressForm = new EditAddress(chkPrivateHouse.Checked);
                using (var db = new ApplicationContext())
                {
                    var cityId = cityControlAddApartments.GetCityId();
                    editAddressForm.City = db.City.Where(c => c.Id == Convert.ToInt32(cityId)).FirstOrDefault() ?? new City();
                }
                if (editAddressForm.ShowDialog() == DialogResult.OK)
                {
                    addressControlAddApartments.ClearDataAddress();
                    cityControlAddApartments.SelectCity(cityControlAddApartments.GetCityId());
                }
            }
        }

        private void chkPrivateHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cityControlAddApartments.GetTextCity()))
            {
                addressControlAddApartments.ClearDataAddress();
                cityControlAddApartments.SelectCity(cityControlAddApartments.GetCityId());
            }
        }

        private void btnAddSingle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countryControlAddApartments.GetTextCountry()) ||
                string.IsNullOrEmpty(cityControlAddApartments.GetTextCity()) ||
                string.IsNullOrEmpty(addressControlAddApartments.GetTextAddress()))
            {
                MessageBox.Show("Укажите Страну, Город и Адрес.", "Уведомление",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var addSingleNumber = new AddSingleNumber(addressControlAddApartments.GetTextAddress(), _maskNumber);
                if (addSingleNumber.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new ApplicationContext())
                    {
                        var addressId = addressControlAddApartments.GetAddressId();
                        var singleNumber = addSingleNumber.NumberPhone;
                        singleNumber.AddressId = Convert.ToInt32(addressId);
                        db.NumberPhone.Add(singleNumber);
                        db.SaveChanges();

                        var numberPhones = db.NumberPhoneView
                            .Where(n => n.AddressId == Convert.ToInt32(addressId))
                            .ToList();
                        UpdateData(numberPhones);
                    }
                }
            }
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countryControlAddApartments.GetTextCountry()) ||
                string.IsNullOrEmpty(cityControlAddApartments.GetTextCity()) ||
                string.IsNullOrEmpty(addressControlAddApartments.GetTextAddress()))
            {
                MessageBox.Show("Укажите Страну, Город и Адрес.", "Уведомление",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var addRangeNumber = new AddRangeNumber(addressControlAddApartments.GetTextAddress(), _maskNumber);
                addRangeNumber.AddressId = addressControlAddApartments.GetAddressId();

                if (addRangeNumber.ShowDialog() == DialogResult.OK)
                {
                    var listNumbers = addRangeNumber.NumberPhones;

                    using (var db = new ApplicationContext())
                    {
                        if (listNumbers.Count != 0)
                        {
                            db.NumberPhone.AddRange(listNumbers);
                            db.SaveChanges();
                        }

                        var numberPhones = db.NumberPhoneView
                            .Where(n => n.AddressId == addressControlAddApartments.GetAddressId())
                            .ToList();
                        numberPhones.Sort();
                        UpdateData(numberPhones);
                    }
                }
            }
        }

        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            if (currentNumberPhone != null)
            {
                var editSingleNumber = new AddSingleNumber(addressControlAddApartments.GetTextAddress(), _maskNumber);
                using (var db = new ApplicationContext())
                {
                    var numberPhone = db.NumberPhone.Where(n => n.Id == currentNumberPhone.Id).FirstOrDefault();
                    if (numberPhone != null)
                        editSingleNumber.NumberPhone = numberPhone;
                }
                if (editSingleNumber.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new ApplicationContext())
                    {
                        var singleNumber = editSingleNumber.NumberPhone;
                        db.NumberPhone.Update(singleNumber);
                        db.SaveChanges();

                        var numberPhones = db.NumberPhoneView
                            .Where(n => n.AddressId == singleNumber.AddressId)
                            .ToList();
                        UpdateData(numberPhones);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования.", "Уведомление",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
