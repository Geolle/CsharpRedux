using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redux
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class ActionAttribute : FilterAttribute, IActionFilter
    {

        public string Type { get; set; }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var result = filterContext.Result as ViewResultBase;
            var model = result.Model;

            dis

            //var model = result.Model;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var result = filterContext.Result;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class ReducerAttribute : FilterAttribute, IActionFilter
    {

        public int Reducer { get; set; }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var result = filterContext.Result as ViewResultBase;
            var model = result.Model;

            //var model = result.Model;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var result = filterContext.Result;
        }
    }
}