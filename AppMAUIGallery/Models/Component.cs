using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Models
{
    internal class Component
    {
        public string Title { get; set; } // Nome do componente
        public string Description { get; set; } // Descrição do componente
        public Type Page { get; set; } // Página do componente
    }
}
