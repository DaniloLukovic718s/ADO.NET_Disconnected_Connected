using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Drugi_Deo_DrugiDomaci_Domaci_MTPP
{
    public class EntityDataModel : DbContext
    {
        // Your context has been configured to use a 'EntityDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Drugi_Deo_DrugiDomaci_Domaci_MTPP.EntityDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EntityDataModel' 
        // connection string in the application configuration file.
        public EntityDataModel()
            : base("name=EntityDataModel1")
        {
        }

        public virtual DbSet<Klijent> klijent { get; set; }
        public virtual DbSet<Servis> servis { get; set; }

    }

    public class Klijent
    {

        [Key]
        [Required]
        public int klijentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite ime"), MaxLength(40)]
        public string nazivKlijenta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite registarski broj"), MaxLength(20)]
        public string registarskiBroj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite kontakt"), MaxLength(40)]
        public string Kontakt { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "Unesite dodatni komentar"), MaxLength(200)]
        public string dodatniKomentar { get; set; }

    }

    public class Servis
    {

        [Key]
        [Required]
        public int servisID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite klijenta")]
        public int klijentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite datum")]
        public DateTime datumServisa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unesite opis usluge"), MaxLength(400)]
        public string opisUsluge { get; set; }

    }


}