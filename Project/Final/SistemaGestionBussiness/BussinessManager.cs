using System.Data.SqlClient;

namespace SistemaGestionBussiness
{
    public static class BussinessManager
    {
        private static string _connection;

        static BussinessManager()
        {
        }
        public static string SetConnection()
        {
            _connection = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True;";
            return _connection;
        }



    }

    /*En esta ocasion solo revise lo contenido dentro de la carpeta DB. 
 * Como comentario, te puedo remocomendar separar la conexion a la BD de las consultas, 
 * ya sea creando una nueva clase estatica que haga esto o en caso que tus clases sean de instancia a 
 * traves de herencia. De esta manera en caso de ser necesario modificar la forma de conectarse a la 
 * BD solo se deberia de tocar 1 unico archivo. 
 * En tu entrega te ves obligado a gestionar 4.*/
}
