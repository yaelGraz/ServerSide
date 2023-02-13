using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
using Server.Repository;
using Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Repository.Repositories
{
    public class PersonDal : IPersonDal
    {
        IDataSource dataSource;
        public PersonDal(IDataSource data)
        {
            dataSource = data;
        }
        public async Task<ICollection<Person>> GetAllAsync ()
        {
            return await dataSource.Persons.ToListAsync();
        }
        public async Task<Person> GetByIdNumberAsync(string idNumber)
        {
            return await dataSource.Persons.FirstOrDefaultAsync(u => u.PersonId == idNumber);
        }
        public async Task<Person> AddAsync(Person model)
        {
            EntityEntry<Person> personToReturn = dataSource.Persons.Add(model);
            dataSource.SaveChangesAsync();
            return personToReturn.Entity;
        }
        public async Task<Person> UpdateAsync(Person model)
        {
            var entity= dataSource.Persons.Update(model);
            await dataSource.SaveChangesAsync();
            return entity.Entity;
        }
        public async Task DeleteAsync(string idNumber)
        {
            dataSource.Persons.Remove(dataSource.Persons.FirstOrDefault(p => p.PersonId == idNumber));
            await dataSource.SaveChangesAsync();   
        }

        Task<Person> IPersonDal.GetByIdNumberAsync(string id)
        {
            throw new NotImplementedException();
        }

       

     
    }
}

