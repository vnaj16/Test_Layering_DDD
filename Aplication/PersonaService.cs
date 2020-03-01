using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Abstractions;
using Domain.Models.Entities;
using Infra.DataAccess.Repository;

namespace Aplication
{
    public class PersonaService
    {
        readonly IPersonaRepository personaRepository;

        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }

        public IEnumerable<Persona> GetPersonas(string Filter)
        {
            return personaRepository.GetPersonas(Filter);
        }
    }
}
