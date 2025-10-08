//public bool PagoEsteMes(Pago unPago)
//{
//    DateTime limite = DateTime.Now.AddMonths(-1);

//    if (unPago is PagoUnico)
//    {
//        PagoUnico pu = (PagoUnico)unPago;
//        return pu.FechaPago >= limite;
//    }
//    else if (unPago is PagoRecurrente)
//    {
//        PagoRecurrente pr = (PagoRecurrente)unPago;
//        return pr.FechaInicio <= DateTime.Now && (pr.FechaFin == null || pr.FechaFin >= limite);
//    }

//    return false;
//}