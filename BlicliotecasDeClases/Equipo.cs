using System;

public class Equipo
{
	public Equipo()
	{
        public int Id { get; set; }
    public string Nombre { get; set; }
    public static int ProximoId { get; set; } = 1;

    public Equipo(string unNombre)
    {
        Id = ProximoId++;
        Nombre = unNombre;
    }
}
