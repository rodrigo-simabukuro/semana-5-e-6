using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_semana5e6.Models
{
    public class Caminhao
    {
        public Caminhao() =>
            DataCriacao = DateTime.Now;
        public Caminhao(int id, string nome, string descricao) : this()
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
