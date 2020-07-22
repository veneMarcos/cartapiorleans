using System;
using System.Collections.Generic;
using System.Threading.Tasks;
// using GrainInterfaces;
// using GrainInterfaces.States;
using Microsoft.AspNetCore.Mvc;
using Orleans;

namespace Cart.Api.Controllers
{
    [Route("api/cart")]
    public class CartController : Controller
    {
        private readonly IClusterClient _client;

        public CartController(IClusterClient client)
        {
            _client = client;
        }

        //public async ValueTask
    }
}