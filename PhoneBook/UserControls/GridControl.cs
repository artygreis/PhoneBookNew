using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;

namespace PhoneBook.UserControls
{
    public partial class GridControl : UserControl
    {
        public GridSelectionMode SelectionModeGrid
        {
            set
            {
                if (value != 0)
                    generalViewGrid.SelectionMode = value;
                else
                    generalViewGrid.SelectionMode = GridSelectionMode.Single;
            }
        }
        public SelectionUnit SelectionUnitGrid
        {
            set
            {
                if (value != 0)
                    generalViewGrid.SelectionUnit = value;
                else
                    generalViewGrid.SelectionUnit = SelectionUnit.Row;
            }
        }

        public SfDataGrid DataGrid
        {
            get
            {
                return generalViewGrid;
            }
        }
        public GridControl()
        {
            InitializeComponent();
            generalViewGrid.SelectionMode = GridSelectionMode.Single;
            generalViewGrid.SelectionUnit = SelectionUnit.Row;
        }
    }
}
