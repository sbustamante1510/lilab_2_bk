using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Roles;

namespace Domain.Usuarios;

public class Usuarios : Entity
{
    public string? nombre_usuario {  get; private set; }

    public CorreoValidator? correo_usuario { get; private set;}

    public string? contrasenia_usuario { get; private set;}

    public Rol? roles { get; private set; }

    public int? rol_usuario { get; private set;}

    public bool? estado_usuario {  get; private set;}
}
