using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using WebApplication.Domains;
namespace WebApplication.repository
{
    public class Storage<TIdentifier> where TIdentifier : IStorageID
    {
        private static readonly string Path = typeof(TIdentifier).Name + "Storage.xml";
        private List<TIdentifier> storage = new();


        public Storage() { }

        public void LoadFromStorage()
        {
            if (!File.Exists(Path)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(Path, FileMode.Open);
            storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public void SaveToStorage()
        {
            if (!File.Exists(Path)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(Path, FileMode.Open);
            storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public bool Create(TIdentifier obj)
        {
            if (storage.Any(t => t.ID == obj.ID))
                return false;
            storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int ID)
        {
            return storage.FirstOrDefault(t => t.ID == ID);
        }

        public TIdentifier Update(int iD, TIdentifier obj)
        {
            var index = storage.FindIndex(t => t.ID == obj.ID);
            if (index == -1)
                Create(obj);
            else
                storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID)
        {
            return storage.RemoveAll(t => t.ID == objID) != 0;
        }
    }
}
