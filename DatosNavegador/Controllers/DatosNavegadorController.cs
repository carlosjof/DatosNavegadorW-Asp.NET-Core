using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UAParser;

namespace DatosNavegador.Controllers
{

    /// <summary>
    /// Para obtener los datos de forma especifica necesitamos agregar la libreria ua_parser
    /// Install-Package UAParser -Version 3.1.36
    /// 
    /// https://github.com/ua-parser/uap-csharp
    /// </summary>

    public class DatosNavegadorController : Controller
    {

        private IHttpContextAccessor _accessor;

        public DatosNavegadorController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        // GET: DatosNavegador
        public ActionResult Index()
        {
            //tomamos el string de los datos.
            string userAgent = Request.Headers["User-Agent"];

            var uaParser = Parser.GetDefault();

            ClientInfo clientInfo = uaParser.Parse(userAgent);

            ///Major => Version de Navegador


            //Datos Navegador
            ViewBag.BrowserFamily = clientInfo.UserAgent.Family;
            ViewBag.BrowserMajor = clientInfo.UserAgent.Major;

            //Datos Sistema Operativo
            ViewBag.OSFamily = clientInfo.OS.Family;
            ViewBag.OSMajor = clientInfo.OS.Major;

            //Datos Dispositivo
            ViewBag.DeviceFamily = clientInfo.Device.Family;
            ViewBag.DeviceModel = clientInfo.Device.Model;

            //IP
            ViewBag.IP = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();

            //Nombre del usuario que inicio sesion en la maquina
            ViewBag.UserPC = Environment.UserName;



            return View();
        }

    }
}