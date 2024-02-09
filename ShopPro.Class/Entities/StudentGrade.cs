using ShopPro.Class.Exceptions;
using System;


namespace ShopPro.Class.Entities
{
    public class StudentGrade
    {
        #region"Atributos"
        private int _EnrollmentID;
        private int _CourseID;
        private int _StudentID;
        private decimal? _Grade;
        #endregion
        #region"Propiedades"

        public int EnrollmentID
        {
            get { return _EnrollmentID; }
            set
            {

                if (value <= 0)
                    throw new PersonExceptions("El Id de la inscripcio tiene que ser mayor que cero");

                _EnrollmentID = value;
            }
        }
        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        public int StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        public decimal? Grade
        {
            get { return _Grade; }
            set
            {


                if (value < 0 || value > 100)
                    throw new PersonExceptions("La calificacion debe ser del 0 al 100");
                _Grade = value;
            }
            #endregion
        }
    }
}



