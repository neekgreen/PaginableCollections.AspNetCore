﻿namespace PaginableCollections.AspNetCore
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class PaginableHeaderCondensedActionFilter : IAsyncActionFilter
    {
        async Task IAsyncActionFilter.OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await next();
        }
    }
}