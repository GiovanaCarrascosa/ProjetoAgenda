using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    //transformado a classe em publica (para todos poderem utilizar) e estatica (para todos utilizarem a mesma classe (mesmo paulo)
    public static class UserSession
    {
        //variaveis que vao guardar os valores do usuario logado
        private static string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;

       

        //encapsulei a variavel para ter controle do q sera inserido ou pego
        public static string usuario
        {
            get { return _usuario; }
            set
            {
                //value = value.ToUpper();
                _usuario = value;
            }

        }

         public static string senha
         {
            get { return _senha; }
            set
            {
                _senha = value;
            }

        }

        public static string nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }

        }
    }
}
