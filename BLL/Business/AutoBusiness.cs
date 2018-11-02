using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Services;
using BLL.Domain;

namespace BLL
{
    public class AutoBusiness
    {
        private static AutoServices _autoServices = new AutoServices();

        public IList<AutoVM> traerTodos() {
            return _autoServices.GetAllAutos();
        }

        public void agregar(Auto auto)
        {
            throw new NotImplementedException();
        }

        public void modificar(AutoVM auto)
        {
            throw new NotImplementedException();
        }

        public void eliminar(AutoVM auto)
        {
            _autoServices.DeleteAuto(auto.Code);
        }

        public IList<Auto> buscar(Criterio criterio)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(User user)
        {
            return _autoServices.ValidateUser(user.Usuario, user.Pass);
        }

        //public List<FiltroOptions> GetFiltrosDisponibles()
        //{
        //    FiltroOptions marca = new FiltroOptions() { Code = 1, Descripcion = "Marca" };
        //    FiltroOptions modelo = new FiltroOptions() { Code = 2, Descripcion = "Modelo" };
        //    FiltroOptions color = new FiltroOptions() { Code = 3, Descripcion = "Color" };
        //    List<FiltroOptions> ret = new List<FiltroOptions>();
        //    ret.Add(marca);
        //    ret.Add(modelo);
        //    ret.Add(color);
        //    return ret;
        //}
    }
}
