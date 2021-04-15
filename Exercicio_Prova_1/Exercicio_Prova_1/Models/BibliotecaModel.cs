using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Prova_1.Models
{
    public class BibliotecaModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int Ano_de_Lançamento { get; set; }

        public string Genero { get; set; }

        public string Idioma { get; set; }

        public string Introducao { get; set; }

    }
}
