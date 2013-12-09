﻿using System.Net;
using System.Web;

namespace Aranasoft.Cobweb.Web.Mvc {
    public class HttpNotFoundException : HttpException {
        public HttpNotFoundException(string reason) : base((int) HttpStatusCode.NotFound, reason) {}
    }
}
