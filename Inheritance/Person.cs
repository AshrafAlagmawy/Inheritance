using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The Goal Of Inheritance

1. Code Reusability:
    Inheritance allows the reuse of code from a superclass, minimizing redundancy and promoting efficient development.

2. Extension of Functionality:
    Subclasses can extend or customize the functionality of the superclass, enabling the creation of specialized classes.

3. Polymorphism:
    Inherited classes can be treated interchangeably with their superclass, providing a flexible and generalized programming approach.

4. Maintenance and Updates:
    Changes to the superclass are automatically reflected in all subclasses, simplifying maintenance and updates across related classes.
*/

namespace Inheritance
{
    internal abstract class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly BirthDate { get; private set; }
        public void SetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invalid Name");
            FirstName = firstName;
            LastName = lastName;
        }
        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1986, 9, 17))
                throw new ArgumentException("Invalid Birth Date");
            BirthDate = birthDate;
        }
    }
}
