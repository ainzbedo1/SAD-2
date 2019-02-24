using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations_Subsystem
{
   public class CustomerInfo
    {
        private string id { get; set; }
        private string name { get; set; }
        private string address { get; set; }
        private string company { get; set; }
        private string email { get; set; }
        private string passport { get; set; }
        private string nationality { get; set; }
        private string gender { get; set; }
        private DateTime birthdate { get; set; }
        private string birthplace { get; set; }
        private string phone { get; set;  }


        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Phone
        {
            set { phone = value; }
            get { return phone; }
        }

        public string Something
        {
            set { name = value; }
            get { return name; }
        }


        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public string Company
        {
            set { company = value; }
            get { return company; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string Passport
        {
            set { passport = value; }
            get { return passport; }
        }
        public string Nationality
        {
            set { nationality = value; }
            get { return nationality; }
        }
        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public DateTime BirthDate
        {
            set { birthdate = value; }
            get { return birthdate; }
        }
        public string BirthPlace
        {
            set { birthplace = value; }
            get { return birthplace; }
        }

    }
    
}
