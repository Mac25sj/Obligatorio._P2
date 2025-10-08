using BlicliotecasDeClases;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Sistema
{

private List<Equipo> equipos = new List<Equipo>();
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Pago> pagos = new List<Pago>();


    //Inicio Alta Usuario
    public void altaUsuario(string nombre, string apellido, string contrasena, Equipo pertenece, DateTime incorporacionEmpresa)
    {
        if (nombre == null ||apellido == null ||contrasena == null || pertenece == null )
            {
            throw new Exception("Campo vacio detectado");

        }
        string email = crearEmail(nombre, apellido, pertenece.Nombre);
        Usuario nuevoUsuario = new Usuario(nombre, apellido, contrasena, email, pertenece, incorporacionEmpresa);
        if (usuarios.Contains(nuevoUsuario))
        {
            int posicion = nuevoUsuario.Email.IndexOf("@") - 1;
            nuevoUsuario.Email = nuevoUsuario.Email.Insert(posicion, "7");
        }

        usuarios.Add(nuevoUsuario);
    }
    //Inicio Alta Usuario


    //Alta de Pago Inicio


    //Alta de Pago Inicio Fin 



    //Listar Pagos Inicio

    public List <Pago> ListarGastosEnElMes()
    {
        List<Pago> resultado = new List<Pago>();

        foreach (Pago unPago in pagos)
        {
           if (unPago is Unico)
            {
                Unico pagoUnico = (Unico)unPago;
                if (pagoEsteMes(pagoUnico.FechaDePago))
                {
                    resultado.Add(pagoUnico);
                }

            }else
            {
                resultado.Add(unPago);  
            }
        }
        return resultado;
    }

    //Listar Pagos Fin


       





    //Crear Email
    public string crearEmail(string nombre, string apellido, string nombreEquipo)
    {
        string resultado = "";
        for (int i = 0; i < 3; i++)
        {
            if (nombre.Length >= i)
            {
                resultado += nombre[i];
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (apellido.Length >= i)
            {
                resultado += apellido[i];
            }
        }
        resultado += $"@{nombreEquipo}";

        return resultado.ToLower();
    }
    //Crear Email Fin





    //AUxiliar


    //Chequear si el pago es de este mes
    public bool pagoEsteMes(DateTime unaFecha)
    {
        if (unaFecha > DateTime.Now.AddMonths(-1))
        {
            return true;
        }
        return false;
    }





}
