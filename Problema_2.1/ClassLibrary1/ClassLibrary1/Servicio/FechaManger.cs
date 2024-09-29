using ClassLibrary1.Repositorio.Implementacion;
using ClassLibrary1.Repositorio.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Servicio
{
    public class FechaManger : IManager
    {
        private IFechaRepositorio fechaRepositorio;
        public FechaManger(IFechaRepositorio fechaRepositorio)
        {
            this.fechaRepositorio = fechaRepositorio;
        }

        public DateTime ObtenerFecha()
        {
            return fechaRepositorio.ObtenerFecha();
        }
    }
}
