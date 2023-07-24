using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace PhoneBook.UserControls
{
    partial class GridControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.generalViewGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.generalViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // generalViewGrid
            // 
            this.generalViewGrid.AccessibleName = "Table";
            this.generalViewGrid.AllowEditing = false;
            this.generalViewGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            this.generalViewGrid.BackColor = System.Drawing.Color.Silver;
            this.generalViewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalViewGrid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generalViewGrid.HeaderRowHeight = 28;
            this.generalViewGrid.Location = new System.Drawing.Point(0, 5);
            this.generalViewGrid.Name = "generalViewGrid";
            this.generalViewGrid.RowHeight = 25;
            this.generalViewGrid.SerializationController = null;
            this.generalViewGrid.Size = new System.Drawing.Size(690, 483);
            this.generalViewGrid.Style.BorderColor = System.Drawing.Color.Gray;
            this.generalViewGrid.Style.CaptionSummaryRowStyle.BackColor = System.Drawing.Color.White;
            this.generalViewGrid.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.generalViewGrid.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.Window;
            this.generalViewGrid.Style.HeaderStyle.Font.Bold = true;
            this.generalViewGrid.Style.HeaderStyle.Font.Size = 10F;
            this.generalViewGrid.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.generalViewGrid.TabIndex = 0;
            // 
            // GridControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.generalViewGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "GridControl";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Size = new System.Drawing.Size(690, 488);
            ((System.ComponentModel.ISupportInitialize)(this.generalViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SfDataGrid generalViewGrid;
    }
}
