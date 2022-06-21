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
    /// Interaction logic for AddCities.xaml
    /// </summary>
    public partial class AddCities : Window
    {
        public AddCities()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAddCitytoDB_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO City (CityName) VALUES (@Cityname)";

            using(SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("Cityname", txtCityName.Text);
                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result == 1) 
                    //MessageBox("New city added"); 
                
                //lblValMess.Text = "City added";
                else
                    //lblValMess.Text = "City not added";
            }
        }
    }
}
