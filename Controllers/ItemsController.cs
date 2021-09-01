using Microsoft.AspNetCore.Mvc;
using C_Web.Entities;
using C_Web.Repositories;
using System.Collections.Generic;
using System;

namespace C_Web.Entities
{
    [ApiController]
    [Route("api/Items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemoryRepository inMemoryrepository;

        public ItemsController()
        {
            this.inMemoryrepository = new InMemoryRepository();
        }
        [HttpGet]
        public IEnumerable<item> GetAllItems()
        {
            var items = this.inMemoryrepository.Getİtems();
            return items;
        }
        public ActionResult<item> GetItem(Guid id)
        {
            var item = this.inMemoryrepository.Getİtem(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

    }

}