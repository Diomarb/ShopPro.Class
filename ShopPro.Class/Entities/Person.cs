using ShopPro.Class.Exceptions;
using System;


namespace ShopPro.Class.Entities
{
    public class Person
    {
        #region"Atributos"
        private int _PersonID;
        private string _LastName;
        private string _FirstName;
        private DateTime? _HireDate;
        private DateTime? _EnrollmentDate;
        private string _Discriminator;

        #endregion
        #region"Propiedades"
        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new PersonExceptions("El Apellido  es requerido");
                if (value.Length > 50)
                    throw new PersonExceptions("La longitud del Apellido  es invalida");

                _LastName = value;
            }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new InstructorsExceptions("El nombre del instructor es requerido");
                if (value.Length > 50)
                    throw new InstructorsExceptions("La longitud del nombre del instructor es invalida");

                _FirstName = value;
            }
        }
        public DateTime? HireDate
        {
            get { return _HireDate; }
            set { _HireDate = value; }
        }
        public DateTime? EnrollmentDate
        {
            get { return _EnrollmentDate; }
            set { _EnrollmentDate = value; }
        }
        public string Discriminator
        {
            get { return _Discriminator; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new PersonExceptions("El discriminador es requerido");
                if (value.Length > 50)
                    throw new PersonExceptions("La longitud del discriminador es invalida");

                _Discriminator = value;
            }
        }



        #endregion
    }
}
