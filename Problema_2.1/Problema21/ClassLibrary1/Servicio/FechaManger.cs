using BackFecha.Repositorio.Implementacion;
using BackFecha.Repositorio.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackFecha.Servicio
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
