using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models;
namespace Services.Interfaces
{
    public interface IBllService : IBLL<PersonModel>
    {
        Task<ICollection<PersonModel>> GetAllAsync();
        Task<PersonModel> GetByIdNumberAsync(string idNumber);
        Task<PersonModel> AddAsync(PersonModel model);
        Task<PersonModel> UpdateAsync(PersonModel model);
        Task DeleteAsync(string idNumber);
    }
}
