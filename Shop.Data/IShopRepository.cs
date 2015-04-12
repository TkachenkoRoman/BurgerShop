using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public interface IShopRepository
    {
        IQueryable<Item> GetAllItems();
        Item GetItem(int itemId);
        bool Insert(Item item);
        bool Update(Item originalItem, Item updatedItem);
        bool Delete(int itemId);

        bool Insert(Orders order);

        bool SaveAll();
    }
}
