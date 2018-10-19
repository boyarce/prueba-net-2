using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao.entity;
using Persistencia.NUMEROUNODataSetTableAdapters;

namespace Persistencia.dao.impl
{
    public class EmpleadoDAOImpl : EmpleadoDAO
    {
        private EMPLEADOTableAdapter adapter;

        public EmpleadoDAOImpl() { adapter = new EMPLEADOTableAdapter(); }

        public void create(EmpleadoEntity empleado)
        {
            adapter.Insert(empleado.Run_dv, empleado.Nombres, empleado.Apellido_pat, empleado.Apellido_mat,
                empleado.Tipo_empleado.Codigo, empleado.Telefono, empleado.Remuneracion_bruta, empleado.Fecha_nacimineto);
        }

        public void delete(EmpleadoEntity empleado)
        {
            adapter.DeleteByRun(empleado.Run_dv);
        }

        public List<EmpleadoEntity> findAll()
        {
            List<EmpleadoEntity> empleados = new List<EmpleadoEntity>();

            foreach (NUMEROUNODataSet.EMPLEADORow row in adapter.GetData().Rows)
            {
                EmpleadoEntity empleado = new EmpleadoEntity();
                empleado.Run_dv = row.RUN_DV;
                empleado.Nombres = row.NOMBRES;
                empleado.Apellido_pat = row.APELLIDO_PAT;
                empleado.Apellido_mat = row.APELLIDO_MAT;
                empleado.Tipo_empleado.Codigo = row.TIPO_EMPLEADO_ID;
                empleado.Telefono = row.TELEFONO;
                empleado.Remuneracion_bruta = row.REMUNERACION_BRUTA;
                empleado.Fecha_nacimineto = row.FECHA_NACIMIENTO;
                empleados.Add(empleado);
            }

            return empleados;
        }

        public EmpleadoEntity findByRun(string run)
        {
            throw new NotImplementedException();
        }

        public void update(EmpleadoEntity empleado)
        {
            adapter.UpdateQuery(empleado.Run_dv, empleado.Nombres, empleado.Apellido_pat, empleado.Apellido_mat, empleado.Tipo_empleado.Codigo, empleado.Telefono, empleado.Remuneracion_bruta, empleado.Fecha_nacimineto);
        }
    }
}
