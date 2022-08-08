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
            using(var context = new BlogDataContext()){
                // ADICIONAR

                // var tag1 = new Tag {Name="ASP.NET", Slug="aspnet"};
                // context.Tags.Add(tag1);
                // context.SaveChanges();

                // var tag2 = new Tag {Name=".NET", Slug="dotnet"};
                // context.Tags.Add(tag2);
                // context.SaveChanges();
                
                /*********************************************************/
                // ATUALIZAR

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                /*********************************************************/
                // REMOVER
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

                // context.Remove(tag);
                // context.SaveChanges();

                /*********************************************************/
                // var tags = context
                //     .Tags
                //     .Where(x => x.Name.Contains(".NET"))
                //     .ToList();

                // foreach(var tag in tags){
                //     Console.WriteLine(tag.Name);
                // }

                var tag = context
                    .Tags
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == 3);

                Console.WriteLine(tag?.Name);
            }
        }
    }
}
