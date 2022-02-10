using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOneToOneCRUD.Data.IRepositories
{
    public interface IRepository
    {
        public void Create(Person person);
        public void Delete(int delId);
        public void Update(int updateId, string name);
        public IEnumerable<Person> GetAll();

    }
}
