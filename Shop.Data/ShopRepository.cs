using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data
{
    public class ShopRepository : IShopRepository
    {
        private BurgerShopEntities _ctx;
        public ShopRepository(BurgerShopEntities ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Item> GetAllItems()
        {
            return _ctx.Item.AsQueryable();
        }

        public Item GetItem(int itemId)
        {
            return _ctx.Item.Find(itemId);
        }

        public bool Insert(Item item)
        {
            try
            {
                _ctx.Item.Add(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Item originalItem, Item updatedItem)
        {
            _ctx.Entry(originalItem).CurrentValues.SetValues(updatedItem);
            return true;
        }

        public bool Delete(int itemId)
        {
            try
            {
                var entity = _ctx.Item.Find(itemId);
                if (entity != null)
                {
                    _ctx.Item.Remove(entity);
                    return true;
                }
            }
            catch
            {
                // TODO Logging
            }
            return false;
        }

        public bool Insert(Orders order)
        {
            try
            {
                _ctx.Orders.Add(order);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
