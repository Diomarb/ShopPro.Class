using System;

namespace ShopPro.Class.Entities
{
    public class CourseInstructor
    {
        #region "Atributos"
        private int _CourseID;
        private int _PersonID;

        #endregion

        #region "Propiedades"
        
        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }
        }

        #endregion
    }
}
