using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages.Demo
{
    public partial class ParentComponent
    {
        public ParentComponent()
        {
            CustomerM = new CustomerModel();
        }

        private CustomerModel CustomerM { get; set; }

        private void OnSubmit()
        {
            string firstName = CustomerM.FirstName;
            string lastName = CustomerM.LastName;
        }
    }
}