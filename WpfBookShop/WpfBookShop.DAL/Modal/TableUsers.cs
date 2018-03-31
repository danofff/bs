namespace WpfBookShop.DAL.Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TableUsers
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(150)]
        public string Login { get; set; }

        [StringLength(150)]
        public string Password { get; set; }

        [StringLength(150)]
        public string lName { get; set; }
        [StringLength(150)]
        public string fName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public int CityId { get; set; }

    }
}
