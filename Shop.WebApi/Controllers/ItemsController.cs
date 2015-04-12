using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop.Data;
using Shop.Data.Models;

namespace Shop.WebApi.Controllers
{
    public class ItemsController : BaseApiController
    {
        public ItemsController(IShopRepository repo)
            :base(repo)
        {
        }

        public IEnumerable<Item> Get()
        {
            IQueryable<Item> query;

            query = TheRepository.GetAllItems();

            return query.ToList();
        }

        public HttpResponseMessage GetItem(int id)
        {
            try
            {
                var item = TheRepository.GetItem(id);
                if (item != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, item);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
