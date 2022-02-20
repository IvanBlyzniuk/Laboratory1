using System.Windows.Controls;
using Laboratory1.ViewModels;
namespace Laboratory1.Views
{
    /// <summary>
    /// Interaction logic for DateOfBirthInfoViev.xaml
    /// </summary>
    public partial class DateOfBirthInfoView : UserControl
    {
        public DateOfBirthInfoView()
        {
            InitializeComponent();
            DataContext = new DateOfBirthInfoViewModel();
        }
    }
}
