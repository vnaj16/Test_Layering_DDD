using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entities;
using Aplication;
using UI.Desktop.ViewModels;

namespace UI.Desktop.ApplicationController
{
    public class PersonaController
    {
        public IEnumerable<PersonaViewModel> GetPersonas(string Filter)
        {
            var Lista = new PersonaService().GetPersonas(Filter);
            List<PersonaViewModel> viewModel = new List<PersonaViewModel>();

            foreach (Persona x in Lista)
            {
                viewModel.Add(new PersonaViewModel
                {
                    ID = x.ID,
                    Nombre = x.Nombre,
                    Fecha_Nac = x.Fecha_Nac
                });
            }

            return viewModel;
        }
    }
}
