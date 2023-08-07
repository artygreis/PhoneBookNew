using PhoneBook.Types;

namespace PhoneBook.UserControls
{
    public partial class ApartmentControl : UserControl
    {
        public event Action<int>? ApartmentChanged;

        public ApartmentControl()
        {
            InitializeComponent();

            autoCompleteControlApartment.AutoCompleteItemSelected += AutoCompleteControlApartment_AutoCompleteItemSelected;
        }

        private void AutoCompleteControlApartment_AutoCompleteItemSelected(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
        {
            var apartmentId = autoCompleteControlApartment.AutoComplete.GetItemArray(args.SelectedValue)[0];
            ApartmentChanged?.Invoke(Convert.ToInt32(apartmentId));
        }

        public void LoadApartment(int addressId)
        {
            var apartments = ApartmentCollection.GetApartmentCollections(addressId);

            autoCompleteControlApartment.AutoComplete.Columns.Clear();
            autoCompleteControlApartment.AutoComplete.DataSource = null;
            autoCompleteControlApartment.AutoComplete.ParentForm = this;

            autoCompleteControlApartment.AutoComplete.DataSource = apartments;
            autoCompleteControlApartment.AutoComplete.RefreshColumns();
            autoCompleteControlApartment.AutoComplete.Columns[1].MatchingColumn = true;
            autoCompleteControlApartment.AutoComplete.Columns[0].Visible = false;
        }

        public void ClearDataApartment()
        {
            autoCompleteControlApartment.TextBox.Text = "";
            autoCompleteControlApartment.AutoComplete.DataSource = null;
            autoCompleteControlApartment.AutoComplete.ResetHistory();
        }

        public int GetApartmentId()
        {
            return Convert.ToInt32(autoCompleteControlApartment.AutoComplete.GetItemArray(autoCompleteControlApartment.TextBox.Text)[0]);
        }

        public string GetTextApartment()
        {
            return autoCompleteControlApartment.TextBox.Text;
        }
    }
}
