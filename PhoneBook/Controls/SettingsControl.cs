using PhoneBook.Types.Settings;
using PhoneBook.UserForms;
using Squirrel;
using Syncfusion.Windows.Forms;
using System.Reflection;

namespace PhoneBook.Controls
{
    public partial class SettingsControl : UserControl
    {
        private Button buttonSetting = new Button();

        public SettingsControl()
        {
            InitializeComponent();
            clrSelectNotCall.ColorUI.BorderStyle = BorderStyle.None;
            clrSelectNotCall.ColorUI.Font = new Font(Font, FontStyle.Regular);
            clrSelectNotDoor.ColorUI.BorderStyle = BorderStyle.None;
            clrSelectNotDoor.ColorUI.Font = new Font(Font, FontStyle.Regular);
        }

        public SettingsControl(Button button, bool update) : this()
        {
            buttonSetting = button;
            btnApplyUpdate.Visible = update;
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            UpdateDataSettings();
        }

        #region Выбор цвета для тех, кто просил не звонить
        private void clrSelectNotCall_ColorSelected(object sender, EventArgs e)
        {
            if (sender is ColorPickerButton color)
            {
                SaveColor(colorNotCall: color.SelectedColor.ToKnownColor().ToString());
            }
        }

        private void btnResetColorNotCall_Click(object sender, EventArgs e)
        {
            SaveColor(colorNotCall: ColorSettings.GetDefaultColorNotCall.ToKnownColor().ToString());
            clrSelectNotCall.SelectedColor = ColorSettings.GetDefaultColorNotCall;
        }
        #endregion

        #region Выбор цвета для тех, кто просил не заходить
        private void clrSelectNotDoor_ColorSelected(object sender, EventArgs e)
        {
            if (sender is ColorPickerButton color)
            {
                SaveColor(colorNotDoor: color.SelectedColor.ToKnownColor().ToString());
            }
        }

        private void btnResetColorNotDoor_Click(object sender, EventArgs e)
        {
            SaveColor(colorNotDoor: ColorSettings.GetDefaultColorNotDoor.ToKnownColor().ToString());
            clrSelectNotDoor.SelectedColor = ColorSettings.GetDefaultColorNotDoor;
        }
        #endregion

        #region Выбор цвета для тех, кто просил не беспокоить
        private void clrSelectNotFull_ColorSelected(object sender, EventArgs e)
        {
            if (sender is ColorPickerButton color)
            {
                SaveColor(colorNotFull: color.SelectedColor.ToKnownColor().ToString());
            }
        }
        private void btnResetColorNotFull_Load(object sender, EventArgs e)
        {
            SaveColor(colorNotFull: ColorSettings.GetDefaultColorNotFull.ToKnownColor().ToString());
            clrSelectNotFull.SelectedColor = ColorSettings.GetDefaultColorNotFull;
        }
        #endregion

        /// <summary>
        /// Сохранение информации о цвете в БД
        /// </summary>
        /// <param name="colorNotCall"></param>
        /// <param name="colorNotDoor"></param>
        private void SaveColor(string? colorNotCall = null, string? colorNotDoor = null, string? colorNotFull = null)
        {
            var settings = Settings.Load();

            if (settings == null) return;

            if (colorNotCall != null)
            {
                settings.ColorNotCall = colorNotCall;
            }
            if (colorNotDoor != null)
            {
                settings.ColorNotDoor = colorNotDoor;
            }
            if (colorNotFull != null)
            {
                settings.ColorNotFull = colorNotFull;
            }
            settings.Save();
        }

        /// <summary>
        /// Обновление настроек
        /// </summary>
        private void UpdateDataSettings()
        {
            var settings = Settings.Load();

            if (settings != null)
            {
                if (!string.IsNullOrEmpty(settings.UserSourceDb))
                {
                    textBoxSourceFile.Text = settings.UserSourceDb;
                }

                if (!string.IsNullOrEmpty(settings.ColorNotCall))
                {
                    clrSelectNotCall.SelectedColor = ColorTranslator.FromHtml(settings.ColorNotCall);
                }
                if (!string.IsNullOrEmpty(settings.ColorNotDoor))
                {
                    clrSelectNotDoor.SelectedColor = ColorTranslator.FromHtml(settings.ColorNotDoor);
                }
                if (!string.IsNullOrEmpty(settings.ColorNotFull))
                {
                    clrSelectNotFull.SelectedColor = ColorTranslator.FromHtml(settings.ColorNotFull);
                }
            }
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            var settingsForm = new DataBaseSettings();
            settingsForm.Text = $"Настройка телефонного справоника (базы данных)";
            settingsForm.ShowDialog();
            UpdateDataSettings();
        }

        Squirrel.ReleaseEntry? newVersion;

        private async Task UpdateMyApp()
        {
            using var mgr = new UpdateManager("https://github.com/artygreis/PhoneBookNew/releases/latest");
            newVersion = await mgr.UpdateApp();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateMyApp();
        }

        private void btnApplyUpdate_Load(object sender, EventArgs e)
        {
            // optionally restart the app automatically, or ask the user if/when they want to restart
            if (newVersion != null)
            {
                UpdateManager.RestartApp();
            }
        }
    }
}
