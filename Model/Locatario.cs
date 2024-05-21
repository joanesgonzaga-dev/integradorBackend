﻿using System.ComponentModel.DataAnnotations;
using System;
using IntegraBackend.Model.Enums;
using DataAnnotationsExtensions;
using IntegradorBackend.Model.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegradorBackend.Model
{
    [Table("locatario")]
    public class Locatario
    {
        public Locatario()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public TipoPessoa TipoPessoa { get; set; }

        [MaxLength(14)]
        public string CpfCnpj { get; set; }

        [Required]
        public string RgIe { get; set; }

        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        [Required]
        public string Profissao { get; set; }
        
        [Required]
        public string Fone { get; set; }

        [Required]
        [Email]
        public string Email { get; set; }
        
        [Required]
        public EstadoCivil EstadoCivil { get; set; }

        #region Dados Endereço
        [Required]
        [MaxLength(60)]
        public string Logradouro { get; set; }

        [Required]
        public string Numero { get; set; }
        [MaxLength(120)]
        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(2)]
        public string Uf { get; set; }
        #endregion

        public override bool Equals(object obj)
        {
            return obj is Locatario locatario &&
                   Id.Equals(locatario.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
