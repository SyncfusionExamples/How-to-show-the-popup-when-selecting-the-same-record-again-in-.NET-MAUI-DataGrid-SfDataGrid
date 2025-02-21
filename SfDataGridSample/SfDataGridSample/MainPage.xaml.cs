using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClosePopup(object sender, EventArgs e)
        {
            popup.IsOpen = false;
        }

        private void sfGrid_CellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
        {
            var employee = e.RowData as Employee;
            if (employee != null &&  sfGrid.SelectedRows.Contains(employee))
            { 
                viewModel.UpdateSelectedEmployee(employee);
            }
        }
    }
}
