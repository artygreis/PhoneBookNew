using PhoneBook.Types;

namespace PhoneBook.UserControls
{
    public partial class AddressControl : UserControl
    {
        public event Action<int>? AddressChanged;

        public AddressControl()
        {
            InitializeComponent();

            autoCompleteControlAddress.AutoCompleteItemSelected += AutoCompleteControlAddress_AutoCompleteItemSelected;
        }

        private void AutoCompleteControlAddress_AutoCompleteItemSelected(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
        {
            var cityId = autoCompleteControlAddress.AutoComplete.GetItemArray(args.SelectedValue)[0];
            AddressChanged?.Invoke(Convert.ToInt32(cityId));
        }

        public void LoadAddress(int cityId, bool privatehouse)
        {
            var addresses = AddressCollection.GetAddressCollections(cityId, privatehouse);

            autoCompleteControlAddress.AutoComplete.Columns.Clear();
            autoCompleteControlAddress.AutoComplete.DataSource = null;
            autoCompleteControlAddress.AutoComplete.ParentForm = this;

            autoCompleteControlAddress.AutoComplete.DataSource = addresses;
            autoCompleteControlAddress.AutoComplete.RefreshColumns();
            autoCompleteControlAddress.AutoComplete.Columns[1].MatchingColumn = true;
            autoCompleteControlAddress.AutoComplete.Columns[0].Visible = false;
            autoCompleteControlAddress.AutoComplete.Columns[2].Visible = false;
        }

        public void ClearDataAddress()
        {
            autoCompleteControlAddress.TextBox.Text = "";
            autoCompleteControlAddress.AutoComplete.DataSource = null;
            autoCompleteControlAddress.AutoComplete.ResetHistory();
        }

        public int GetAddressId()
        {
            return Convert.ToInt32(autoCompleteControlAddress.AutoComplete.GetItemArray(autoCompleteControlAddress.TextBox.Text)[0]);
        }

        public string GetTextAddress()
        {
            return autoCompleteControlAddress.TextBox.Text;
        }
    }
}
