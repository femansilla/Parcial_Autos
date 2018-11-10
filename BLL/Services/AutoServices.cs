using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
    class AutoServices
    {
        private static DB _data = new DB();

        public IList<AutoVM> GetAllAutos()
        {
            List<AutoVM> retList = new List<AutoVM>();
            foreach (SP_Get_All_Autos_Result i in _data.SP_Get_All_Autos().ToList())
            {
                retList.Add(new AutoVM()
                {
                    Code = i.IdAuto,
                    Modelo = i.Modelo,
                    Linea = i.Linea,
                    Date = (int)i.Anio,
                    Color = i.Color,
                    Marca = i.Marca,
                });
            }
            return retList;
        }

        public void DeleteAuto(int autoCode)
        {
            _data.SP_Delete_Auto(autoCode);
        }

        internal bool ValidateUser(string usuario, string pass)
        {
            bool ret = (_data.SP_validateUser(usuario, pass).FirstOrDefault() == "true") ? true : false;
            return ret;
        }
    }
}
