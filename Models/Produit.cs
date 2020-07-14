using System.ComponentModel.DataAnnotations;

namespace WebAppMvc2.Models
{
    public class Produit
    {
        [Key]
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Reference { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public double prix { get; set; }

        public Produit()
        {
        }

        public Produit(int id, string reference, string description, string imageUrl, double prix)
        {
            this.id = id;
            Reference = reference;
            Description = description;
            this.imageUrl = imageUrl;
            this.prix = prix;
        }
    }
}