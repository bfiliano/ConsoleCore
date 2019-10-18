using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste Chuta \n";
        }

        public string Corre()
        {
            return "Teste Corre \n";
        }

        public string Passa()
        {
            return "Teste Passa \n";
        }
    }
}
