using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CasaDoCodigo.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    public class Produto : BaseModel
    {
        public Produto()
        {

        }

        [Required]
        public string Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public decimal Preco { get; private set; }

        public Produto(string codigo, string nome, decimal preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }

    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        public virtual Pedido Pedido { get; set; }

        [MinLength(5, ErrorMessage = "O Nome deve ter no m�nimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "O Nome deve ter no m�ximo 50 caracteres")]
        [Required(ErrorMessage = "O nome � obrigat�rio!")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "O Email � obrigat�rio!")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "O Telefone � obrigat�rio!")]
        public string Telefone { get; set; } = "";

        [Required(ErrorMessage = "O Endere�o � obrigat�rio!")]
        public string Endereco { get; set; } = "";

        [Required(ErrorMessage = "O Complemento � obrigat�rio!")]
        public string Complemento { get; set; } = "";

        [Required(ErrorMessage = "O Bairro � obrigat�rio!")]
        public string Bairro { get; set; } = "";

        [Required(ErrorMessage = "O Munic�pio � obrigat�rio!")]
        public string Municipio { get; set; } = "";

        [Required(ErrorMessage = "O UF � obrigat�rio!")]
        public string UF { get; set; } = "";

        [Required(ErrorMessage = "O CEP � obrigat�rio!")]
        public string CEP { get; set; } = "";

        public void Update(Cadastro novoCadastro)
        {
            this.Nome = novoCadastro.Nome;
            this.Email = novoCadastro.Email;
            this.Telefone = novoCadastro.Telefone;
            this.Bairro = novoCadastro.Bairro;
            this.CEP = novoCadastro.CEP;
            this.Complemento = novoCadastro.Complemento;
            this.Endereco = novoCadastro.Endereco;
            this.Municipio = novoCadastro.Municipio;
            this.UF = novoCadastro.UF;
        }
    }

    [DataContract]
    public class ItemPedido : BaseModel
    {
        [Required, DataMember]
        public Pedido Pedido { get; private set; }

        [Required, DataMember]
        public Produto Produto { get; private set; }

        [Required, DataMember]
        public int Quantidade { get; private set; }

        [Required, DataMember]
        public decimal PrecoUnitario { get; private set; }

        [DataMember]
        public decimal Subtotal => Quantidade * PrecoUnitario;

        public ItemPedido()
        {

        }

        public ItemPedido(Pedido pedido, Produto produto, int quantidade, decimal precoUnitario)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        public void AtualizaQuantidade(int quantidade)
        {
            this.Quantidade = quantidade;
        }
    }

    public class Pedido : BaseModel
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        [Required]
        public virtual Cadastro Cadastro { get; private set; }
    }
}
