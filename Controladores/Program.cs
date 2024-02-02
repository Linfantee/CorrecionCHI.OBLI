using CorrecionCHI.OBLI.Servicios;
using System;

namespace CorrecionCHI.OBLI;

    class Program
    {
        static void Main(string[] args)
        {

        MensajeInterfaz mensaje = new MensajeImplementacion();

        mensaje.resultado();
        }
    }
