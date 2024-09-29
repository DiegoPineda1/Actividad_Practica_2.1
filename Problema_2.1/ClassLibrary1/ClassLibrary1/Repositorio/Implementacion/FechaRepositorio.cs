using ClassLibrary1.Identidades;
using ClassLibrary1.Repositorio.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.Repositorio.Implementacion
{
    public class FechaRepositorio : IFechaRepositorio
    {
        private Fecha fechas;
        public FechaRepositorio(Fecha fecha)
        {
            fechas = fecha;
        }
        public DateTime ObtenerFecha()
        {
            return fechas.fechaHoy;
        }
    }
}
