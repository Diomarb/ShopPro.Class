using ShopPro.Class.Exceptions;
using System;

namespace ShopPro.Class.Entities
{
    public class OnlineCourse
    {
        #region"Atributos"
        private int _CourseID;
        private string _URL;
        #endregion


        #region"Propiedades"
        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        public string URL
        {
            get { return _URL; }
         set  {
                if (string.IsNullOrEmpty(value))

                    throw new OnlineCourseExceptions("La URL es requerida");
                if (value.Length > 100)
                    throw new OnlineCourseExceptions("La longitud de la URL es invalida");
                _URL = value;
            }
        }

        #endregion

    }
}
