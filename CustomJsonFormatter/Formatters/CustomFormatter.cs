using CustomJsonFormatter.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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
                        context.ContentType = "application/json+custom";
                        var resArticle = new ArticleExtendedModel(article);
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
