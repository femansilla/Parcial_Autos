using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Auto
    {
        public Marca Marca { set; get; }
        public IList<Autoparte> Autopartes { set; get; }
    }

    public class AutoVM
    {
        public int Code { get; set; }
        public string Modelo { get; set; }
        public string Linea { get; set; }
        public int Date { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
    }
}
