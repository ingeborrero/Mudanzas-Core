using System;
using System.Collections.Generic;
using System.Text;

namespace Mudanzas.Core.Interfaces
{
    public interface IProcesoMudanzaService
    {
        string ProcesarDatos(string pArchivo64, string cedula);
    }
}
