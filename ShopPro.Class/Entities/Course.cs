using ShopPro.Class.Exceptions;
using System;
namespace ShopPro.Class.Entities
{
    public class Course
    {
        #region "Atributos"
        private int _CourseID;
        private string _Title;
        private int _Credits;
        private int _DepartmentID;
        private DateTime _CreationDate;
        private DateTime? _ModifyDate;
        private int _CreationUser;
        private int? _UserMod;
        private int? _UserDeleted;
        private DateTime? _datetime;
        private bool _Deleted;
        #endregion

        #region ""Propiedades"
     
        public int CourseID
        {
            get { return this ._CourseID; }
            set { this._CourseID = value; }

        }
        public string Title
        {
            get { return this._Title; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                
                    throw new CourseExceptions("La titulo es requerida");
                  if (value.Length > 100)
                    throw new CourseExceptions("La longitud del titulo es invalida");
                _Title = value;
            }
        }
        public int Credits
        {
            get { return this._Credits; }
            set
            {
               
            if (value <= 0)
                throw new CourseExceptions("Los creditos deben ser un valor positivo");
            _Credits = value;
            }
        }

    
        public int DepartmentID
        {
            get { return this._DepartmentID; }
            set { this._DepartmentID = value; }

        }
        public DateTime CreationDate
        {
            get { return this._CreationDate; }
            set { this._CreationDate = value; }

        }
        public DateTime? ModifyDate
        {
            get { return this._ModifyDate; }
            set { this._ModifyDate = value; }

        }
        public int CreationUser
        {
            get { return this._CreationUser; }
            set { this._CreationUser = value; }

        }
        public int? UserMod
        {
            get { return this._UserMod; }
            set { this._UserMod = value; }

        }
        public int? UserDeleted
        {
            get { return this._UserDeleted; }
            set { this._UserDeleted = value; }

        }
        public DateTime? datetime
        {
            get { return this._datetime; }
            set { this._datetime = value; }

        }
        public bool Deleted
        {
            get { return this._Deleted; }
            set { this._Deleted = value; }

        }

        #endregion



    }
}
