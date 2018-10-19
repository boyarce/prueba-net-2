using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class EmpleadoEntity
    {
        private string run_dv;
        private string nombres;
        private string apellido_pat;
        private string apellido_mat;
        private TipoEmpleadoEntity tipo_empleado;
        private decimal telefono;
        private decimal remuneracion_bruta;
        private DateTime fecha_nacimineto;

        public EmpleadoEntity() { }

        public string Run_dv { get => run_dv; set => run_dv = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellido_pat { get => apellido_pat; set => apellido_pat = value; }
        public string Apellido_mat { get => apellido_mat; set => apellido_mat = value; }
        public TipoEmpleadoEntity Tipo_empleado { get => tipo_empleado; set => tipo_empleado = value; }
        public decimal Telefono { get => telefono; set => telefono = value; }
        public decimal Remuneracion_bruta { get => remuneracion_bruta; set => remuneracion_bruta = value; }
        public DateTime Fecha_nacimineto { get => fecha_nacimineto; set => fecha_nacimineto = value; }
    }
}
