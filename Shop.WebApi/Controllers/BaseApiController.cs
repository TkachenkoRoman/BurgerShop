using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop.Data; 

namespace Shop.WebApi.Controllers
{
    public class BaseApiController : ApiController
    {
        private IShopRepository _repo;

        public BaseApiController(IShopRepository repo)
        {
            _repo = repo;
        }

        protected IShopRepository TheRepository
        {
            get
            {
                return _repo;
            }
        }
    }
}
