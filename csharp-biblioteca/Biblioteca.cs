using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        private List<Utente> utenti = new List<Utente>();
        private List<Documento> documenti = new List<Documento>();
        private List<Prestito> prestiti = new List<Prestito>();

        public void AggiungiUtente(Utente utente)
        {
            utenti.Add(utente);
        }

        public void AggiungiDocumento(Documento documento)
        {
            documenti.Add(documento);
        }

        public void AggiungiPrestito(Prestito prestito)
        {
            prestiti.Add(prestito);
        }

        public List<Documento> CercaDocumentoPerCodice(string codice)
        {
            return documenti.FindAll(d => d.CodiceIdentificativo == codice);
        }

        public List<Documento> CercaDocumentoPerTitolo(string titolo)
        {
            return documenti.FindAll(d => d.Titolo.Contains(titolo));
        }

        public List<Prestito> CercaPrestitiPerUtente(string nome, string cognome)
        {
            return prestiti.FindAll(p => p.Utente.Nome == nome && p.Utente.Cognome == cognome);
        }

        public void EseguiPrestito(Utente utente, Documento documento, DateTime dataInizio, DateTime dataFine)
        {
            prestiti.Add(new Prestito
            {
                Utente = utente,
                Documento = documento,
                DataInizio = dataInizio,
                DataFine = dataFine
            });
        }
    }
}
