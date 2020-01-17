using System;
using System.Security.Policy;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomJsonFormatter.Models
{
    public class ArticleLinkModel
    {
        public string Self { get; set; }

        public string Author { get; set; }
    }
}