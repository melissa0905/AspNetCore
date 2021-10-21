using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Contexts;
using AspNetCore.Entities;
using AspNetCore.Interfaces;

namespace AspNetCore.Repositories
{
    public class KategoriRepository: GenericRepository<Kategori>,IKategoriRepository
    {
    
    }
}
