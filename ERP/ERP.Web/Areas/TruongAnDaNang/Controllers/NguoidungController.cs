﻿using ERP.Web.Models.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Web.Areas.TruongAnDaNang.Controllers
{
    [AuthorizeBussiness]
    public class NguoidungController : Controller
    {
        // GET: TruongAnDaNang/Nguoidung
        public ActionResult Index()
        {
            return View();
        }
    }
}