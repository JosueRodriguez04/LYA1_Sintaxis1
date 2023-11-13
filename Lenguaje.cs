using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    Requerimiento 1: Printf -> printf(cadena(, Identificador)?);
    Requerimiento 2: Scanf -> scanf(cadena,&Identificador);
*/

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
            match(">");
            if (getContenido() == "#")
            {
                Librerias();
            }
        }
        //Variables -> tipoDato listaIdentificadores; Variables?
        private void Variables()
        {
            match(Tipos.TipoDatos);
            listaIdentificadores();
            match(";");
            if (getClasificacion() == Tipos.TipoDatos)
            {
                Variables();
            }
        }
        //listaIdentificadores -> Identificador (,listaIdentificadores)?
        private void listaIdentificadores()
        {
            match(Tipos.Identificador);
            if (getContenido() == ",")
            {
                match(",");
                listaIdentificadores();
            }
        }
        //bloqueInstrucciones -> { listaIntrucciones? }
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
            if (getContenido() != "}")
            {
                ListaInstrucciones();
            }
        }
        //Instruccion -> Printf | Scanf | If | While | do while | For | Asignacion
        private void Instruccion()
        {
            if (getContenido() == "printf")
            {
                Printf();
            }
            else if (getContenido() == "scanf")
            {
                Scanf();
            }
            else if (getContenido() == "if")
            {
                If();
            }
            else if (getContenido() == "while")
            {
                While();
            }
            else if (getContenido() == "do")
            {
                Do();
            }
            else if (getContenido() == "for")
            {
                For();
            }
            else
            {
                Asignacion();
            }
        }
        //Printf -> printf(cadena);
        private void Printf()
        {
            match("printf");
            match("(");
            match(Tipos.Cadena);
            match(")");
            match(";");
        }
        //Scanf -> scanf(cadena);
        private void Scanf()
        {
            match("scanf");
            match("(");
            match(Tipos.Cadena);
            match(")");
            match(";");
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
        //Main      -> void main() bloqueInstrucciones
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