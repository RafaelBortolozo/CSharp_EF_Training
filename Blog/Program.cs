using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // var user = new User{
            //     Name = "Rafael Bortolozo",
            //     Slug = "rafaelbortolozo",
            //     Email = "rafaelbortolozo@outlook.com",
            //     Bio = "joão ninguem",
            //     Image = "https://bortobe.com",
            //     PasswordHash = "senhaforte123"
            // };

            // var category = new Category{
            //     Name = "Backend",
            //     Slug = "backend",
            // };

            // var post = new Post{
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "Comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF Core",
            //     Title = "Começando com Ef Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();


            /***************************************************************************/
            //IMPRIMINDO

            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author) //innerjoin
            //     .Include(x => x.Category) //innerjoin
            //     //.ThenInclude(x => x.) //subselect
            //     .OrderByDescending(x => x.LastUpdateDate)
            //     .ToList();

            // foreach(var post in posts){
            //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
            // }

            /***************************************************************************/
            // ATUALIZANDO 
            // Mesmo o nome do autor não estando na tabela "posts", foi feito 
            // o innerjoin com aquela tabela de usuarios e portanto permitindo 
            // com que o nome do autor fosse alterado pela query do post

            var post = context
                .Posts
                .Include(x => x.Author) 
                .Include(x => x.Category) 
                .OrderByDescending(x => x.LastUpdateDate)
                .FirstOrDefault();

            post.Author.Name = "Teste";
            context.Posts.Update(post);
            context.SaveChanges();
        }
    }
}
