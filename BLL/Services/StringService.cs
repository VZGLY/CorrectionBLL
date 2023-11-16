using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StringService : IStringService
    {
        public TextViewModel Capitalize(TextForm input)
        {
            input.Message = input.Message.ToUpper();
            return input.ToViewModel();
        }
    }
}
