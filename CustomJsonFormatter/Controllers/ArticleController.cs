﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomJsonFormatter.Controllers
{
    public class ArticleController : Controller
    {
        IUnitOfWork unitOfWork;
        public ArticleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("api/{controller}/{id}")]
        public Article Get(int id)
        {
            var article = unitOfWork.ArticleRepository.GetById(id);
            return article;
        }
    }
}