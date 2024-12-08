using MVVM.Comands;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username= value;
                OnPropertyChange(nameof(Username));
            }
        }
/// <summary>
/// 
/// </summary>
        private int _roomNumber;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                OnPropertyChange(nameof(RoomNumber));
            }
        }
/// <summary>
/// 
/// </summary>
        private int _floorNumber;
        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value;
                OnPropertyChange(nameof(FloorNumber));
            }
        }

/// <summary>
/// 
/// </summary>
        private DateTime _startDate = new DateTime(2021,1,1);
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChange(nameof(StartDate));
            }
        }
/// <summary>
/// 
/// </summary>
        private DateTime _endDate = new DateTime(2021, 1, 1);
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnPropertyChange(nameof(EndDate));
            }
        }
/// <summary>
/// 
/// </summary>
      public ICommand SubmitCommand { get; }
      public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel)
        {
           SubmitCommand = new MakeReservationCommand(this, hotel);
           CancelCommand = new CancelMakeReservationCommand();
        }



    }
}
