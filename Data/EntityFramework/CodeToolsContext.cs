using System;
using Microsoft.EntityFrameworkCore;
using CodeBaseWeb.Models;

namespace CodeBaseWeb.Data
{
    public class CodeToolsContext : DbContext
    {
        public CodeToolsContext(DbContextOptions<CodeToolsContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}