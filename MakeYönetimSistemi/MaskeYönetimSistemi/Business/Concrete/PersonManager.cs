using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        // encapsulation  person öğerisin başka yerde tanımladım yani yazdığım kodun daha sistematik olması için
        public void ApplyForMask(Person Person)
        {
            Person person = new Person();
        }

        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
