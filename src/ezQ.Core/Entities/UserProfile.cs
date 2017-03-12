namespace ezQ.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserProfile
    {
        public int Id { get; set; }

        public string AddressStreet { get; set; }

        public string AddressCity { get; set; }

        public string AddressProvState { get; set; }

        public string AddressPostZip { get; set; }

        public string AddressCountry { get; set; }

        public string ContactEmail { get; set; }

        public string ContactTelephone { get; set; }

        public string ContactOthers { get; set; }
    }
}
