namespace WpfBookShop.DAL.Modal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableCity")]
    public partial class TableCity
    {
        [Key]
        public int CityId { get; set; }

        public string CityName { get; set; }
    }
}
