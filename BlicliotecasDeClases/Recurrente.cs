using System;

public class Recurrente : Pago
{
    public DateTime FechaDeInicio { get; set; }
    public DateTime FechaDeFinal { get; set; }
    public Recurrente(DateTime unaFechaDeinicio, DateTime unaFechaFInal, int Id, TipoDePago FormaDePago) : base(FormaDePago, Id)
    {
        FechaDeInicio = unaFechaDeinicio;
        FechaDeFinal = unaFechaFInal;
    }


    public override string TipodePagoEfecutado(){
        return "Recurrente";

}



}
