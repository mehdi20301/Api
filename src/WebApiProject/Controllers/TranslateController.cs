using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataModel.Data.Context;
using DataModel.Data.Model;
using DataModel.UnitOfWork.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using WebApiProject.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class TranslateController : Controller
    {

        public ITranslateService TranselateService;
        public TranslateController(WebApiDBContext context)
        {
            //_UnitOfWork = new DataModel.UnitOfWork.Classes.UnitOfWorkClass(context);
            TranselateService = new WebApiProject.Services.CLasses.TranslateService(context);
        }
        // GET: api/values
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            //var result = _UnitOfWork.TranslateRepository.GetAll();
            return Json( new string[] { "value1", "value2" });
        }

        // GET api/values/5
        [HttpGet("{question}")]
        public async Task<IActionResult> Get(string question)
        {
            return Json(TranselateService.GetTranslate(question));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Newtonsoft.Json.Linq.JObject data)
        {
            TranselateService.Insert(new Translate() {Question = data["question"].ToString() , Answer= data["answer"].ToString() , Format = data["format"].ToString() });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
