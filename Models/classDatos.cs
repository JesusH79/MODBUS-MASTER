using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace MODBUS_MASTER.Models
{
    public static class classDatos
    {

        public static string IPSlave {get;set;}

        //Para formulario FC05
        public static string direccionFC05 { get; set; }

        //para formulario FC06
        public static string direccionFC06 { get; set; }
        public static string valorFC06 { get; set; }

        //para formulario FC04
        public static string direccionFC04 { get; set; }

        //para formulario FC02
        public static string direccionFC02 { get; set; }

        //para formulario FC15
        public static string direccionFC15 { get; set; }
        public static string noCoilsFC15 { get; set; }

        //para formulario FC16
        public static string direccionFC16 { get; set; }
        public static string noRegistrosFC16 { get; set; }
    }
    
}
