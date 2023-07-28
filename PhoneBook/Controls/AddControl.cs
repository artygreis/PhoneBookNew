using PhoneBook.Forms;
using PhoneBook.Types;
using PhoneBook.UserForms;

namespace PhoneBook.Controls
{
    public partial class AddControl : UserControl
    {
        private string maskNumber = "";

        public AddControl()
        {
            InitializeComponent();

            countryControlAddApartments.CountryChanged += CountryControlAddApartments_CountryChanged;
            cityControlAddApartments.CityChanged += CityControlAddApartments_CityChanged;
        }

        private void AddControl_Load(object sender, EventArgs e)
        {
            tabControlAddAdv_SelectedIndexChanged(tabControlAddAdv, new EventArgs());
        }

        private void CountryControlAddApartments_CountryChanged(int countryId)
        {
            ClearDataOnAddApartmentsTab("CountryControl");
            cityControlAddApartments.LoadCity(countryId);
        }

        private void CityControlAddApartments_CityChanged(int cityId)
        {
            ClearDataOnAddApartmentsTab("CityControl");

            maskNumber = City.GetMaskNumberbyCityId(cityId);

            addressControlAddApartments.LoadAddress(cityId, chkPrivateHouse.Checked);
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
                    chkPrivateHouse.Enabled = true;
                    goto case "AddressControl";
                case "AddressControl":

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
            addressControlAddApartments.ClearDataAddress();
            cityControlAddApartments.SelectCity(cityControlAddApartments.GetCityId());
        }
    }
}
