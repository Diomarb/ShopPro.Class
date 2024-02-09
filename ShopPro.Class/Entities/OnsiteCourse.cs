using ShopPro.Class.Exceptions;
using System;

namespace ShopPro.Class.Entities
{
    public class OnsiteCourse
    {
        #region"Atributos"
        private int _CourseID;
        private string _Location;
        private string _Days;
        private DateTime _Time;
        #endregion
        #region "Propiedades"
        

        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        public string Location
        {
            get { return _Location; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new OnsiteCourseExceptions("La Ubicacion es requerida");
                if (value.Length > 50)
                    throw new OnsiteCourseExceptions("La longitud de la ubicacion es invalida");
                _Location = value;
            }
        }
        public string Days
        {
            get { return _Days; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new OnsiteCourseExceptions("Los dias son requerida");
                if (value.Length > 50)
                    throw new OnsiteCourseExceptions("La longitud de los dias es invalida");
                _Location = value;
            }
        }
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        #endregion
    }
}
