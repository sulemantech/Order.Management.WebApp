using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Management.WebApp.Data
{
    [Table("Suppliers")]
    public class Supplier
    {
        [Key]
        public int Supplierid { get; set; }
        [Required]
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine {get;set;}

        public string City { get; set; }    

        public string PostalCode { get; set; }

        public string State { get;set; }
    }
}
