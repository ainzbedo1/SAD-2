using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservations_Subsystem
{
    public class ReservationDataPresenter
    {
        private AddReservationView _form;
        private RoomDataService _service;
        private ReservationCalendarForm _formtriggrer;
        // if edit is true then editing then the form is editing
        public ReservationDataPresenter(AddReservationView form, RoomDataService roomService)
        {
                _form = form;
                //_formtriggrer = form;
                //_form.OnShowReservationInfo += View_OnShowReservationInfo;

                _service = roomService;
                var info = _service.getRoomInfoByRoomNumber(_form.RoomNumber);

                if (info == null)
                {
                    MessageBox.Show("Could not find an account for specified number.");
                    return;
                }

                _form.RoomNumber = info.RoomNumber;
                _form.RoomType = info.RoomType;
                _form.RoomId = info.RoomId;
  
        }
        public ReservationDataPresenter(AddReservationView form)
        {
            _form = form;
            //_formtriggrer = form;
            //_form.OnShowReservationInfo += View_OnShowReservationInfo

        }
        public ReservationDataPresenter(AddReservationView form, ReservationInfo myResInfo, RoomInfo myRoomInfo, CustomerInfo myCustomerInfo, MyButton resButt)
        {
            _form = form;
          
                //public void setValuesBasedOnReservationId(string roomType, string roomNumber, DateTime startDate, DateTime endDate, string description, decimal lengthOfStay)
            form.setValuesBasedOnReservationId(myRoomInfo.RoomType, myRoomInfo.RoomNumber, myResInfo.StartDate, myResInfo.EndDate, myResInfo.Desc);
            form.theCustomerInfo = myCustomerInfo;
            form.theReservation = myResInfo;
            form.referenceButton = resButt;

            form.EditForm = true;
        }

        public void Show()
        {
            _form.ShowDialog();
        }

        private void View_OnShowReservationInfo(object sender, EventArgs e)
        {
            //int RoomNumberToInt = Convert.ToInt32(_form.RoomNumber)
            var info = _service.getRoomInfoByRoomNumber(_form.RoomNumber);
 
            if (info == null)
            {
                MessageBox.Show("Could not find an account for specified number.");
                return;
            }

            _form.RoomNumber = info.RoomNumber;
            _form.RoomType = info.RoomType;


        }
    }
}
