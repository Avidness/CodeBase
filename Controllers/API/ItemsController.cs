using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeBaseWeb.Models;
using CodeBaseWeb.Data;

namespace CodeBaseWeb.Controllers 
{
    [Route ("api/[controller]")]
    public class ItemsController : Controller {
        private readonly IItemRepository _items;

        public ItemsController (IItemRepository items) {
            _items = items;
        }

        [HttpGet ("[action]")]
        public async Task<IEnumerable<Item>> List () {
            return await _items.GetAll();
        }
    }
}