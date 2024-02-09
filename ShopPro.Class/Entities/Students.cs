using ShopPro.Class.Exceptions;
using System;


namespace ShopPro.Class.Entities
{
    public class Students
    {
        #region "Atributos"
        private int _Id;
        private string _LastName;
        private string _FirstName;
        private DateTime? _EnrollmenDate;
        private DateTime _CreationDate;
        private DateTime? _ModifyDate;
        private int _CreationUser;
        private int? _UserMod;
        private int? _UserDeleted;
        private DateTime? _DeletedDate;
        private bool _Deleted;
        #endregion

        #region"Propiedades"
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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
        public DateTime? EnrollmenDate
        {
            get { return _EnrollmenDate; }
            set { _EnrollmenDate = value; }
        }
        public DateTime CreationDate
        {
            get { return _CreationDate; }
            set { _CreationDate = value; }
        }
        public DateTime? ModifyDate
        {
            get { return _ModifyDate; }
            set { _ModifyDate = value; }
        }
        public int CreationUser
        {
            get { return _CreationUser; }
            set { _CreationUser = value; }
        }
        public int? UserMod
        {
            get { return _UserMod; }
            set { _UserMod = value; }
        }
        public int? UserDeleted
        {
            get { return _UserDeleted; }
            set { _UserDeleted = value; }
        }
        public DateTime? DeletedDate
        {
            get { return _DeletedDate; }
            set { _DeletedDate = value; }
        }
        public bool Deleted
        {
            get { return Deleted; }
            set { Deleted = value; }
        }
        #endregion
    }
}
