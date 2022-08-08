﻿using System;
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

            var user = new User{
                Name = "Rafael Bortolozo",
                Slug = "rafaelbortolozo",
                Email = "rafaelbortolozo@outlook.com",
                Bio = "joão ninguem",
                Image = "https://bortobe.com",
                PasswordHash = "senhaforte123"
            };

            var category = new Category{
                Name = "Backend",
                Slug = "backend",
            };

            var post = new Post{
                Author = user,
                Category = category,
                Body = "<p>Hello world</p>",
                Slug = "Comecando-com-ef-core",
                Summary = "Neste artigo vamos aprender EF Core",
                Title = "Começando com Ef Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
