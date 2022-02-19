using System.Windows;
using System.Windows.Controls;
using Laboratory1.ViewModels;
namespace Laboratory1.Views
{
    /// <summary>
    /// Interaction logic for DateOfBirthInfoViev.xaml
    /// </summary>
    public partial class DateOfBirthInfoView : UserControl
    {
        private DateOfBirthInfoViewModel viewModel;
        public DateOfBirthInfoView()
        {
            InitializeComponent();
            DataContext = viewModel = new DateOfBirthInfoViewModel();
        }
    }
}
