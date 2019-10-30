using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SMARTgestion.Models
{
    public class HttpResponse
    {
        public string Content { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
