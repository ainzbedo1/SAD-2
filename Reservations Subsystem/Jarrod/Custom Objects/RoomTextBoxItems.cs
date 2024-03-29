﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations_Subsystem
{
    public class RoomTextBoxItems
    {
        public int ID { get; set; }
        public string roomNumber { get; set; }
        public string roomType { get; set; }
        // public string Text { get; set; }
        public override string ToString()
        {
            return roomNumber;
        }
        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }
    }
}
