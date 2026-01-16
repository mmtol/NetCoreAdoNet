using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Models
{
    public  class Hospital
    {
        public int IdHospital { get; set; }
        public string NombreHospital { get; set; }
        public string DireccionHospital { get; set; }
        public string TelefonoHospital { get; set; }
        public int NumeroCamas { get; set; }
    }
}
