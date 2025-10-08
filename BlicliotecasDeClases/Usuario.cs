namespace BlicliotecasDeClases
{
    public class Usuario

    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public Equipo Pertenece { get; set; }
        public DateTime IncorporacionEmpresa { get; set; }

        public Usuario(string unNombre, string unApellido, string unaContrasena, string unEmail, Equipo unEquipo, DateTime fechaInicial)
        {
            Nombre = unNombre;
            Apellido = unApellido;
            Contrasena = unaContrasena;
            Email = unEmail;
            Pertenece = unEquipo;
            IncorporacionEmpresa = fechaInicial;

        }

        public override bool Equals(object obj)
        {
            return obj is Usuario unUsuario && unUsuario.Email == Email;
        }
    }
}



