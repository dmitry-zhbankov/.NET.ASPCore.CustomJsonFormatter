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
    public class ArticleController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public ArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/{controller}/{id}")]
        public Article Get(int id)
        {
            var article = _unitOfWork.ArticleRepository.GetById(id);
            return article;
        }
    }
}