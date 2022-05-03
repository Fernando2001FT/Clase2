namespace EjerciciosOCP.Ejercicio1
{
    public class Factura
    {
        public virtual double ObtenerDescuentoFactura(double valorTotal)
        {
            return valorTotal;
        }
        //Queremos agregar un nuevo tipo de factura
    }

    public class FacturaFinal: Factura
    {
        public override double ObtenerDescuentoFactura(double valorTotal)
        {
            //return base.ObtenerDescuentoFactura(valorTotal);
            return valorTotal -100 ;
        }
    public class FacturaPropuesta : Factura
        {
        public override double ObtenerDescuentoFactura(double valorTotal)
        {
                //return base.ObtenerDescuentoFactura(valorTotal);
                return valorTotal - 50;
        }
    public class FacturaRecurente : Factura
            {
        public override double ObtenerDescuentoFactura(double valorTotal)
            {
                    //return base.ObtenerDescuentoFactura(valorTotal);
                    return valorTotal - 20;
            }
          }
       }
    }
}