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
using static Entityframework_Inlamning.Services.IErrandService;

namespace Entityframework_Inlamning.Views
{
    /// <summary>
    /// Interaction logic for CreateErrandView.xaml
    /// </summary>
    public partial class CreateErrandView : UserControl
    {
        public CreateErrandView()
        {
            InitializeComponent();
        }



        private void ButtonSkapa_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitle.Text) && !string.IsNullOrEmpty(tbDescription.Text))
            {

                ICustomerService CustomerService = new CustomerService();

                var customerToHandle = CustomerService.GetEmail(tbEmail.Text);
                if (customerToHandle is null)
                {
                    MessageBox.Show("Kunden finns inte!");
                    return;
                }

              
                   try
                  {
                    IErrandService ErrandService = new ErrandService();

                     ErrandService.CreateErrand(new Errand
                {
                    CustomerId = customerToHandle.Id,
                    Title = tbTitle.Text,
                    Description = tbDescription.Text,
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now,
                    State = State.NotRunning
                });

                MessageBox.Show($"Sparade ärendet med titeln {tbTitle.Text}");
           
                tbTitle.Text = "";
                tbDescription.Text = "";
    
            }
                catch (Exception ex)
            {
                MessageBox.Show($" Kunde inte spara ärendet på grund av felkod: {ex.Message}");
            }
        }
        }
    }
}
