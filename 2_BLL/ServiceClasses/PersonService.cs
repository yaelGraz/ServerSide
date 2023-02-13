using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Models;
using Repository.Interfaces;
using Server.Repository.Entities;

namespace Services.ServiceClasses
{
    public class PersonService : IBllService
    {
        private readonly IPersonDal dal;
        private readonly IMapper mapper;
        public PersonService(IPersonDal _dal, IMapper _mapper)
        {
            dal = _dal;
            mapper = _mapper;
        }
        public async Task<PersonModel> AddAsync(PersonModel model)
        {
            Person personToUpdate=mapper.Map<Person>(model); 
            PersonModel personToReturn = mapper.Map<PersonModel>(personToUpdate);
            dal.AddAsync(personToUpdate);
            return personToReturn;
        }

        public async Task DeleteAsync(string idNumber)
        {
            await dal.DeleteAsync(idNumber);   
        }

        public async Task<PersonModel> GetByIdNumberAsync(string idNumber)
        {
            Person returnedUser = await dal.GetByIdNumberAsync(idNumber);
            PersonModel userToReturn=mapper.Map<PersonModel>(returnedUser);
            return userToReturn; 
        }

        public async Task<ICollection<PersonModel>> GetAllAsync()
        {
            ICollection<Person> list = await dal.GetAllAsync();
            ICollection<PersonModel> listToReturn = new List<PersonModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<PersonModel>(item));
            }
            return listToReturn;
        }

        public async Task<PersonModel> UpdateAsync(PersonModel model)
        {
           Person userToUpdate=mapper.Map<Person>(model);
           PersonModel userToReturn=mapper.Map<PersonModel>(await dal.UpdateAsync(userToUpdate));
           return userToReturn;
        }
    }
}

