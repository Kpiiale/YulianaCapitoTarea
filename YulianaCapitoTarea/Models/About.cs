using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YulianaCapitoTarea.Models
{
    class About
    {
        public string Title => "Yuliana Capito";
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "Tengo 20 años, estoy en quinto semestre, mis hobbies son leer, jugar videojuegos y dibujar";
        public string Image => "yo.jpg";

    }
}
