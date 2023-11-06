using BoulevardResidence.Domain.Entity.Apartments;
using BoulevardResidence.Service.DTOs.Aparments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulevardResidence.Service.Interfaces
{
    public interface IApartmentService
    {
        Task CreateApartment(CreateApartmentDto createApartmentDto);
        Task<List<Apartment>> GetAllAsync();
        List<string> GetBuildings();
        List<int> GetFloors();
        List<int> GetRooms();
        List<string> GetFloorAreas();
        Task<Apartment> GetFullDataByIdAsync(int? id);
        Task<List<Apartment>> GetFilteredApartmentsAsync(string buildingFilter, int? roomFilter, /*string featuresFilter,*/ int? floorFilter, string floorAreaFilter);
    }
}
