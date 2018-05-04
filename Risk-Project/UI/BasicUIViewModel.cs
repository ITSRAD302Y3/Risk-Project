using EmptyKeys.UserInterface.Mvvm;
using Risk_Project.Players;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk_Project.UI
{
    public class BasicUIViewModel : ViewModelBase
    {
        #region Properties

        private ObservableCollection<Order> orders;
        private ObservableCollection<Player> players;

        #endregion

        public BasicUIViewModel()
        {
            orders = new ObservableCollection<Order>();
            players = new ObservableCollection<Player>();
        }
    }
}
