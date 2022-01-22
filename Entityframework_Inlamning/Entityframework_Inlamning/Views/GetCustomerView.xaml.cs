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
    /// Interaction logic for GetCustomerView.xaml
    /// </summary>
    public partial class GetCustomerView : UserControl
    {
        public GetCustomerView()
        {
            InitializeComponent();

            ICustomerService CustomerService = new CustomerService();

            var data = CustomerService.GetAll();
            ListCustomers.ItemsSource = data.Select(d => $"{d.FirstName} {d.LastName}, {d.Email}, {d.StreetName}, {d.PostalCode}, {d.City}");
        }
    }
}
