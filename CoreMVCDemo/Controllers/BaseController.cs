using GoC.WebTemplate.Components.Core.Services;
using GoC.WebTemplate.CoreMVC.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDemo.Controllers
{
    public class BaseController : WebTemplateBaseController
    {
        public BaseController(ModelAccessor modelAccessor)
            : base(modelAccessor) { }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            WebTemplateModel.ApplicationTitle.Text = "Custom Demo App";
            WebTemplateModel.Breadcrumbs.Insert(0,
                new GoC.WebTemplate.Components.Entities.Breadcrumb
                {
                    Title = "Canada.ca",
                    Href = "canada.ca"
                });
            WebTemplateModel.Breadcrumbs.Insert(1,
                new GoC.WebTemplate.Components.Entities.Breadcrumb
                {
                    Title = "Custom Demo App",
                    Href = "/"
                });
            base.OnActionExecuted(context);
        }

    }
}
