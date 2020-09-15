using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador : IJogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            this._Nome = nome;
        }
        public string Chutar()
        {
            return $"{_Nome} está Chutando";
        }

        public string Correr()
        {
            return $"{_Nome} está Correndo";
        }

        public string Passar()
        {
            return $"{_Nome} está Passando";
        }
    }
}