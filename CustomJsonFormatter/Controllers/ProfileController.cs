using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomJsonFormatter.DAL;
using CustomJsonFormatter.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomJsonFormatter.Controllers
{
    [ApiController]
    public class ProfileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public ProfileController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/{controller}/{id}")]
        public Author Get(int id)
        {
            var author= _unitOfWork.AuthorRepository.GetById(id);
            return author;
        }
    }
}