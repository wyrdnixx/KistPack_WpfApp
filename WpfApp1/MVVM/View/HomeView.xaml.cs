using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KistPack_Wpf.MVVM.View
{
    /// <summary>
    /// Interaktionslogik für HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        
        public HomeView()
        {
            InitializeComponent();
            DataTable dataTable = CreateDataTable();
            dgAkten.ItemsSource = dataTable.DefaultView;
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();

            // Define columns
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));

            // Add rows
            dt.Rows.Add(1, "John Doe", 30);
            dt.Rows.Add(2, "Jane Smith", 25);
            dt.Rows.Add(3, "Sam Brown", 27);

            return dt;
        }
    }
}
