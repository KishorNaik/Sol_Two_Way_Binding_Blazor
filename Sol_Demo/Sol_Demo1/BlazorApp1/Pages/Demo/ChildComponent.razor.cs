using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages.Demo
{
    public partial class ChildComponent
    {
        #region Method 1

        private string _firstName = null;

        [Parameter]
        public String FirstName
        {
            get => this._firstName;
            set
            {
                if (_firstName == value) return;
                _firstName = value;
                if (FirstNameChanged.HasDelegate)
                {
                    FirstNameChanged.InvokeAsync(value);
                }
            }
        }

        [Parameter]
        public EventCallback<String> FirstNameChanged { get; set; }

        #endregion Method 1

        #region Method 2

        [Parameter]
        public String LastName { get; set; }

        [Parameter]
        public EventCallback<String> LastNameChanged { get; set; }

        private void OnLastNameTextBoxChangedEventHandler(ChangeEventArgs e)
        {
            this.LastName = e.Value.ToString();
            LastNameChanged.InvokeAsync(this.LastName);
        }

        #endregion Method 2
    }
}