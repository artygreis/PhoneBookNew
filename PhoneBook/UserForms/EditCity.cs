using PhoneBook.Properties;
using PhoneBook.Types;
using System.Text.RegularExpressions;

namespace PhoneBook.Forms
{
    public partial class EditCity : Form
    {
        private City? currentCity => gridCities.DataGrid.SelectedItem as City;
        public Country Country { get; set; } = new Country();
        public EditCity()
        {
            InitializeComponent();
            gridCities.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            gridCities.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            gridCities.DataGrid.HeaderRowHeight = 40;
            gridCities.DataGrid.AllowSorting = false;

            UpdateData(new List<City>() { new City() });
        }

        private void UpdateData(List<City> cities)
        {
            gridCities.DataGrid.DataSource = cities;
            gridCities.DataGrid.Columns["Id"].Visible = false;
            gridCities.DataGrid.Columns["CityName"].AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            gridCities.DataGrid.Columns["CityCode"].Width = 121;
            gridCities.DataGrid.Columns["MaskNumber"].Width = 161;
            gridCities.DataGrid.Columns["CountryId"].Visible = false;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EditCity_Load(object sender, System.EventArgs e)
        {
            lblCountry.Text = $"{Country.CountryName} ({Country.CountryCode})";
            LoadDataCity();
        }
        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadDataCity()
        {
            using (var db = new ApplicationContext())
            {
                var cities = db.City.Where(c => c.CountryId == Country.Id).ToList();
                UpdateData(cities);
            }
        }
        private bool IsValidation()
        {
            var result = true;
            errorValidating.Clear();

            if (txtCityCode.Text.StartsWith('0'))
            {
                errorValidating.SetError(txtCityCode, "Код города должен быть в международном формате и не начинаться с 0.");
                errorValidating.SetIconPadding(txtCityCode, errorPadding);
                result = false;
                txtCityCode.Focus();
            }

            if (string.IsNullOrEmpty(txtCityCode.Text.Replace(" ", "")))
            {
                errorValidating.SetError(txtCityCode, "Введите код города.");
                errorValidating.SetIconPadding(txtCityCode, errorPadding);
                result = false;
                txtCityCode.Focus();
            }

            if (string.IsNullOrEmpty(txtCityName.Text))
            {
                errorValidating.SetError(txtCityName, "Введите нименование города.");
                errorValidating.SetIconPadding(txtCityName, errorPadding);
                result = false;
                txtCityName.Focus();
            }

            return result;
        }
        /// <summary>
        /// Изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            errorValidating.Clear();
            if (btnEdit.Text == "Изменить")
            {
                if (currentCity != null)
                {
                    txtCityName.Text = currentCity.CityName;
                    txtCityCode.Text = currentCity.CityCode;
                    txtFormatNumber.Text = currentCity.MaskNumber;


                    btnAdd.Image = Resources.save;
                    btnAdd.Text = "Сохранить";
                    btnEdit.Image = Resources.cancel;
                    btnEdit.Text = "Отменить";
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Выберите в таблице город для редактирования.", "Уведомление",
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
        const int errorPadding = 4;
        /// <summary>
        /// Добавление или Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (!IsValidation())
                return;
            if (ValidateMaskNumber())
            {
                errorValidating.SetError(txtFormatNumber, "Проверьте количество символов маркера \"#\".");
                errorValidating.SetIconPadding(txtFormatNumber, errorPadding);
                return;
            }
            if (btnAdd.Text == "Сохранить")
            {
                using (var db = new ApplicationContext())
                {
                    if (currentCity != null)
                    {
                        currentCity.CityName = txtCityName.Text.Trim();
                        currentCity.CityCode = txtCityCode.Text.Replace(" ", "");
                        currentCity.MaskNumber = txtFormatNumber.Text.Trim();

                        db.City.Update(currentCity);
                        db.SaveChanges();
                    }
                }
                ClearTextBox();
                LoadDataCity();
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
                    db.City.Add(new City()
                    {
                        CityName = txtCityName.Text.Trim(),
                        CityCode = txtCityCode.Text.Replace(" ", ""),
                        MaskNumber = txtFormatNumber.Text.Trim(),
                        CountryId = Country.Id
                    });

                    db.SaveChanges();
                }
                ClearTextBox();
                LoadDataCity();
            }
            //else
            //{
            //    ;
            //}
        }
        /// <summary>
        /// Очистка текстовых полей
        /// </summary>
        private void ClearTextBox()
        {
            txtCityName.Text = "";
            txtCityCode.Text = "";
            txtFormatNumber.Mask = null;
            txtFormatNumber.Text = "";
        }
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (currentCity != null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите удалить запись:\n " +
                    $"{currentCity.CityName} {currentCity.CityCode} {currentCity.MaskNumber}", "Уведомление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return;
                using (var db = new ApplicationContext())
                {
                    db.City.Remove(currentCity);

                    db.SaveChanges();
                }
                LoadDataCity();
            }
            else
            {
                MessageBox.Show("Выберите в таблице город для удаления.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Формирование формата номера
        /// </summary>
        /// <param name="countDigits"></param>
        /// <returns></returns>
        private string GetMaskNumber(int countDigits)
        {
            if (countDigits >= 5)
            {
                return $"{new string('#', countDigits - 4)}-##-##";
            }
            else
            {
                return new string('#', countDigits);
            }
        }
        /// <summary>
        /// Проверка итогового формата номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedEditBoxFormatNumber_Validated(object sender, EventArgs e)
        {
            var regex = new Regex(@"[^#-]");
            if (regex.IsMatch(txtFormatNumber.Text))
            {
                errorValidating.SetError(txtFormatNumber, "В качестве маркера нужно использовать \"#\", а в качестве разделителя \"-\".");
                errorValidating.SetIconPadding(txtFormatNumber, errorPadding);

                return;
            }
            errorValidating.Clear();
        }
        /// <summary>
        /// Проверка соответсвие формата номера
        /// </summary>
        /// <returns></returns>
        private bool ValidateMaskNumber()
        {
            var regex = new Regex(@"[^#]");
            var tempCountNumber = regex.Replace(txtFormatNumber.Text.Replace(" ", ""), "").Length;
            var tempCountNumberRight = Country.CountDigits - txtCityCode.Text.Replace(" ", "").Length - Country.CountryCode?.Replace("+", "").Length;
            return tempCountNumberRight != tempCountNumber;
        }

        /// <summary>
        /// Заполнение информации о формате номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFormatNumber_Enter(object sender, EventArgs e)
        {
            if (!IsValidation())
                return;

            if (!ValidateMaskNumber())
            {
                var tempText = txtFormatNumber.Text.Replace(" ", "");
                txtFormatNumber.Text = tempText;
                return;
            }

            txtFormatNumber.Text = GetMaskNumber(Country.CountDigits -
                txtCityCode.Text.Replace(" ", "").Length - Country.CountryCode?.Replace("+", "").Length ?? 0);
        }
    }
}
