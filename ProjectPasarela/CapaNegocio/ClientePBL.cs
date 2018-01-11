using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocio
{
    public class ClientePBL
    {
       /* public List<TClientePasarela> Listar()
        {
            using (BDEcommerceEntities comercio = new BDEcommerceEntities())
            {
                return comercio.TClientePasarela.ToList();
            }
        }*/

        public string Agregar(int  CodCliente,string Nombres,string Apellidos,
            string Ciudad,string Provincia,string Distrito,string Sexo,string Estado,
            string TipoDoc,string Dni)
        {
            try
            {
                using (BDEcommerceEntities comercio = new BDEcommerceEntities())
                {
                    TClientePasarela cli = new TClientePasarela 
                    { 
                        CodCliente  = CodCliente,
                        Nombres=Nombres,
                        Apellidos = Apellidos,
                        Cuidad = Ciudad,
                        Provincia = Provincia,
                        Distrito = Distrito,
                        Sexo = Sexo,
                        Estado = Estado,
                        TipoDocumento = TipoDoc,
                        DNI = Dni
                    };
                    comercio.TClientePasarela.Add(cli);
                    comercio.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return "Se realizo proceso con exito";
        }
    }
}
