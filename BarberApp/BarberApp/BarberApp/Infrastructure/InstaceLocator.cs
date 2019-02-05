
namespace BarberApp.Infrastructure
{
    using ViewModel;
   
    public class InstaceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
