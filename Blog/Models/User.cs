using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models {
    [Table("User")]
    public class User {
        [Key] //id da classe tem relação com o id do banco
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //chave será gerada pelo banco
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        
    }
}