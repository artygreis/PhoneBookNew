using PhoneBook.Types;
using System.Text.RegularExpressions;

namespace PhoneBook.UserForms
{
    public partial class AddSingleNumber : Form
    {
        Regex regex = new Regex(@"[^0-9]");
        private string _address;
        public NumberPhone NumberPhone { get; set; } = new NumberPhone();
        private string _mask;
        public AddSingleNumber(string address, string mask)
        {
            InitializeComponent();

            _mask = mask.Replace('#', '9');
            _address = address;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddSingleNumber_Load(object sender, EventArgs e)
        {
            lblAddress.Text = $"{_address}";
            if (!string.IsNullOrEmpty(_mask))
            {
                txtNumber.Mask = _mask;
            }
            if (NumberPhone != null)
            {
                txtApartment.Text = NumberPhone.Apartment;
                txtNumber.Text = NumberPhone.Number;
            }
            else
            {
                NumberPhone = new NumberPhone();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApartment.Text))
            {
                errorValidating.SetError(txtApartment, "Введите номер квартиры.");
                errorValidating.SetIconPadding(txtApartment, 8);
                return;
            }
            errorValidating.Clear();
            if (regex.Replace(txtNumber.Text, "").Length != 0 && regex.Replace(txtNumber.Text, "").Length != _mask.Replace("-", "").Length)
            {
                errorValidating.SetError(txtNumber, $"В номере должно быть {_mask.Replace("-", "").Length} цифр");
                errorValidating.SetIconPadding(txtNumber, 8);
                return;
            }
            errorValidating.Clear();
            NumberPhone.Apartment = txtApartment.Text.Trim();
            NumberPhone.Number = regex.Replace(txtNumber.Text.Trim(), "");
            DialogResult = DialogResult.OK;
        }
    }
}
