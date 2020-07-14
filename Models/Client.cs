using System.ComponentModel.DataAnnotations;

namespace WebAppMvc2.Models
{
    public class Client
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage = "Merci de saisir le nom")]
        [MaxLength(60), MinLength(1)]
        public string nom { get; set; }
        [Required]
        [MaxLength(60), MinLength(1)]
        public string prenom { get; set; }
        [Required]
        public string email { get; set; }
        public string address { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }

        public Client()
        {
        }

        public Client(int id, string nom, string prenom, string email, string address, string cp, string ville)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.address = address;
            this.cp = cp;
            this.ville = ville;
        }
    }
}