using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace UI.Views
{
    public interface IPoneDirectoryView
    {
        Person SelectedPerson { get; set; }
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);
    }
}
