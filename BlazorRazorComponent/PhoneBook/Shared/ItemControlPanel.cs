using System;
using Microsoft.AspNetCore.Components;

namespace PhoneBook.Shared
{
    public partial class ItemControlPanel
    {
        int? EmpId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }

        int? DltEmpId { get; set; }

        int? EditEmpId { get; set; }
        string EditFirstName { get; set; }
        string EditLastName { get; set; }
        string EditPhoneNumber { get; set; }

        string buttonDisabled => (FirstName != null && FirstName.Length > 0
                       && LastName != null && LastName.Length > 0
                       && PhoneNumber != null && PhoneNumber.Length > 0) ? null : "disabled";

        [Parameter]
        public Action<int?, string, string, string> OnNewPerson { get; set; }
        void NewPerson()
        {
            if (OnNewPerson != null)
            {
                OnNewPerson(EmpId, FirstName, LastName, PhoneNumber);
                EmpId = null;
                FirstName = "";
                LastName = "";
                PhoneNumber = "";
            }
        }

        [Parameter]
        public Action<int?, string, string, string> OnEditPerson { get; set; }
        void EditPerson()
        {
            if (OnEditPerson != null)
            {
                OnEditPerson(EditEmpId, EditFirstName, EditLastName, EditPhoneNumber);
                EditEmpId = null;
                EditFirstName = "";
                EditLastName = "";
                EditPhoneNumber = "";
            }
        }

        [Parameter]
        public Action<int?> OnDeletePerson { get; set; }
        void DeletePerson()
        {
            if (OnDeletePerson != null)
            {
                OnDeletePerson(DltEmpId);
                DltEmpId = null;
            }
        }
    }
}
