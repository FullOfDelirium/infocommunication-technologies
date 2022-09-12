using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using WebApplication.Domains;

namespace WebApplication.repository
{
    public interface IStorageID
    {
        public int ID { get; set; }
    }
}
