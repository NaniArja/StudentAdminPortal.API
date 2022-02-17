using System;

namespace StudentAdminPortal.API.DataModels
{
    public class Address
    {
        public Guid id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        //Navigation property
        public Guid StudentId { get; set; }
    }
}
