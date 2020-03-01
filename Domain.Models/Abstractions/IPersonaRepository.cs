using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Abstractions
{
    public interface IPersonaRepository
    {
        int Add(Persona persona);
        int Edit(Persona persona);
        int Remove(Persona persona);

        IEnumerable<Persona> GetPersonas(string Filter);
    }
}
