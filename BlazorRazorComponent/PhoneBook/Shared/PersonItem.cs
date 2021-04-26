using Microsoft.AspNetCore.Components;

namespace PhoneBook.Shared
{
    public partial class PersonItem
    {
        [Parameter]
        public int? EmpId { get; set; }
        [Parameter]
        public string FirstName { get; set; }
        [Parameter]
        public string LastName { get; set; }
        [Parameter]
        public string PhoneNumber { get; set; }

        string rowClass => "personRow";
        string textClass => "personData";
    }
}
