using System;
using System.Security.Cryptography.X509Certificates;

namespace CadastroDeProduto
{
    public class Certificado
    {
        public static X509Certificate2 ListareObterDoRepositorio()
        {
            var store = ObterX509Store(OpenFlags.OpenExistingOnly | OpenFlags.ReadOnly);
            var collection = store.Certificates;
            var fcollection = collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            var scollection = X509Certificate2UI.SelectFromCollection(fcollection, "Certificados válidos:",
                "Selecione o certificado que deseja usar",
                X509SelectionFlag.SingleSelection);

            if (scollection.Count == 0) throw new Exception("Nenhum certificado foi selecionado!");

            store.Close();
            return scollection[0];
        }

        private static X509Store ObterX509Store(OpenFlags openFlags)
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(openFlags);
            return store;
        }
    }
}