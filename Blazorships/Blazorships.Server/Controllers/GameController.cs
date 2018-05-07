﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;

namespace Blazorships.Server.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private IMemoryCache _cache;
        public GameController(IMemoryCache cache)
        {
            _cache = cache;
        }
        [Route("updategame")]
        [HttpGet]
        public Game UpdateGame(string gameId) =>
            _cache.Get<List<Game>>("GameCacheKey").FirstOrDefault(_ => _.Id == gameId);

    }
}
