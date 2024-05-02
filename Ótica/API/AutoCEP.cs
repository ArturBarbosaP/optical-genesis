using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ótica.API
{
    class AutoCEP
    {
        public string rua, bairro, cidade, estado;

        public void PesquisarCEP(string cep)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Erro na requisição: " + ChecaServidor.StatusCode.ToString());
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            String response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");
                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                // Rua
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(':');
                                    rua = valor[1].ToString();
                                }


                                // Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(':');
                                    bairro = valor[1].ToString();
                                }

                                // Cidade
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(':');
                                    cidade = valor[1].ToString();
                                }

                                // Estado
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(':');
                                    estado = valor[1].ToString();
                                }
                                cont++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}