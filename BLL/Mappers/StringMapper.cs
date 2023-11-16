using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class StringMapper
    {
        public static TextViewModel ToViewModel(this TextForm form)
        {
            return new TextViewModel { Message = form.Message };
        }
    }
}
