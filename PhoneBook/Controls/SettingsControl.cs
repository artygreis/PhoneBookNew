﻿using PhoneBook.Types.Settings;
using PhoneBook.UserForms;
using Syncfusion.Windows.Forms;

namespace PhoneBook.Controls
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            clrSelectNotCall.ColorUI.BorderStyle = BorderStyle.None;
            clrSelectNotCall.ColorUI.Font = new Font(Font, FontStyle.Regular);
            clrSelectNotDoor.ColorUI.BorderStyle = BorderStyle.None;
            clrSelectNotDoor.ColorUI.Font = new Font(Font, FontStyle.Regular);
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

        /// <summary>
        /// Сохранение информации о цвете в БД
        /// </summary>
        /// <param name="colorNotCall"></param>
        /// <param name="colorNotDoor"></param>
        private void SaveColor(string? colorNotCall = null, string? colorNotDoor = null)
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
            }
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            var settingsForm = new DataBaseSettings();
            settingsForm.Text = $"Настройка телефонного справоника (базы данных)";
            settingsForm.ShowDialog();
            UpdateDataSettings();
        }
    }
}
