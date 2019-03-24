using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations_Subsystem
{
    public partial class AddCustomerForm : Form
    {
        public AddReservationView reference {get; set;}
        public CustomerDataService myCustomerDataService = new CustomerDataService();
        public ReservationDataService reservationDataService = new ReservationDataService();
        public CustomerInfo formCustInfo = new CustomerInfo();
        public Boolean editForm = false;
        private int custId { get; set; }
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        public string SurName
        {
            set { txtName.Text = value; }
            get { return txtName.Text; }
        }
        public string Company
        {
            set { txtCompany.Text = value; }
            get { return txtCompany.Text; }
        }
        public string Address
        {
            set { txtAddress.Text = value; }
            get { return txtAddress.Text; }
        }
        public string Phone
        {
            set { txtPhone.Text = value; }
            get { return txtName.Text; }
        }
        public string Passport
        {
            set { txtPassport.Text = value; }
            get { return txtPassport.Text; }
        }
        public string Gender
        {
            set { txtGender.Text = value; }
            get { return txtGender.Text; }
        }
        public string Email
        {
            set { txtEmail.Text = value; }
            get { return txtEmail.Text; }
        }
        public string Nationality
        {
            set { txtNationality.Text = value; }
            get { return txtNationality.Text; }
        }
        public DateTime BirthDate
        {
            set {dtpBirthdate.Value = value; }
            get { return dtpBirthdate.Value; }
        }
        public string BirthPlace 
        {
            set { txtBirthPlace.Text = value; }
            get { return txtBirthPlace.Text; }
        }
        public string Comment
        {
            set { txtComment.Text = value; }
            get { return txtComment.Text; }
        }
        
        public CustomerInfo FormCustInfo
        {
            set { formCustInfo = value; }
            get { return formCustInfo;  }
        }
        

        public void SetCustomerInformation(CustomerInfo myCustInfo)
        {
            try
            {
                if (myCustInfo.BirthDate < dtpBirthdate.MinDate)
                {
                    MessageBox.Show("fucker");
                    txtName.TextChanged -= txtName_TextChanged;

                    myCustInfo.BirthDate = DateTime.Now.Date;
                    SurName = myCustInfo.Name;
                    Company = myCustInfo.Company;
                    Address = myCustInfo.Address;
                    Phone = myCustInfo.Phone;
                    Passport = myCustInfo.Passport;
                    Gender = myCustInfo.Gender;
                    Email = myCustInfo.Email;
                    Nationality = myCustInfo.Nationality;
                    BirthDate = myCustInfo.BirthDate;
                    BirthPlace = myCustInfo.BirthPlace;
                    Comment = myCustInfo.Comment;

                    FormCustInfo = myCustInfo;
                    //CustId = Convert.ToInt32(myCustInfo.Id);

                    txtName.TextChanged += txtName_TextChanged;

                }
                else
                {
                    txtName.TextChanged -= txtName_TextChanged;

                    
                    SurName = myCustInfo.Name;
                    Company = myCustInfo.Company;
                    Address = myCustInfo.Address;
                    Phone = myCustInfo.Phone;
                    Passport = myCustInfo.Id;
                    Gender = myCustInfo.Gender;
                    Email = myCustInfo.Email;
                    Nationality = myCustInfo.Nationality;
                    BirthDate = myCustInfo.BirthDate;
                    BirthPlace = myCustInfo.BirthPlace;
                    Comment = myCustInfo.Comment;
                    //CustId = Convert.ToInt32(myCustInfo.Id);
                    FormCustInfo = myCustInfo;


                    txtName.TextChanged += txtName_TextChanged;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() +"error in setting");
            }
        }
        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            txtName.TextChanged -= txtName_TextChanged;
            //MessageBox.Show(SurName.ToString()+"dick");
            
            dgvCustomer.DataSource = myCustomerDataService.GetAllCustomers();
            dgvCustomer.Columns[0].Visible = false;
            
            txtName.TextChanged += txtName_TextChanged;
            //SurName = SurName;
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dgvCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", txtName.Text);
                dgvCustomer.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
               // MessageBox.Show("search failed "+ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPassport.Clear();
            txtPhone.Clear();
            txtGender.Clear();
            txtEmail.Clear();
            txtNationality.Clear();
            txtBirthPlace.Clear();
            txtComment.Clear();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)){
                MessageBox.Show("Name needs to be filled in");
            }
            else if (editForm) //If editing
            {
                try
                {
                    MessageBox.Show("Updating Customer");

                    //CustomerDataService myCustomerDataService2 = new CustomerDataService();
                    //CustomerInfo custInfo = new CustomerInfo();
                    //custInfo = FormCustInfo;
                    MessageBox.Show(FormCustInfo.Id.ToString());
                    myCustomerDataService.UpdateCustomer(Convert.ToInt32(FormCustInfo.Id), txtName.Text, txtCompany.Text,
                        txtAddress.Text, txtPhone.Text, txtEmail.Text, txtPassport.Text, txtNationality.Text, txtGender.Text, 
                        dtpBirthdate.Value, txtBirthPlace.Text, txtComment.Text);

                    reference.theCustomerInfo = FormCustInfo;
                    reference.CustomerName = SurName;
                    reference.EditFormIsTrue();
                    reference.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    
                    MessageBox.Show("insert customer");
                    
                    
                    long myLastCustomerInsert = myCustomerDataService.InsertIntoCustomer(txtName.Text, txtCompany.Text, txtAddress.Text,
                         txtPhone.Text, txtEmail.Text, "passport", txtNationality.Text, txtGender.Text,
                         dtpBirthdate.Value, txtBirthPlace.Text, txtComment.Text);
                        
                    CustomerDataService myCustomerDataService2 = new CustomerDataService();
                    CustomerInfo custInfo = new CustomerInfo();

                    //custInfo = myCustomerDataService2.GetCustomerInfoById(Convert.ToInt32(myLastCustomerInsert));
                    //reference.theCustomerInfo.Id = myLastCustomerInsert.ToString();
                    reference.theCustomerInfo = GettingCustomerInfo(Convert.ToInt32(myLastCustomerInsert));
                    reference.CustomerName = SurName;
                    //reference.theCustomerInfo = FormCustInfo;
                    //MessageBox.Show(reference.Id.ToString() + "over here bois");

                    // MessageBox.Show(FormCustInfo.Id.ToString());
                    // MessageBox.Show(reference.theCustomerInfo.Id.ToString()+"hello");

                    reference.AddFormIsTrue();
                    reference.Show();
                    this.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private CustomerInfo GettingCustomerInfo(int id)
        {
            CustomerInfo custInfo = new CustomerInfo();
            CustomerDataService myCustomerDataService2 = new CustomerDataService();

            custInfo = myCustomerDataService2.GetCustomerInfoById(Convert.ToInt32(id));
            return custInfo;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                try
                {
                    CustomerInfo customerInfo = new CustomerInfo();

                    customerInfo.Id = (dgvCustomer.SelectedRows[0].Cells[0].Value).ToString();
                    customerInfo.Name = (dgvCustomer.SelectedRows[0].Cells[1].Value.ToString());
                    customerInfo.Company = (dgvCustomer.SelectedRows[0].Cells[2].Value.ToString());
                    customerInfo.Address = (dgvCustomer.SelectedRows[0].Cells[3].Value.ToString());
                    customerInfo.Phone = (dgvCustomer.SelectedRows[0].Cells[4].Value.ToString());
                    customerInfo.Email = (dgvCustomer.SelectedRows[0].Cells[5].Value.ToString());
                    customerInfo.Passport = (dgvCustomer.SelectedRows[0].Cells[6].Value.ToString()+"fasfda");
                    customerInfo.Nationality =(dgvCustomer.SelectedRows[0].Cells[7].Value.ToString());
                    customerInfo.Gender = (dgvCustomer.SelectedRows[0].Cells[8].Value.ToString());
                    customerInfo.BirthDate = Convert.ToDateTime(dgvCustomer.SelectedRows[0].Cells[9].Value.ToString());
                    customerInfo.BirthPlace = (dgvCustomer.SelectedRows[0].Cells[10].Value.ToString());
                    SetCustomerInformation(customerInfo);
                    editForm = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("selecting from datagridview failed "+ex.ToString());
                }

            }
        }
    }
}
