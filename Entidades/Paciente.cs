using System.Text;

namespace Entidades
{
    public class Paciente : Persona
    {
        string diagnostico;
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia):base(nombre, apellido, nacimiento,barrioResidencia)
        {

        }

        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }
            set
            {
                diagnostico = value;
            }
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new();
            sb.AppendLine(FichaPersonal(this));
            sb.AppendLine($"Reside en {barrioResidencia}");
            sb.AppendLine(Diagnostico);
            return sb.ToString();
        }
    }
}
