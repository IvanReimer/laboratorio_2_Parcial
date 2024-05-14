using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected DateTime nacimiento;
        protected string barrioResidencia;

        protected Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        protected Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia): this(nombre, apellido , nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(this.nacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto
        {
            get
            {
                return ToString();
            }
        }
        public override string ToString()
        {
            return $"{apellido}, {nombre}";
        }

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new();
            sb.AppendLine(p.NombreCompleto);
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine($"Barrio residencia: {p.barrioResidencia}");
            return sb.ToString();
        }
        internal abstract string FichaExtra();


    }
}