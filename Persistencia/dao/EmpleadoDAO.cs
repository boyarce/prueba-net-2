using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface EmpleadoDAO
    {

        void create(EmpleadoEntity empleado);

        void update(EmpleadoEntity empleado);

        void delete(EmpleadoEntity empleado);

        EmpleadoEntity findByRun(string run);

        List<EmpleadoEntity> findAll();
    }
}
