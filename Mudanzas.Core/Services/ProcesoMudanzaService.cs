using Mudanzas.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Mudanzas.Core.Services
{
    public class ProcesoMudanzaService : IProcesoMudanzaService
    {
        /// <summary>
        /// Procesa el archivo en base64, enviando a cada entidad la infomacion para ser analizada
        /// </summary>
        /// <param name="pArchivo64"></param>
        /// <param name="pCedula"></param>
        /// <returns></returns>
        public string ProcesarDatos(string pArchivo64, string pCedula)
        {
            string[] infoData;
            byte[] archivo = Convert.FromBase64String(pArchivo64.Split(",")[1]);
            UTF8Encoding temp = new UTF8Encoding(true);
            using (MemoryStream ms = new MemoryStream(archivo))
            {
                while (ms.Read(archivo, 0, archivo.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(archivo));
                    var array = temp.GetString(archivo).Split("\n");
                    infoData = array;
                }
            }

            return "";
        }
    }
}
