using System.ComponentModel.DataAnnotations;

namespace proyectoFinal.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }

        public int IdPaciente { get; set; }

        public string Doctor { get; set; } = "Doctor General";

        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public string Motivo { get; set; }
        public string Estado { get; set; } = "Pendiente";
    }
}
