using MVCFilters_2.DesignPatterns.SingletonPattern;
using MVCFilters_2.Models.Context;
using MVCFilters_2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters_2.Filters
{
    public class ResFilter : FilterAttribute, IResultFilter
    {


        MyContext _db;

        public ResFilter()
        {
            _db = DBTool.DBInstance;
        }


        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log logger = new Log();
            if (filterContext.HttpContext.Session["oturum"] == null) logger.UserName = "Anonim kullanıcı";
            else logger.UserName = (filterContext.HttpContext.Session["oturum"] as AppUser).UserName;
            logger.ActionName = filterContext.RouteData.Values["Action"].ToString();
            logger.ControllerName = filterContext.RouteData.Values["Controller"].ToString();
            logger.Description = Keyword.Entry;
            logger.Information = "Sayfa render edilmek üzere";
            _db.Logs.Add(logger);
            _db.SaveChanges();
        }
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log logger = new Log();
            if (filterContext.HttpContext.Session["oturum"] == null) logger.UserName = "Anonim kullanıcı";
            else logger.UserName = (filterContext.HttpContext.Session["oturum"] as AppUser).UserName;
            logger.ActionName = filterContext.RouteData.Values["Action"].ToString();
            logger.ControllerName = filterContext.RouteData.Values["Controller"].ToString();
            logger.Description = Keyword.Exit;
            logger.Information = "Sayfa render edildi";
            _db.Logs.Add(logger);
            _db.SaveChanges();
        }

       
    }
}