using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MyService : IMyService
    {
        private readonly IConfiguration _configuracion;

        public MyService(IConfiguration configuracion)
        {
            _configuracion = configuracion;
        }
        public string Mensaje()
        {
            //return "Hola a todos";
            return _configuracion.GetConnectionString("cadenasql");
        }
    }
}
