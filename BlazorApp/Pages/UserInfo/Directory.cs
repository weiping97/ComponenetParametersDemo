using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.UserInfo
{
    public partial class Directory
    {
        public List<PersonModel> People { get; set; }
        public Directory()
        {
            People = new List<PersonModel>
        {
            new PersonModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        AddressType = "Home Address",
                        StreetAddress = "123 Oak Street",
                        City = "Scranton",
                        State = "PA",
                        ZipCode = "18512"
                    },
                    new AddressModel
                    {
                        AddressType = "Vacation Home",
                        StreetAddress = "101 Beachfront Ave",
                        City = "Miami",
                        State = "FL",
                        ZipCode = "25412"
                    }
                }
            },
            new PersonModel
            {
                FirstName = "Bob",
                LastName = "Smith",
                Addresses = new List<AddressModel>()

            },
            new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm",
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        AddressType = "Home Address",
                        StreetAddress = "115 Justice Way",
                        City = "LA",
                        State = "CA",
                        ZipCode = "88547"
                    }
                }
            }
        };
        }
    }
}
