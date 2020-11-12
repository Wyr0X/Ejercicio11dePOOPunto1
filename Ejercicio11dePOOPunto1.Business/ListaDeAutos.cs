using Ejercicio11dePOOPunto1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ejercicio11dePOOPunto1.Business
{
    public class ListaDeAutos
    {
        private readonly List<Auto> Lista = new List<Auto>();

        private readonly string FilePath = Directory.GetCurrentDirectory() + "/datos.csv";

        public void Agregar(Auto auto)
        {
            // Sólo lo agrego si no existe
            if (Lista.IndexOf(auto) < 0)
            {
                Lista.Add(auto);
            }
        }

        public void Guardar()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Auto auto in Lista)
                {
                    writer.WriteLine(auto.ToString());
                }
            }
        }

        public void Leer()
        {
            // Si el archivo no existe, no cargo nada
            if (!File.Exists(FilePath)) return;

            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    string Linea = reader.ReadLine();
                    // El auto se carga a partir de un string
                    Lista.Add(new Auto(Linea));
                }
            }
        }

        public bool ExistePatente(string patente)
        {
            // Creo un auto temporal con esta patente para saber si existe
            int result = Lista.IndexOf(new Auto() { Patente = patente });

            // Si result es distinto a -1, entonces el auto (la patente) ya existe
            return result != -1;
        }

        public void Eliminar(Auto auto)
        {
            Lista.Remove(auto);
        }

        public List<Auto> GetLista()
        {
            return Lista;
        }

        public List<Auto> OrdenarPorPatente(bool Descendiente)
        {
            if (Descendiente)
            {
                return Lista.OrderByDescending(a => a.Patente).ToList();
            }
            else
            {
                return Lista.OrderBy(a => a.Patente).ToList();
            }
        }

        public List<Auto> OrdenarPorMarca(bool Descendiente)
        {
            if (Descendiente)
            {
                return Lista.OrderByDescending(a => a.Marca).ToList();
            }
            else
            {
                return Lista.OrderBy(a => a.Marca).ToList();
            }
        }

        public List<Auto> OrdenarPorAnio(bool Descendiente)
        {
            if (Descendiente)
            {
                return Lista.OrderByDescending(a => a.AnioDeFabricacion).ToList();
            }
            else
            {
                return Lista.OrderBy(a => a.AnioDeFabricacion).ToList();
            }
        }

        public List<Auto> FiltrarPorMarca(string filtro)
        {
            return Lista.Where(a => a.Marca.ToLower() == filtro.ToLower()).ToList();
        }

        public List<Auto> FiltrarPorColor(string filtro)
        {
            return Lista.Where(a => a.Color.ToLower() == filtro.ToLower()).ToList();
        }

        public List<Auto> FiltrarPorCombustible(EnumCombustible combustible)
        {
            return Lista.Where(a => a.Combustible == combustible).ToList();
        }

        public int GetCantidad()
        {
            return Lista.Count;
        }

        public int GetCantidadAPartirAnio(int anio)
        {
            return Lista.Where(a => a.AnioDeFabricacion >= anio).ToList().Count;
        }

        public int GetCantidadDeColor(string color)
        {
            return FiltrarPorColor(color).Count;
        }

        public int GetCantidadPatentesTerminaEn(string str)
        {
            return Lista.Where(a => a.Patente.EndsWith(str)).ToList().Count;
        }
    }
}
