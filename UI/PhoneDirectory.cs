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
            dataGridViewPhoneDirectory.Focus();
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
                dataGridViewPhoneDirectory.Rows.Add(new[] { person.id.ToString(),person.name, person.phoneNumber, person.address });
            }
            Focus();
            dataGridViewPhoneDirectory.Focus();
        }

        Person ViewToModel(DataGridViewRow row)
        {
            DataGridViewRow selectedRow = dataGridViewPhoneDirectory.CurrentRow;
            Person person = new Person();
            int id;
            if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out id))
            {
                person.id = id;
            }
            if(id == 0)
            {
                id = _unitOfWork.People.GetAll().Last().id + 1;
                selectedRow.Cells[0].Value = id;
            }
            person.id = id;
            person.name = selectedRow.Cells[1].Value.ToString();
            person.phoneNumber = selectedRow.Cells[2].Value.ToString();
            person.address = selectedRow.Cells[3].Value.ToString();
            return person;
        }


        private void dataGridViewPhoneDirectory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {
                try
                {
                   
                    SelectedPerson = ViewToModel(dataGridViewPhoneDirectory.CurrentRow);
                    _unitOfWork.People.Add(SelectedPerson);
                    _unitOfWork.Complete(SelectedPerson);
                    dataGridViewPhoneDirectory.Rows.Add(new[] { "", "", "", "" });
                    dataGridViewPhoneDirectory.CurrentCell = dataGridViewPhoneDirectory.Rows[e.RowIndex + 1].Cells[1];


                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void dataGridViewPhoneDirectory_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridViewPhoneDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    SelectedPerson = ViewToModel(dataGridViewPhoneDirectory.CurrentRow);
                    _unitOfWork.People.Remove(SelectedPerson);
                    _unitOfWork.Complete(SelectedPerson);
                    dataGridViewPhoneDirectory.Rows.Remove(dataGridViewPhoneDirectory.CurrentRow);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            buttonAdd.FlatAppearance.MouseOverBackColor = buttonAdd.BackColor;
            buttonAdd.FlatAppearance.MouseDownBackColor = buttonAdd.BackColor;
            buttonAdd.BackColor = Color.Teal;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.BackgroundImage = Resources.add_user__1_;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Teal;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.BackgroundImage = Resources.add_user;
        }

        private void buttonAdd_MouseDown(object sender, MouseEventArgs e)
        {
            buttonAdd.BackgroundImage = Resources.add_user_press;
        }

        private void buttonAdd_MouseUp(object sender, MouseEventArgs e)
        {
            buttonAdd.BackgroundImage = Resources.add_user__1_;
            dataGridViewPhoneDirectory.Rows.Add(new[] {"", "", "", "" });
        }

        private void buttonSearch_MouseHover(object sender, EventArgs e)
        {
            buttonSearch.FlatAppearance.MouseOverBackColor = buttonSearch.BackColor;
            buttonSearch.FlatAppearance.MouseDownBackColor = buttonSearch.BackColor;
            buttonSearch.BackColor = Color.Teal;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Size = new Size(35, 35);
        }

        private void buttonSearch_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSearch.Size = new Size(25, 25);
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            buttonSearch.Size = new Size(30, 30);
        }

        private void buttonSearch_MouseUp(object sender, MouseEventArgs e)
        {
            buttonSearch.Size = new Size(35, 35);
        }

    }
}
