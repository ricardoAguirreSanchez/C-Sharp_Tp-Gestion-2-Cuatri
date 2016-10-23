using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ClinicaFrba.Properties;


namespace ClinicaFrba
{
    //esta clase servira para poder manejar mejor los datos q tenenmos en el appconfig
    //1.- el host va a estar expresado en el appconfig como STRING
    //2.- la fecha va a estar en el appconfig como STRING, luego se convertira a datetime para usarlo
    class AppConfig
    {
        public  String obtenerHost()
        {
            return Settings.Default.GD2C2016ConnectionString;
        }

        public String obtenerFecha()
        {
            return ConfigurationManager.AppSettings["fecha"]; 
        }
    }
}
