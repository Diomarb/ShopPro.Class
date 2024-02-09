using ShopPro.Class.Exceptions;
using System;


namespace ShopPro.Class.Entities
{
    public class Department
    {
        #region"Atributos"

        private int _DepartmentID;
        private string _Name;
        private decimal _Budget;
        private DateTime _StartDate;
        private int? _Administrator;
        private DateTime _CreationDate;
        private DateTime? _ModifyDate;
        private int _CreationUser;
        private int? _UserMod;
        private int? _UserDeleted;
        private DateTime? _DeletedDate;
        private bool _Deleted;


        #endregion
        #region"Propiedades"
        
        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new DepartmentExceptions("El nombre  es requerido");
                if (value.Length > 50)
                    throw new DepartmentExceptions("La longitud del nombre es invalida");
                _Name = value;
            }
        }
        public decimal Budget
        {
            get { return _Budget; }
            set {  
                if (value < 0)
                throw new DepartmentExceptions("El presupuesto tiene que ser un valor positivo");
            _Budget = value;
            }
        }
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public int? Administrator
        {
            get { return _Administrator; }
            set { _Administrator = value; }
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
            get { return _Deleted; }
            set { _Deleted = value; }
        }
        #endregion
    }
}
