using System.Text;

namespace Entidades
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;
        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente):base(nombre, apellido, nacimiento)
        {
            consultas = new List<Consulta>();
            this.esResidente= esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new();
            sb.AppendLine(FichaPersonal(this));
            sb.AppendLine(esResidente ? "SI" : "NO");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }
            return sb.ToString();
        }
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente )
        {
            Consulta consulta = new Consulta(paciente, DateTime.Now);
            doctor.consultas.Add(consulta);
            return consulta;
        }
    }
}
