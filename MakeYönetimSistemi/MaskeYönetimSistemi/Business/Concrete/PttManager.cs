using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Concrete
{
    class PttManager
    {
        private IApplicantService _applicantService;
        private ForeignerManager foreignerManager;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        

        public void GiveMask()
        {
            
            Person person = new Person();
            PersonManager personmamger = new PersonManager();
            if (personmamger.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için Maske Verildi");
            }
        }
    }
}
