using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations_Subsystem
{
    public class RoomTypeInfo
    {
        private int typeId { get; set; }
        private string typeName { get; set;}
            

        public int TypeId
        {
            set { typeId = value; }
            get { return typeId; }
        }

        public string TypeName
        {
            set { typeName = value; }
            get { return typeName; }
        }
    }
}
