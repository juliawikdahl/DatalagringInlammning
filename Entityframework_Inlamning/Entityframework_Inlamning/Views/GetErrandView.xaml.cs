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
    /// Interaction logic for GetErrandView.xaml
    /// </summary>
    public partial class GetErrandView : UserControl
    {
        public GetErrandView()
        {
            InitializeComponent();

            IErrandService ErrandService = new ErrandService();

            var data = ErrandService.GetAll();
            ListErrands.ItemsSource = data.Select(d => $"{d.Title}, {d.Description}, {d.CreatedTime}, {d.State}, {d.UpdatedTime}");
        }

       
    }
}
