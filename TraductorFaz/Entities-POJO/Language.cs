using System;

namespace Entities_POJO
{
    public class Language : BaseEntity
    {
        private string Id { get; set; }
        private string Name { get; set; }

        public Language() { }
        public Language(string[] infoArray)
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
