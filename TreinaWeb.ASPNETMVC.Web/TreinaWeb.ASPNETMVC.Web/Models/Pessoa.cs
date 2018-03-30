using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreinaWeb.ASPNETMVC.Web.Models
{
    public class Pessoa
    {

        [Required(ErrorMessage ="O nome da pessoa é obrigatório")]
        [DisplayName("Nome da pessoa")]
        [MaxLength(50,ErrorMessage = "O nome só pode ter 50 caracteres")]
        [MinLength(5,ErrorMessage = "o nome tem que ter pelo menos 5 caracteres")]
        public string Nome { get; set; }


        [DisplayName("Idade da pessoa")]
        public int Idade { get; set; }
        

        [Required(ErrorMessage ="O endereço da pessoa é obrigatório")]
        [DisplayName("Endereço da pessoa")]
        [MaxLength(100,ErrorMessage ="O endereço só pode ter no maximo 100 caracteres")]
        [MinLength(5, ErrorMessage ="Endereço deve ter no minimo 5 caracteres")]
        public string Endereco { get; set; }


        [Required(ErrorMessage ="O email da pessoa é obrigatório")]
        [DisplayName("Email")]
        [MaxLength(40, ErrorMessage ="O Email deve conter no maximo 40 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}