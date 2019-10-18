using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _nome;

        public Jogador1(string nome)
        {
            _nome = nome;
        }

        public string Chuta()
        {
           return  $"{_nome} está chutando \n";
        }

        public string Corre()
        {
           return  $"{_nome} está correndo \n";
        }
        public string Passa()
        {
           return  $"{_nome} está passando \n";
        }
    }
}