using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace apitesting.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var logPath = "Logs"; // Log folder

            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            var logFile = Path.Combine(logPath, "exceptions.txt");

            File.AppendAllText(logFile,
                $"[{DateTime.Now}] {exception.Message}{Environment.NewLine}{exception.StackTrace}{Environment.NewLine}{Environment.NewLine}");

            context.Result = new ObjectResult("An unexpected error occurred. Please contact support.")
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
