namespace usuarioproyecto
{
    class Usuario
    {
        public string Nombre { get; }
        public int Edad { get; }
        public string Correo { get; }

        public Usuario(string nombre, int edad, string correo)
        {
            Nombre = nombre;
            Edad = edad;
            Correo = correo;
        }
    }
}