namespace PhoneBook.UserControls
{
    public partial class ButtonControl : UserControl
    {
        public Image ImageButton
        {
            get => button.Image;
            set => button.Image = value;
        }
        public string TextButton
        {
            get => button.Text;
            set => button.Text = value;
        }
        public Font FontButton
        {
            get => button.Font;
            set => button.Font = value;
        }
        public event EventHandler? ButtonClick;
        public ButtonControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(sender, e);
        }
    }
}
