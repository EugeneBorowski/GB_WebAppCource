using AutoMapper;
using GB_WebAppCource.Controllers.Models;
using GB_WebAppCource.DAL.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using GB_WebAppCource.DAL.Entities;
using Task = System.Threading.Tasks.Task;

namespace GB_WebAppCource.Services
{
    public class PersonsService : IService<PersonDto>
    {
        private readonly IPersonsRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonsService(IPersonsRepository personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<PersonDto> Get(int id)
        {
            var person = await _personRepository.Get(id);
            return _mapper.Map<PersonDto>(person);
        }

        public async Task<PersonDto> Get(string term)
        {
            var person = await _personRepository.Get(term);
            return _mapper.Map<PersonDto>(person);
        }

        public async Task<IList<PersonDto>> Get(int from, int to)
        {
            var person = await _personRepository.Get(from, to);
            return _mapper.Map<List<PersonDto>>(person);
        }

        public async Task<IList<PersonDto>> GetAll()
        {
            var person = await _personRepository.GetAll();
            return _mapper.Map<List<PersonDto>>(person);
        }

        public async Task Create(PersonDto item)
        {
            await _personRepository.Add(_mapper.Map<Person>(item));
        }

        public async Task Update(PersonDto item)
        {
            var person = await _personRepository.Get(item.Id);
            {
                person.FirstName = item.FirstName;
                person.LastName = item.LastName;
                person.Email = item.Email;
                person.Age = item.Age;
                person.Email = item.Email;
                person.Company = item.Company;
            }
            await _personRepository.Update(person);
        }

        public async Task Delete(int id)
        {
            var person = await _personRepository.Get(id);
            await _personRepository.Delete(person);
        }
    }
}
