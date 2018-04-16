using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PageHitCount.Controllers
{
    public class PageHitCountController : ApiController
    {
        private static int _count;
        //GET api/pagehitcount/
        [HttpGet]
        public int Get()
        {
            try
            {
                return ++_count;
            }
            catch (Exception ex)
            {
                return 0;//ToDo: for now returning zero. If works properly I ll send the meaningful http response
            }
        }
    }
}
