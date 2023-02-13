using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
namespace Repository.Interfaces
{
    public interface IPersonDal : IDal<Person>
    {
        Task<ICollection<Person>> GetAllAsync();
        Task<Person> GetByIdNumberAsync(string id);
        Task<Person> AddAsync(Person model);
        Task<Person> UpdateAsync(Person model);
        Task DeleteAsync(string idNumber);
    }
}
