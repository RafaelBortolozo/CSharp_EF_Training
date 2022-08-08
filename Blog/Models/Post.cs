using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{
    [Table("Post")]
    public class Post {
        [Key] //id da classe tem relação com o id do banco
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //chave será gerada pelo banco
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")] // Category | Id (classe category, propriedade id)
        public int CategoryId { get; set; }
        public Category Category { get; set; } // propriedade para inner join

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}