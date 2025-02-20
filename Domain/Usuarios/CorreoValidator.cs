using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Usuarios;

public record CorreoValidator
{
    public string Value { get; init; }

    private CorreoValidator(string value)
    {
        Value = value;
    }

    public static bool EsCorreoValido(string value)
    {
        const string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }
        var esCorreoValido = Regex.Match(value, emailRegex).Success;
        return esCorreoValido;
    }
}
