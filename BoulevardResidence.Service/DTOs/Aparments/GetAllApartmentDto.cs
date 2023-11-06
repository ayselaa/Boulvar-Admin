using BoulevardResidence.Domain.Entity.Apartments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulevardResidence.Service.DTOs.Aparments
{
    public class GetAllApartmentDto
    {
        public List<Apartment> Apartments { get; set; }

        public string LangCode { get; set; }
    }
}
