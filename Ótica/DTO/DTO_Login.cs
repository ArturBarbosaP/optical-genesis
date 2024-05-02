using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ótica.DTO
{
    class DTO_Login
    {
        private string usuario, senha;

        public string Usuario 
        { 
            get => usuario;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    usuario = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Usuário corretamente!");
                }
            }
        }

        public string Senha 
        { 
            get => senha;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    senha = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Senha corretamente!");
                }
            }
        }
    }
}