using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    [Table("Category")]
    public class Category {
        [Key] //id da classe tem relação com o id do banco
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //chave será gerada pelo banco
        public int Id { get; set; }

        [Required] //not null
        [MinLength(3)] 
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }

        [Required] //not null
        [MinLength(3)] 
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }

}