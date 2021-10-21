using AspNetCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AspNetCore.TagHelpers
{
    [HtmlTargetElement("getirKategoriAd")]
    public class KategoriAd:TagHelper
    {
        private readonly IUrunRepository _urunRepository;
         
        public KategoriAd(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;

        }
       
    }
}
