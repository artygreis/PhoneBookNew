using PhoneBook.Properties;
using PhoneBook.Types;
using System.Text.RegularExpressions;

namespace PhoneBook.Forms
{
    public partial class EditCountry : Form
    {
        Regex regex = new Regex(@"[^0-9]");
        const int errorPadding = 4;
        private Country? currentCountry => GridCountries.DataGrid.SelectedItem as Country;
        public EditCountry()
        {
            InitializeComponent();
            GridCountries.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            GridCountries.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            GridCountries.DataGrid.HeaderRowHeight = 40;
            GridCountries.DataGrid.AllowSorting = false;

            UpdateData(new List<Country>() { new Country() });
        }

        private bool IsValidation()
        {
            var result = true;
            errorValidating.Clear();
            if (string.IsNullOrEmpty(txtCountDigits.Text))
            {
                errorValidating.SetError(txtCountDigits, "Введите количество цифр в номере с учетом кода страны и кода города, но без знака +.");
                errorValidating.SetIconPadding(txtCountDigits, errorPadding);
                result = false;
                txtCountDigits.Focus();
            }

            if (string.IsNullOrEmpty(txtCountryCode.Text) || txtCountryCode.Text.Replace(" ", "").Length <= 1)
            {
                errorValidating.SetError(txtCountryCode, "Укажите Код страны в международном формате.");
                errorValidating.SetIconPadding(txtCountryCode, errorPadding);
                result = false;
                txtCountryCode.Focus();
            }

            if (string.IsNullOrEmpty(txtCountryName.Text))
            {
                errorValidating.SetError(txtCountryName, "Введите наименование страны.");
                errorValidating.SetIconPadding(txtCountryName, errorPadding);
                result = false;
                txtCountryName.Focus();
            }

            return result;
        }

        private void UpdateData(List<Country> countries)
        {
            GridCountries.DataGrid.DataSource = countries;
            GridCountries.DataGrid.Columns["Id"].Visible = false;
            GridCountries.DataGrid.Columns["CountryName"].Width = 140;
            GridCountries.DataGrid.Columns["CountryCode"].Width = 103;
            GridCountries.DataGrid.Columns["CountDigits"].Width = 100;
            GridCountries.DataGrid.Columns["CountDigits"].AllowHeaderTextWrapping = true;
            GridCountries.DataGrid.Columns["Example"].Width = 140;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EditCountry_Load(object sender, System.EventArgs e)
        {
            LoadDataCountry();
        }
        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadDataCountry()
        {
            using (var db = new ApplicationContext())
            {
                var countries = db.Country.ToList();
                UpdateData(countries);
            }
        }
        /// <summary>
        /// Изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            errorValidating.Clear();
            if (currentCountry != null)
            {
                txtCountryName.Text = currentCountry.CountryName;
                txtCountryCode.Text = currentCountry.CountryCode;
                txtCountDigits.Text = currentCountry.CountDigits.ToString();
                txtExample.Text = currentCountry.Example;


                btnAdd.Image = Resources.save;
                btnAdd.Text = "Сохранить";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Выберите в таблице страну для редактирования.", "Уведомление", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Добавление или Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (!IsValidation())
                return;

            var example = "";
                if (txtExample.Text.Replace(" ", "").Length > txtCountryCode.Text.Replace(" ", "").Length) example = txtExample.Text;
                if (btnAdd.Text == "Сохранить")
                {
                    using (var db = new ApplicationContext())
                    {
                        if (currentCountry != null)
                        {
                            currentCountry.CountryName = txtCountryName.Text.Trim();
                            currentCountry.CountryCode = txtCountryCode.Text.Replace(" ", "");
                            currentCountry.CountDigits = Convert.ToInt32(txtCountDigits.Text);
                            currentCountry.Example = example;

                            db.Country.Update(currentCountry);
                            db.SaveChanges();
                        }
                    }
                    ClearTextBox();
                    LoadDataCountry();
                    btnAdd.Text = "Добавить";
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                }
                else if (btnAdd.Text == "Добавить")
                {

                    using (var db = new ApplicationContext())
                    {
                        db.Country.Add(new Country()
                        {
                            CountryName = txtCountryName.Text.Trim(),
                            CountryCode = txtCountryCode.Text.Replace(" ", ""),
                            CountDigits = Convert.ToInt32(txtCountDigits.Text),
                            Example = example
                        });

                        db.SaveChanges();
                    }
                    ClearTextBox();
                    LoadDataCountry();
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
            txtCountryName.Text = "";
            txtCountryCode.Text = "";
            txtCountDigits.Text = "";
            txtExample.Mask = null;
            txtExample.Text = "";
        }
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (currentCountry != null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите удалить запись:\n " +
                    $"{currentCountry.CountryName} {currentCountry.CountryCode} {currentCountry.CountDigits}", "Уведомление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return; 
                using (var db = new ApplicationContext())
                {
                    db.Country.Remove(currentCountry);

                    db.SaveChanges();
                }
                LoadDataCountry();
            }
            else
            {
                MessageBox.Show("Выберите в таблице страну для удаления.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Формирование маски для примера номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExample_Enter(object sender, EventArgs e)
        {
            if (!IsValidation())
            {
                return;
            }
                

            txtExample.Mask = "+" + new string('0', Convert.ToInt32(txtCountDigits.Text));
            if (regex.Replace(txtExample.Text, "").Length == Convert.ToInt32(txtCountDigits.Text))
            {
                var tempText = txtExample.Text.Replace(" ", "");
                txtExample.Text = tempText;
                return;
            }
            txtExample.Text = txtCountryCode.Text;
        }

        /// <summary>
        /// Проверка примера номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExample_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountryCode.Text) ||
                txtCountryCode.Text.Replace(" ", "").Length <= 1 || string.IsNullOrEmpty(txtCountDigits.Text)) return;

            if (txtExample.Text.Replace(" ", "").Length > txtCountryCode.Text.Replace(" ", "").Length &&
                regex.Replace(txtExample.Text, "").Length < Convert.ToInt32(txtCountDigits.Text))
            {
                MessageBox.Show("Пример не соответствует введенным данным.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var tempText = txtExample.Text.Replace(" ", "");
                txtExample.Focus();
                txtExample.Text = tempText;
            }
        }
    }
}
