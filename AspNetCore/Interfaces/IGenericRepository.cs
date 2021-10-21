using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Interfaces
{
    public interface IGenericRepository<Tablo> where Tablo : class, new()
    {
        void Add(Tablo tablo);
        void Update(Tablo tablo);
        void Delete(Tablo tablo);
        public List<Tablo> GetAll();
        public Tablo GetAllId(int id);



    }

}
