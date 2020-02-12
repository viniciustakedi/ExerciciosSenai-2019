using System;
using System.Collections.Generic;
using System.IO;

namespace RoleTopMVC.Repositories
{
    public class ServicosRepository
    {
        private const string PATH = "Database/ServicosAdicionais.csv";

        private const string PATH_PADRAO = "Database/PrecoPadrao.csv";
        public ServicosRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
            if(!File.Exists(PATH_PADRAO))
            {
                File.Create(PATH_PADRAO).Close();
            } 

        }   

        public Dictionary<string, double> ObterTodos()
        {
            Dictionary<string, double> servicos = new Dictionary<string, double>();
            string[] Dados = File.ReadAllLines(PATH);
            
            foreach (var servico in Dados)
            {
                string[] registro = servico.Split(";");
                string Servicos = registro[0];
                double preco = Convert.ToDouble (registro[1]);
                servicos.Add (Servicos, preco);
            }
            return servicos;
        }

        public double ObterPrecoTotal(string ServicosAdicionais)
        {
            var servicos = ObterTodos ();
            string[] precoOrcamento = File.ReadAllLines (PATH_PADRAO);
            double valor = 0;

            if(!string.IsNullOrEmpty(ServicosAdicionais))
            {
                string[] servico = ServicosAdicionais.Split(",");

                for (int i = 0; i < servico.Length; i++)
                {
                    string Servicos = servico[i];
                    if(servicos.ContainsKey(Servicos))
                    {
                        valor += servicos[Servicos];
                    }
                }
            }

            double PrecoPadrao = 0;
            bool converte = double.TryParse (precoOrcamento[0], out PrecoPadrao);
            if(converte)
            {
                valor += PrecoPadrao;
            }
            else
            {
                valor += 10000;
            }
            return valor;

        }
    }
}