using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace A2KatarzynaKarakow
{
    /// <summary>
    /// Interaction logic for AddContinent.xaml
    /// </summary>
    public partial class AddContinent : Window
    {
        public AddContinent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAddContinenName_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
