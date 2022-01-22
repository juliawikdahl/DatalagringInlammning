using Entityframework_Inlamning.Models;
using Entityframework_Inlamning.Services;
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

namespace Entityframework_Inlamning.Views
{
    /// <summary>
    /// Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCustomerView : UserControl
    {
        public CreateCustomerView()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbAdress.Text) && !string.IsNullOrEmpty(tbPostnummer.Text) && !string.IsNullOrEmpty(tbStad.Text))
            {


                try
                {
                    ICustomerService CustomerServices = new CustomerService();
                    CustomerServices.CreateCustomer(new Customer
                    {
                        FirstName = tbName.Text,
                        LastName = tbLastName.Text,
                        Email = tbEmail.Text,
                        StreetName = tbAdress.Text,
                        PostalCode = tbPostnummer.Text,
                        City = tbStad.Text,

                    });
                    MessageBox.Show($"Sparade kund med emailen {tbEmail.Text}");

                    tbLastName.Text = "";
                    tbEmail.Text = "";
                    tbAdress.Text = "";
                    tbPostnummer.Text = "";
                    tbStad.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" Kunde inte spara kund på grund av felkod: {ex.Message}");
                }
            
            }
        }
    }
}
