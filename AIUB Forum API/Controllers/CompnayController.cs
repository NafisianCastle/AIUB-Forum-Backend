﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Entities;
using BLL.Services;

namespace AIUB_Forum_API.Controllers
{
    public class CompnayController : ApiController
    {

        [HttpGet]
        [Route("api/Company")]
        public HttpResponseMessage Get()
        {
            var cp = CompanyService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, cp);
        }

        [HttpGet]
        [Route("api/Company/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var cp = CompanyService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, cp);
        }

        [Route("api/Company/create")]
        [HttpPost]
        public HttpResponseMessage Create(CompanyModel company)
        {
            CompanyService.Add(company);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }

        [Route("api/Company/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(CompanyModel company)
        {
            CompanyService.Edit(company);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/Company/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            CompanyService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
