using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMarketWebAPI.Models
{
    [Table("tblCarBrand")]
    public class Carbrand
    {
        [Key]
        public int CarBrandID { get; set; } 
        public string? CarBrandName { get; set; }
    }

    [Table("tblCarBudget")]
    public class Carbudget
    {
        [Key]
        public int CarBudgetID { get; set; }
        public string? CarBudget { get; set; }
    }

    [Table("tblCarFuel")]
    public class Carfuel
    {
        [Key]
        public int CarFuelID { get; set; }
        public string? CarFuelType { get; set; }
    }

    [Table("tblCarKMDriven")]
    public class Carkmdriven
    {
        [Key]
        public int CarKMDrivenID { get; set; }
        public string? CarKMDriven { get; set; }
    }

    [Table("tblCarNoOfOwner")]
    public class Carnoofowner
    {
        [Key]
        public int CarNoOfOwnerID { get; set; }
        public string? CarNoOfOwnerType { get; set; }
    }

    [Table("tblState")]
    public class State
    {
        [Key]
        public int StateID { get; set; }
        public string? StateName { get; set; }
    }
}
