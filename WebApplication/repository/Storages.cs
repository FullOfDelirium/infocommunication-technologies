using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domains;
using static System.Net.Mime.MediaTypeNames;
using WebApplication.repository;

namespace WebApplication.repository
{
    public class Storages
    {
        public static Storage<Human> HumanStorage { get; } = new();
    }
}


