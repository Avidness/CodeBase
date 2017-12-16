using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeBaseWeb.Models;

namespace CodeBaseWeb.Data
{
    public interface IItemRepository
    {
         void Add(Item i);
         void Remove(Item i);
         Task<IEnumerable<Item>> GetAll();
    }
}