using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class Jogo
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;
        private readonly iJogador _jogador3;
        public Jogo(iJogador jogador1,iJogador jogador2, iJogador jogador3)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
            _jogador3 = jogador3;
        }

        public void InicarJogo()
        {
            Console.Write(_jogador1.Corre());
            Console.Write(_jogador1.Chuta());
            Console.Write(_jogador1.Passa());

            Console.Write("\n PRÓXIMO JOGADOR \n");

            Console.Write(_jogador2.Corre());
            Console.Write(_jogador2.Chuta());
            Console.Write(_jogador2.Passa());

            Console.Write("\n PRÓXIMO JOGADOR \n");

            Console.Write(_jogador3.Corre());
            Console.Write(_jogador3.Chuta());
            Console.Write(_jogador3.Passa());

        }

    }
}


 