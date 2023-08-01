using Microsoft.EntityFrameworkCore;
using PhoneBook.Properties;
using PhoneBook.Types;

namespace PhoneBook.UserForms
{
    public partial class EditAddress : Form
    {
        private AddressEdit? currentAddress => gridAddresses.DataGrid.SelectedItem as AddressEdit;
        public City City { get; set; } = new City();

        private bool _privateHouse = false;

        const int errorPadding = 3;

        public EditAddress(bool privateHouse)
        {
            InitializeComponent();

            _privateHouse = privateHouse;

            houseControl.Enabled = !_privateHouse;

            gridAddresses.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            gridAddresses.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            gridAddresses.DataGrid.AllowSorting = false;

            UpdateData(new List<AddressEdit>() { new AddressEdit() });

            typeStreetControl.TypeStreetTextBox.Leave += TypeStreetTextBox_Leave;
        }

        /// <summary>
        /// Загрузка и обновление данных
        /// </summary>
        /// <param name="addresses"></param>
        private void UpdateData(List<AddressEdit> addresses)
        {
            gridAddresses.DataGrid.DataSource = addresses;
            gridAddresses.DataGrid.Columns["Id"].Visible = false;
            gridAddresses.DataGrid.Columns["Locality"].Width = 150;
            gridAddresses.DataGrid.Columns["TypeStreetId"].Visible = false;
            gridAddresses.DataGrid.Columns["TypeStreetName"].Width = 100;
            gridAddresses.DataGrid.Columns["House"].Visible = !_privateHouse;
            gridAddresses.DataGrid.Columns["House"].Width = 90;
            gridAddresses.DataGrid.Columns["PrivateHouse"].Visible = false;
            gridAddresses.DataGrid.Columns["StreetName"].AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;

            localityControl.LoadLocality(addresses);

            typeStreetControl.LoadTypeStreet();

            streetNameControl.LoadStreetName(addresses);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EditAddress_Load(object sender, EventArgs e)
        {
            LoadDataAddress();
            labelHeader.Text = labelHeader.Text.Replace("n", $"{City.CityName} ({City.CityCode})");
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadDataAddress()
        {
            using (var db = new ApplicationContext())
            {
                var addresses = db.City
                    .Include(c => c.Addresses)?
                    .ThenInclude(t => t.TypeStreet)?
                    .Where(c => c.Id == City.Id)?
                    .FirstOrDefault()?
                    .Addresses
                    .Select(a => new AddressEdit()
                    {
                        Id = a.Id,
                        Locality = a.Locality,
                        TypeStreetId = a.TypeStreetId,
                        TypeStreetName = a.TypeStreet?.TypeName,
                        StreetName = a.StreetName,
                        House = a.House,
                        PrivateHouse = a.PrivateHouse
                    })
                    .Where(a => a.PrivateHouse == _privateHouse)
                    .ToList();

                UpdateData(addresses ?? new List<AddressEdit>() { new AddressEdit() });
            }
        }

        /// <summary>
        /// Изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (btnEdit.Text == "Изменить")
            {
                if (currentAddress != null)
                {
                    if (!string.IsNullOrEmpty(currentAddress.Locality))
                    {
                        localityControl.SetLocalityInTextBox(currentAddress.Locality);
                    }

                    if (!string.IsNullOrEmpty(currentAddress.TypeStreetName))
                        typeStreetControl.SetTypeStreetInTextBox(currentAddress.TypeStreetName);

                    if (!string.IsNullOrEmpty(currentAddress.StreetName))
                        streetNameControl.SetStreetNameInTextBox(currentAddress.StreetName);

                    if (!string.IsNullOrEmpty(currentAddress.House))
                        houseControl.SetHouseInTextBox(currentAddress.House);

                    btnAdd.Image = Resources.save;
                    btnAdd.Text = "Сохранить";
                    btnEdit.Image = Resources.cancel;
                    btnEdit.Text = "Отменить";
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Выберите в таблице адрес для редактирования.", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (btnEdit.Text == "Отменить")
            {
                ClearTextBox();
                btnAdd.Text = "Добавить";
                btnAdd.Image = Resources.add;
                btnEdit.Text = "Изменить";
                btnEdit.Image = Resources.edit;
                btnDelete.Enabled = true;
            }
        }

        /// <summary>
        /// Добавление или Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidation())
                return;

            if (AddressIsExist())
            {
                MessageBox.Show("Данный адрес уже существует!", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAdd.Text == "Сохранить")
            {
                using (var db = new ApplicationContext())
                {
                    if (currentAddress != null)
                    {
                        var tempAddress = new Address();
                        tempAddress.Id = currentAddress.Id;
                        tempAddress.Locality = localityControl.LocalityTextBox.Text.Trim();
                        tempAddress.TypeStreetId = typeStreetControl.GetTypeStreetIdFromAutoComplete();
                        tempAddress.StreetName = streetNameControl.StreetNameTextBox.Text.Trim();
                        tempAddress.House = houseControl.HouseTextBox.Text.Trim();
                        tempAddress.PrivateHouse = _privateHouse;

                        db.Address.Update(tempAddress);
                        db.SaveChanges();
                    }
                }
                ClearTextBox();
                LoadDataAddress();
                btnAdd.Text = "Добавить";
                btnAdd.Image = Resources.add;
                btnEdit.Text = "Изменить";
                btnEdit.Image = Resources.edit;
                btnDelete.Enabled = true;

            }
            else if (btnAdd.Text == "Добавить")
            {
                using (var db = new ApplicationContext())
                {
                    var address = new Address()
                    {
                        CityId = City.Id,
                        Locality = localityControl.LocalityTextBox.Text.Trim(),
                        TypeStreetId = typeStreetControl.GetTypeStreetIdFromAutoComplete(),
                        StreetName = streetNameControl.StreetNameTextBox.Text.Trim(),
                        House = houseControl.HouseTextBox.Text.Trim(),
                        PrivateHouse = _privateHouse
                    };
                    db.Address.Add(address);
                    db.SaveChanges();
                }
                ClearTextBox();
                LoadDataAddress();
            }
        }

        private bool IsValidation()
        {
            var result = true;
            errorValidating.Clear();

            if (string.IsNullOrEmpty(houseControl.HouseTextBox.Text) && !_privateHouse)
            {
                errorValidating.SetError(houseControl.HouseTextBox, "Укажите номер дома.");
                errorValidating.SetIconPadding(houseControl.HouseTextBox, errorPadding);
                result = false;
                houseControl.HouseTextBox.Focus();
            }


            if (string.IsNullOrEmpty(streetNameControl.StreetNameTextBox.Text))
            {
                errorValidating.SetError(streetNameControl.StreetNameTextBox, "Выберите наименование улицы или введите новое.");
                errorValidating.SetIconPadding(streetNameControl.StreetNameTextBox, errorPadding);
                result = false;
                streetNameControl.StreetNameTextBox.Focus();
            }

            if (string.IsNullOrEmpty(typeStreetControl.TypeStreetTextBox.Text))
            {
                errorValidating.SetError(typeStreetControl.TypeStreetTextBox, "Выберите тип улицы или введите новый.");
                errorValidating.SetIconPadding(typeStreetControl.TypeStreetTextBox, errorPadding);
                result = false;
                typeStreetControl.TypeStreetTextBox.Focus();
            }

            return result;
        }

        /// <summary>
        /// Проверка существует ли данный адрес
        /// </summary>
        /// <returns></returns>
        private bool AddressIsExist()
        {
            var addresses = gridAddresses.DataGrid.DataSource as List<AddressEdit>;
            var find = addresses?
                .Where(a => a.Locality == localityControl.LocalityTextBox.Text.Trim() && a.TypeStreetName == typeStreetControl.TypeStreetTextBox.Text.Trim()
                    && a.StreetName == streetNameControl.StreetNameTextBox.Text.Trim() && a.House == houseControl.HouseTextBox.Text.Trim()).ToList() ?? new List<AddressEdit>();
            return find.Count > 0;
        }

        /// <summary>
        /// Очистка текстовых полей
        /// </summary>
        private void ClearTextBox()
        {
            localityControl.LocalityTextBox.Text = "";
            typeStreetControl.TypeStreetTextBox.Text = "";
            streetNameControl.StreetNameTextBox.Text = "";
            houseControl.HouseTextBox.Text = "";
        }

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (currentAddress != null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите удалить запись:\n " +
                    $"{(string.IsNullOrEmpty(currentAddress.Locality) ? "" : currentAddress.Locality + ", ")}{currentAddress.TypeStreetName} {currentAddress.StreetName}, {currentAddress.House}", "Уведомление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return;
                using (var db = new ApplicationContext())
                {
                    var tempAddress = db.Address.Where(a => a.Id == currentAddress.Id).FirstOrDefault();
                    if (tempAddress != null)
                        db.Address.Remove(tempAddress);
                    db.SaveChanges();
                }
                LoadDataAddress();
            }
            else
            {
                MessageBox.Show("Выберите в таблице адрес для удаления.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TypeStreetTextBox_Leave(object? sender, EventArgs e)
        {
            var typeStreet = typeStreetControl.TypeStreetTextBox.Text;
            if (!string.IsNullOrEmpty(typeStreet) && typeStreetControl.GetAutoCompleteTypeStreet() == null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите добавить тип улицы:\n " +
                       $"{typeStreet.ToLower().Trim()}", "Уведомление",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No)
                {
                    typeStreetControl.TypeStreetTextBox.Text = "";
                    return;
                }

                using (var db = new ApplicationContext())
                {
                    db.TypeStreet.Add(new TypeStreet() { TypeName = typeStreet.Trim() });
                    db.SaveChanges();
                }
                typeStreetControl.LoadTypeStreet();
                typeStreetControl.SelectTypeStreet(typeStreet.ToLower().Trim());
            }
        }
    }
}
