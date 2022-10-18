using RestClassControllerAndModel.Model;
using System.Collections.Generic;
using System.Threading;

namespace RestClassControllerAndModel.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int IdPerson;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public Person FindById(long id)
        {
            return new Person() { Id = 1, FirstName = "Person", LastName = "Last Name", Address = "Some Address", Gender = "Male" };
        }

        public List<Person> GetAll()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Interlocked.Increment(ref IdPerson);
                var person = new Person() { Id = IdPerson, FirstName = $"Person {IdPerson}", LastName = $"Last Name {IdPerson}", Address = $"Some Address {IdPerson}", Gender = i % 2 == 0 ? "Male" : "Female" };
                persons.Add(person);
            }
            return persons;
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
