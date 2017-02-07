using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly.Models;
using MembershipType = Vidly.Migrations.MembershipType;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public List<Models.MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                return Customer.Id != 0 ? "Edit Customer" : "New Customer";
            }
        }

    }
}