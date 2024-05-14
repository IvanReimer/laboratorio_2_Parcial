namespace Entidades
{
    public class Consulta
    {
        Paciente paciente;
        DateTime fecha;

        public Consulta(Paciente paciente, DateTime fecha)
        {
            this.paciente = paciente;
            this.fecha = fecha;
        }
        public Paciente Paciente { get => paciente;  }
        public DateTime Fecha { get => fecha; }

        public override string ToString()
        {
            return $"{Fecha} se ha atendido a {Paciente.NombreCompleto}";
        }
        
    }
}
