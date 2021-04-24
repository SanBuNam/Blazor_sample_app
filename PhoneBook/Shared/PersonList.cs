using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using PhoneBook.Model;

namespace PhoneBook.Shared
{
    public partial class PersonList
    {
        [Parameter]
        public IList<Person> People { get; set; }

        void OnNewPerson(int? empId, string firstName, string lastName, string phoneNumber)
        {
            if (People != null)
            {
                People.Add(new Person { EmpId = empId, FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber });
                StateHasChanged();
            }
        }

        void OnDeletePerson(int? empId)
        {
            if (People != null)
            {
                var deletingPerson = People.Where(x => x.EmpId == empId).FirstOrDefault();
                People.Remove(deletingPerson);
                StateHasChanged();
            }
        }

        void OnEditPerson(int? empId, string firstName, string lastName, string phoneNumber)
        {
            if (People != null)
            {
                var editingPerson = People.Where(x => x.EmpId == empId).FirstOrDefault();
                editingPerson.FirstName = firstName;
                editingPerson.LastName = lastName;
                editingPerson.PhoneNumber = phoneNumber;
                StateHasChanged();
            }
        }
    }
}
