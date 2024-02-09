

namespace ShopPro.Class.Exceptions
{
   public class CourseInstructorExceptions : Exception
    {
        public CourseInstructorExceptions(string message) : base(message)
        {
            SaveError(message);

        }
        void SaveError(string message)
        {
            //Logica para guardar el error en la base de datos y tambien
            //enviar el correo por el correo//

        }


    }
}
