﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Clave { get; set; }
        public string Mail { get; set; }
        public int Id_Rol { get; set; }
        public bool Activo { get; set; }
        public int? Codigo { get; set; }

        public static implicit operator UsuarioDto(Usuarios usuario)
        {
            var usuarioDto = new UsuarioDto();
            usuarioDto.Id = usuario.Id;
            usuarioDto.Nombre = usuario.Nombre;
            usuarioDto.Apellido = usuario.Apellido;
            usuarioDto.Fecha_Nacimiento = usuario.Fecha_Nacimiento;
            usuarioDto.Clave = usuario.Clave;
            usuarioDto.Mail = usuario.Mail;
            usuarioDto.Id_Rol = usuario.Id_Rol;
            usuarioDto.Activo = usuario.Activo;
            return usuarioDto;
        }
    }
}