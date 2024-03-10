using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net;
using System.Net.Mime;
using System.Text.Json;

namespace N_ForumApi.Middlewares
{
      static public class ConfigureExceptionHandlerExtension
    {
         public static void AddExceptionHandler(this WebApplication application)
        {
            application.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeature= context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature!=null)
                    {

                     await context.Response.WriteAsync(JsonSerializer.Serialize(new
                        {
                            StatusCode =context.Response.StatusCode,
                            Message=contextFeature.Error.Message,
                            Title="Hata alındı"
                        })); ;
                    }
                
                
                });


            });

        }

    }
}
