using System;
using System;

public abstract class Pago
{
    public int Id { get; set; }
    public TipoDePago FormaDePago { get; set; }
public string Descripcion { get; set; } 
    public static int ProximoId { get; set; } = 1;

    public Pago (TipoDePago unaFormaDePago, int id , string descipcion)
    {
        Id = ProximoId;
        ProximoId++;
        FormaDePago = unaFormaDePago;
        Descripcion = descipcion;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Forma de Pago: {FormaDePago}, Descripcion: {Descripcion}";
    }

    //llamado a la funciíon con clases heredadas
    public abstract string TipodePagoEfecutado();
    
  
    




}