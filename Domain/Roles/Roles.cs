using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Roles;

public class Rol : Entity
{
    public string descripcion_rol {  get; private set; }
}
