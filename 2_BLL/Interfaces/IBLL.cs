using Server.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBLL<T>
    {
        //Implements CRUD
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdNumberAsync(string idNumber); 
        Task<T> AddAsync(T model); Task<T> UpdateAsync(T model);
        Task DeleteAsync(string idNumber);
    }
}
