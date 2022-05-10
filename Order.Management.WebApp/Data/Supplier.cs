using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Management.WebApp.Data
{
    [Table("Suppliers")]
    public class Supplier : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Supplierid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        [Required]
        public string AddressLine {get;set;}
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public State State { get; set; }

        public int StateId { get; set; }

    }
}
