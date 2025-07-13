using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace apitesting.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var hasAuthHeader = context.HttpContext.Request.Headers.TryGetValue("Authorization", out var authHeader);

            if (!hasAuthHeader)
            {
                context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
                return;
            }

            if (!authHeader.ToString().Contains("Bearer"))
            {
                context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
                return;
            }

            base.OnActionExecuting(context); // proceed if valid
        }
    }
}
