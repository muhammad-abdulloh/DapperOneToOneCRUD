using Dapper;
using DapperOneToOneCRUD.Data.Constants;
using DapperOneToOneCRUD.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOneToOneCRUD.Data.Repositories
{
    public class Repository : IRepository
    {
        public void Create(Person person)
        {
            string query = "INSERT INTO person (passportId, name, firstName, lastName) values " +
                            "(@passportId, @name, @firstName, @lastName)";


            using(var connection = new SqlConnection(Connects.CONNECTION_STRING))
            {
                var affectedRows = connection.Execute(query,
                    new
                    {
                        passportId = person.passportId,
                        name = person.name,
                        firstName = person.firstName,
                        lastName = person.lastName,
                    });

                Console.WriteLine("Succsessfully");
            }
        }



        public void Delete(int delId)
        {
            string sql = $"DELETE FROM Person WHERE id = {delId}";

            using (var connection = new SqlConnection(Connects.CONNECTION_STRING))
            {
                var affectedRows = connection.Execute(sql);

                Console.WriteLine("Sucsessfully");
            }
        }

        public IEnumerable<Person> GetAll()
        {
            string query = "SELECT * FROM Person";

            using (var connection = new SqlConnection(Connects.CONNECTION_STRING))
            {
                var personDetails = connection.Query<Person>(query);
                return personDetails;
            }
        }

        public void Update(int updateId, string name)
        {
            string sql = "UPDATE Person SET name = @name WHERE id = @id;";

            using (var connection = new SqlConnection(Connects.CONNECTION_STRING))
            {
                var affectedRows = connection.Execute(sql, new { id = updateId, name = name });

                Console.WriteLine("Update sucsessfully");
            }
        }
    }
}
