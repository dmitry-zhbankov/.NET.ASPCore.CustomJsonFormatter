using CustomJsonFormatter.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CustomJsonFormatter.Controllers;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Mvc.TagHelpers;


namespace CustomJsonFormatter.Formatters
{
    public class CustomFormatter : OutputFormatter
    {
        public CustomFormatter()
        {
            SupportedMediaTypes.Add("application/json");
            SupportedMediaTypes.Add("application/json+custom");
        }

        protected override bool CanWriteType(Type type)
        {
            return type == typeof(Article)||type==typeof(Author);
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {
            var response = context.HttpContext.Response;
            if (context.ObjectType == typeof(Article))
            {
                var article = context.Object as Article;
                switch (context.HttpContext.Request.ContentType)
                {
                    case "application/json":
                    case null:
                    {
                        var resArticle=new ArticleModel(article);
                        var res= JsonSerializer.Serialize(resArticle);
                        await response.WriteAsync(res);
                        break;
                    }
                    case "application/json+custom":
                    {
                        var resArticle = new ArticleExtendedModel(article);
                        var baseUrl = context.HttpContext.Request.Host;
                        var scheme = context.HttpContext.Request.Scheme;
                        resArticle.Link.Self = @$"{scheme}://{baseUrl}{context.HttpContext.Request.Path}";
                            resArticle.Link.Author =
                            @$"{scheme}://{baseUrl}/api/profile/{resArticle.Data.AuthorId}";

                        var res = JsonSerializer.Serialize(resArticle);
                        await response.WriteAsync(res);
                        break;
                    }
                }
            }

            if (context.ObjectType==typeof(Author))
            {
                var profile = context.Object as Article;
                var res = JsonSerializer.Serialize(profile);
                await response.WriteAsync(res);
            }

            await WriteAsync(context);
        }
    }
}
