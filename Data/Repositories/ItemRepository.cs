using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CodeBaseWeb.Models;
using CodeBaseWeb.Data;

namespace CodeBaseWeb.Data
{
    public class ItemRepository : IItemRepository
    {
        private readonly CodeToolsContext _context;

        public ItemRepository (CodeToolsContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetAll () {
            return await _context.Items.ToListAsync();
        }

        public void Add(Item item){
            throw new NotImplementedException();
        }

        public void Remove(Item item){
            throw new NotImplementedException();
        }
    }
}