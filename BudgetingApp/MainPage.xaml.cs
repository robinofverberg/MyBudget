using System.Collections.ObjectModel;

namespace BudgetingApp
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection <int > Accounts { get; set; } = [1,2,3];

        public MainPage()
        {
            InitializeComponent();
        }
    }

}
