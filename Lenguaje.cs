using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LYA1_Sintaxis1
{
    public class Lenguaje : Sintaxis
    {
        public Lenguaje()
        {

        }
        public Lenguaje(string nombre) : base(nombre)
        {

        }
        //Programa  -> Librerias? Variables? Main
        public void Programa()
        {
            if (getContenido() == "#")
            {
                Librerias();
            }
            if (getClasificacion() == Tipos.TipoDatos)
            {
                Variables();
            }
            Main();
        }
        //Librerias -> #include<identificador(.h)?> Librerias?
        private void Librerias()
        {
            match("#");
            match("include");
            match("<");
            match(Tipos.Identificador);
            if (getContenido() == ".")
            {
                match(".");
                match("h");
            }
            match(">");  // nextToken
            if (getContenido() == "#")
            {
                Librerias();
            }

        }
        //Variables -> tipo_dato Lista_identificadores; Variables?
        private void Variables()
        {

        }
        //listaIdentificadores -> identificador (,listaIdentificadores)?
        private void listaIdentificadores()
        {

        }
        //Bloque de instrucciones -> {lista de intrucciones?}
        private void bloqueInstrucciones()
        {
            match("{");
            if (getContenido() != "}")
            {
                ListaInstrucciones();
            }
            match("}");
        }
        //ListaInstrucciones -> Instruccion ListaInstrucciones?
        private void ListaInstrucciones()
        {
            Instruccion();
            if(getContenido() != "}")
            {
                ListaInstrucciones();
            }
        }
        //Instruccion -> Printf | Scanf | If | While | do while | For | Switch | Asignacion
        private void Instruccion()
        {

        }
        //Asignacion -> identificador = cadena | Expresion;
        private void Asignacion()
        {

        }
        //While -> while(Condicion) bloque de instrucciones | instruccion
        private void While()
        {

        }
        //Do -> do bloque de instrucciones | intruccion while(Condicion)
        private void Do()
        {

        }
        //For -> for(Asignacion Condicion; Incremento) Bloque de instruccones | Intruccion 
        private void For()
        {

        }
        //Incremento -> Identificador ++ | --
        private void Incremento()
        {

        }
        //Condicion -> Expresion operador relacional Expresion
        private void Condicion()
        {

        }
        //If -> if(Condicion) bloque de instrucciones (else bloque de instrucciones)?
        private void If()
        {

        }
        //Printf -> printf(cadena);
        private void Printf()
        {

        }
        //Scanf -> scanf(cadena);
        private void Scanf()
        {

        }
        //Main      -> void main() Bloque de instrucciones
        private void Main()
        {
            match("void");
            match("main");
            match("(");
            match(")");
            bloqueInstrucciones();

        }
        //Expresion -> Termino MasTermino
        private void Expresion()
        {

        }
        //MasTermino -> (OperadorTermino Termino)?
        private void MasTermino()
        {

        }
        //Termino -> Factor PorFactor
        private void Termino()
        {

        }
        //PorFactor -> (OperadorFactor Factor)?
        private void PorFactor()
        {

        }
        //Factor -> numero | identificador | (Expresion)
        private void Factor()
        {

        }
    }
}