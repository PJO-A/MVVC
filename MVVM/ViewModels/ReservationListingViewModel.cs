using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations=>_reservations;
        public ICommand MakeReservationCommand { get; }
        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            MakeReservationCommand = new NavigationCommands();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "SingeltonSeah", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "AAA", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "BBB", DateTime.Now, DateTime.Now)));

        }
    }
}
