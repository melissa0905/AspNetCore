using AspNetCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Repositories
{
    public class GenericRepository<Tablo> where Tablo : class, new()
    {
        public void Add(Tablo tablo)
        {
            using var context = new YoutubeContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();

        }
        public void Update(Tablo tablo)
        {
            using var context = new YoutubeContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();

        }
        public void Delete(Tablo tablo)
        {
            using var context = new YoutubeContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();

        }
        public List<Tablo> GetAll()
        {
            using var context = new YoutubeContext();
            return context.Set<Tablo>().ToList();

        }
        public Tablo GetAllId(int id)
        {
            using var context = new YoutubeContext();
            return context.Set<Tablo>().Find(id);
        }

    }
   
}
