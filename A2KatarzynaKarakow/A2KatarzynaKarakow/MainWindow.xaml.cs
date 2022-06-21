using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;

namespace A2KatarzynaKarakow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadComboBox();
            //LoadListBox();
          
        }
        private void LoadComboBox()
        {
            try
            {
                string query = "SELECT * FROM Continent";
                SqlConnection conn = new SqlConnection(Data.ConnectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string continentsName = sdr.GetString(1);
                    cboxContinents.Items.Add(continentsName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadListBox()
        {

        }

        private void LoadDataGrid()
        {
            /*
            string query = "SELECT CityId, CityName, IsCapital, Population, CountryId FROM City";
            SqlConnection conn = new SqlConnection(Data.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable tblContinents = new DataTable();
            tblContinents.Load(sdr);

            dgCities.ItemsSource = tblContinents.DefaultView;

            conn.Close();
            */
        }



        private void LoadLanguages()
        {

        }

        private void cboxContinents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadComboBox();
            }

            private void dgCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // LoadDataGrid();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string query = "SELECT * FROM Country WHERE ContinentId = @Continentid";

            using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                _ = cmd.Parameters.AddWithValue("@Continentid", cboxContinents.SelectedItem);
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string countriesName = sdr.GetString(1);
                    lboxCountries.Items.Add(countriesName);
                }

            }



        } // end of ListBox_SelectionChanged

        private void btnAddContinent_Click(object sender, RoutedEventArgs e)
        {
            AddContinent addContinent = new AddContinent();
            addContinent.ShowDialog();
        }

        private void btnAddCountries_Click(object sender, RoutedEventArgs e)
        {
            AddCountry addCountry = new AddCountry();
            addCountry.ShowDialog();
        }

        private void btnAddCities_Click(object sender, RoutedEventArgs e)
        {
            AddCities addCities = new AddCities();
            addCities.ShowDialog();
        }
    }
   
    

}
    

