using GameTop.Interface;
using System;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _Jogador;

        public JogoFoda(IJogador jogador)
        {
            this._Jogador = jogador;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_Jogador.Chutar());
            Console.WriteLine(_Jogador.Correr());
            Console.WriteLine(_Jogador.Passar());
        }
    }
}