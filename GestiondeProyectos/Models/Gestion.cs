using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestiondeProyectos.Models
{
    public class Gestion
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido_Paterno { get; set; }
        [Required]
        public string Apellido_Materno { get; set; }
        [Required]
        public string Nombre_proyecto { get; set; }
        [Required]
        public DateTime Tiempo { get; set; }
        [Required]
        public string Nombre_tareas{ get; set; }
        [Required]
        public string Rol_asignado { get; set; }
        [Required]
        public int Numero_actividades { get; set; }


    }

}