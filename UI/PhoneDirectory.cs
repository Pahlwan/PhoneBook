using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Views;
using Repository;
using Repository.Models;

namespace UI
{
    public partial class PhoneDirectory : Form,IPoneDirectoryView
    {
        readonly UnitOfWork _unitOfWork;
        public PhoneDirectory(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        public Person SelectedPerson { get; set; }

        public void Add(Person person)
        {
            dataGridViewPhoneDirectory.Rows.Add(person);
        }

        public void Delete(Person person)
        {
            dataGridViewPhoneDirectory.Rows.Remove(dataGridViewPhoneDirectory.CurrentRow);
        }

        public void Update(Person person)
        {
            //dataGridViewPhoneDirectory.CurrentRow = new DataGridViewRow(person);
        }

        private void PhoneDirectory_Load(object sender, EventArgs e)
        {
            foreach(var person in _unitOfWork.People.GetAll())
            {
                dataGridViewPhoneDirectory.Rows.Add(new[] { person.name, person.phoneNumber, person.address });
            }
        }

        //DataGridViewRow ModelToView(Person person)
        //{

        //}

        Person ViewToModel(DataGridViewRow row)
        {
            DataGridViewRow selectedRow = dataGridViewPhoneDirectory.CurrentRow;
            Person person = new Person();
            person.name = selectedRow.Cells[0].Value.ToString();
            person.phoneNumber = selectedRow.Cells[1].Value.ToString();
            person.address = selectedRow.Cells[2].Value.ToString();
            return person;
        }
        

        private void dataGridViewPhoneDirectory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                SelectedPerson = ViewToModel(dataGridViewPhoneDirectory.CurrentRow);
                _unitOfWork.People.Add(SelectedPerson);
                _unitOfWork.Complete();
            }
            
        }
    }
}
