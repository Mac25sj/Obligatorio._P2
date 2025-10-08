using System;

public class Unico : Pago
{
    public DateTime FechaDePago { get; set; }
    public int NumeroDeRecibo { get; set; }
    public Unico(DateTime unaFecha, int unNumeroDeRecibo, int Id, TipoDePago FormaDePago) : base(FormaDePago, Id)
    {
        FechaDePago = unaFecha;
        NumeroDeRecibo = unNumeroDeRecibo;
    }


    public override string TipodePagoEfecutado()
    {
        return "Unico";

    }


}

