﻿using System;

namespace Entities_POJO
{
    public class Lenguaje : BaseEntity
    {
        private string Id { get; set; }
        private string Name { get; set; }

        public Lenguaje() { }
        public Lenguaje(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 2)
            {
                Id = infoArray[0];
                Name = infoArray[1];
            }
            else
            {
                throw new Exception("Todos los valores son requeridos. [Id,Name]");
            }
        }
    }
}