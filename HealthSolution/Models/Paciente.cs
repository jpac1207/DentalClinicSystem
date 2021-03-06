﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthSolution.Models
{
    [Table("tbpaciente")]
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string ComoConheceu { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public int TelefoneId { get; set; }
        public Telefone Telefone { get; set; }

        public int CelularId { get; set; }

        public Telefone Celular { get; set; }

        public string Email { get; set; }

        public string NumeroCarteiraPlano { get; set; }
    }
}