﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new [] { "a", "b" });
        }
    }
}
