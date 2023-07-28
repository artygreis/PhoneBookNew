namespace PhoneBook.UserControls
{
    public partial class HouseControl : UserControl
    {
        public TextBox HouseTextBox => autoCompleteControlHouse.TextBox;

        public HouseControl()
        {
            InitializeComponent();
        }

        public void SetHouseInTextBox(string house)
        {
            autoCompleteControlHouse.TextBox.Text = house;
        }
    }
}
