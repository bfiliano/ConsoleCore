using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estás chutando  \n";
        }

        public string Corre()
        {
            return "Maradona estás correndo  \n";
        }

        public string Passa()
        {
            return "Maradona estás passando  \n";
        }
    }
}