using ShopPro.Class.Exceptions;
using System;
namespace ShopPro.Class.Entities
{
    public class OfficeAssignment
    {
        #region "Atributos"
        private int _InstructorId;
        private string _Location;
        private byte[] _Timestamp;
        #endregion
        #region"Propiedades"
        

        public int InstructorId
        {
            get { return _InstructorId; }
            set { _InstructorId = value; }
        }

        public string Location
        {
            get { return _Location; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new OfficeAssignmentExceptions("La ubicaion  es requerido");
                if (value.Length > 50)
                    throw new OfficeAssignmentExceptions("La longitud de la ubicacion  es invalida");

                _Location = value;
            }
        }
        public byte[] Timestamp
        {
            get { return _Timestamp; }
            set { _Timestamp = value; }
        }
        #endregion



    }
}
