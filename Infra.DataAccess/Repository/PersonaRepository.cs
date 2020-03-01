using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Abstractions;
using Domain.Models.Entities;

namespace Infra.DataAccess.Repository
{
    public class PersonaRepository : ConnectionSQL, IPersonaRepository
    {
        public int Add(Persona persona)
        {
            throw new NotImplementedException();
        }

        public int Edit(Persona persona)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> GetPersonas(string Filter)
        {
            SqlDataReader Reader;
            List<Persona> Lista = new List<Persona>();//ESTA LISTA GENERICA (PUEDE SER DICCIONARIO) SIRVE PARA TRANSFERIR LOS DATOS A TRAVES DE COMPONENTES DEL MISMO SISTEMA
            //PARA TRANSFERIR DATOS FUERA DEL SISTEMA (A OTROS SISTEMAS O INTERNET) SE PUEDE USAR SERIALIZACION XML, JSON o Nativa
            try
            {
                Conexion.Open();

                //Con esa consulta puedo buscar por filtro, poner un textbox donde ponga el ID o nombre para buscar su similitud
                SqlCommand Comando = new SqlCommand("SELECT * FROM Persona WHERE ID LIKE @Condicion+'%' or Nombre like @Condicion+'%'", Conexion);

                //Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Condicion", Filter);



                Reader = Comando.ExecuteReader();



                while (Reader.Read())
                {
                    Lista.Add(new Persona
                    {
                        ID = Reader.GetInt32(0),
                        Nombre = Reader.GetString(1),
                        Fecha_Nac= Reader.GetDateTime(2)
                    }); 
                }

                Reader.Close();
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {

                Conexion.Close();
            }

            return Lista.AsEnumerable<Persona>();
        }

        public int Remove(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
