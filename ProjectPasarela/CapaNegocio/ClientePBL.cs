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

        public string Actualizar(int CodCliente, string Nombres, string Apellidos,
            string Ciudad, string Provincia, string Distrito, string Sexo, string Estado,
            string TipoDoc, string Dni)
        {
            try
            {
                
                using (BDEcommerceEntities comercio = new BDEcommerceEntities())
                {
                    TClientePasarela cli = (from c in comercio.TClientePasarela
                                            where c.CodCliente.Equals(CodCliente)
                                            select c).First();
                    cli.Nombres = Nombres;
                    cli.Apellidos = Apellidos;
                    cli.Cuidad = Ciudad;
                    cli.Provincia = Provincia;
                    cli.Distrito = Distrito;
                    cli.Sexo = Sexo;
                    cli.Estado = Estado;
                    cli.TipoDocumento = TipoDoc;
                    cli.DNI = Dni;

                    comercio.TClientePasarela.Add(cli);
                    comercio.SaveChanges();
                }


            }
            catch (Exception)
            {
                
                throw;
            }
            return "";
        }


        public string Eliminar(string CodCliente)
        {

            try
            {
                using (BDEcommerceEntities comercio = new BDEcommerceEntities())
                { 
                TClientePasarela cli = (from c in comercio.TClientePasarela
                                            where c.CodCliente.Equals(CodCliente)
                                            select c).First();
                comercio.TClientePasarela.Remove(cli);
                comercio.SaveChanges();
                };
            }
            catch (Exception)
            {
                
                throw;
            }
            return "Se realizo proceso con exito";
        }
    }
}
