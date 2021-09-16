using System;

namespace UMLclases
{
    class Program
    {
        public class Vehiculo
        {
            string TipodeVehiculo;
            string Marca;
            int Añodelvehiculo;
            string Color;
            int TipodeCombustible;
            int Cilindraje;
            int Capacidad;
            string Placa;

        }

        public class Persona
        {
            string primerapellido;
            string segundoapellido;
            string nombres;
            bool cedulaciudadania;
            bool NIT;
            bool NN;
            bool pasaporte;
            bool cextrajera;
            bool tarjetaidentidad;
            bool nuip;
            bool diplomatico;
            int nodocumento;
            string direccion;
            string ciudad;
            int telefono;




        }


        public class Empresa
        {
            string Nombre;
            int NIT;
            string TipodeEmpresa;

        }

        public class Tramite 
        {
            int id;
            string tipodeservicio;
            string TipoDetramite;
            Persona Propietario;
            Persona Comprador;
            Empresa empresa;
            string TipoDePago;
            int ValorTramite;
            string Ciudad;
            Vehiculo vehiculo;

            public void hacerTramite() { }
        }


    }
}
