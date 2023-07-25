using PhoneBook.Forms;
using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;

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
            cityControlAddApartments.LoadCity(countryId);
            ClearDataOnAddApartmentsTab("CountryControl");
        }

        private void CityControlAddApartments_CityChanged(int cityId)
        {
            maskNumber = City.GetMaskNumberbyCityId(cityId);

            addressControlAddApartments.LoadAddress(cityId, chkPrivateHouse.Checked);
            ClearDataOnAddApartmentsTab("CityControl");
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
    }
}
