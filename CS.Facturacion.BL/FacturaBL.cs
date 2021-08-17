using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CS.Facturacion.Entities;
using CS.Facturacion.DAL;

namespace CS.Facturacion.BL
{
    class FacturaBL
    {
        public static List<Factura> ObtenerFactura()
        {
            
            try
            {
                return FacturaDAL.ObtenerFactura();
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (TimeoutException ex)
            {
                throw;
            }
            catch (FormatException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static int AgregarFactura(Factura pFactura)
        {
            

            try
            {
                return FacturaBL.AgregarFactura(pFactura);
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
