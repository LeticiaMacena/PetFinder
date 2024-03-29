﻿using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Entities
{
    public class Adocao : ICamposPadrao
    {
        public int AdocaoId { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int PetId { get; set; }
        public int DoadorId { get; set; }
        public virtual Usuario Doador { get; set; }
        public int Vizualizacao { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get;  set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
