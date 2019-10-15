using System;

namespace Entities_POJO
{
    class PalabraEspannol
    {
        private string Palabra { get; set; }
        private int Popularidad { get; set; }

        public PalabraEspannol() { }
        public PalabraEspannol(string[] infoArray)
        {
            if(infoArray != null && infoArray.Length >= 2)
            {
                Palabra = infoArray[0];
                if (Int32.TryParse(infoArray[1], out int pop))
                    Popularidad = pop;
                else
                    throw new Exception("La popularidad debe ser un número.");
            }
            else
            {
                throw new Exception("La información solicitada es necesaria.");
            }
        }
    }
}
