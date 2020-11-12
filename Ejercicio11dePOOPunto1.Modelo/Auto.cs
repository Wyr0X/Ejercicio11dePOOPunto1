using System;

namespace Ejercicio11dePOOPunto1.Model
{
    public class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public EnumCombustible Combustible { get; set; }
        public int AnioDeFabricacion { get; set; }

        // Constructor que acepta un string con los datos separados por comas
        public Auto(string DatosCSV)
        {
            string[] Datos = DatosCSV.Split(',');
            Patente = Datos[0];
            Marca = Datos[1];
            Modelo = Datos[2];
            Color = Datos[3];
            Combustible = (EnumCombustible)Enum.Parse(typeof(EnumCombustible), Datos[4]);
            AnioDeFabricacion = int.Parse(Datos[5]);
        }

        // Constructor vacío
        public Auto() {}

        public int GetAntiguedad()
        {
            return DateTime.Now.Year - AnioDeFabricacion;
        }

        public override string ToString()
        {
            return $"{Patente},{Marca},{Modelo},{Color},{Combustible},{AnioDeFabricacion}";
        }

        // Comparo la patente
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Auto a = (Auto)obj;

                return Patente.Equals(a.Patente);
            }
        }

        // Devuelvo el hash de la patente
        public override int GetHashCode()
        {
            return Patente.GetHashCode();
        }
    }
}
