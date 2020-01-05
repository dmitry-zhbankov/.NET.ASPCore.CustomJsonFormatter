using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomJsonFormatter.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomJsonFormatter.Controllers
{
    [ApiController]
    public class ProfileController : Controller
    {
        IUnitOfWork unitOfWork;
        public ProfileController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/{controller}/{id}")]
        public Author Get(int id)
        {
            var author= unitOfWork.AuthorRepository.GetById(id);
            return author;
        }
    }
}