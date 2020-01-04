using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomJsonFormatter.Controllers
{
    public class ProfileController : Controller
    {
        IUnitOfWork unitOfWork;
        public ProfileController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public Author Index(int id)
        {
            var author= unitOfWork.AuthorRepository.GetById(id);
            return author;
        }
    }
}