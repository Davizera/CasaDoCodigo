//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Runtime.Serialization;

//namespace CasaDoCodigo.Doidera
//{
//    [DataContract]
//    public class BaseModel
//    {
//        [DataMember]
//        public int Id { get; protected set; }
//    }

//    public class Produto : BaseModel
//    {
//        public Produto()
//        {

//        }

//        [Required]
//        public string Codigo { get; private set; }
//        [Required]
//        public string Nome { get; private set; }
//        [Required]
//        public decimal Preco { get; private set; }

//        public Produto(string codigo, string nome, decimal preco)
//        {
//            this.Codigo = codigo;
//            this.Nome = nome;
//            this.Preco = preco;
//        }
//    }

//    public class Cadastro : BaseModel
//    {
//        public Cadastro()
//        {
//        }

//        public virtual PedidoController Pedido { get; set; }
//        [Required]
//        public string Nome { get; set; } = "";
//        [Required]
//        public string Email { get; set; } = "";
//        [Required]
//        public string Telefone { get; set; } = "";
//        [Required]
//        public string Endereco { get; set; } = "";
//        [Required]
//        public string Complemento { get; set; } = "";
//        [Required]
//        public string Bairro { get; set; } = "";
//        [Required]
//        public string Municipio { get; set; } = "";
//        [Required]
//        public string UF { get; set; } = "";
//        [Required]
//        public string CEP { get; set; } = "";
//    }

//    public class ItemPedido : BaseModel
//    {
//        [Required]
//        public PedidoController Pedido { get; private set; }
//        [Required]
//        public Produto Produto { get; private set; }
//        [Required]
//        public int Quantidade { get; private set; }
//        [Required]
//        public decimal PrecoUnitario { get; private set; }

//        public ItemPedido()
//        {

//        }

//        public ItemPedido(PedidoController pedido, Produto produto, int quantidade, decimal precoUnitario)
//        {
//            Pedido = pedido;
//            Produto = produto;
//            Quantidade = quantidade;
//            PrecoUnitario = precoUnitario;
//        }
//    }

//    public class PedidoController : BaseModel
//    {
//        public PedidoController()
//        {
//            Cadastro = new Cadastro();
//        }

//        public PedidoController(Cadastro cadastro)
//        {
//            Cadastro = cadastro;
//        }

//        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
//        [Required]
//        public virtual Cadastro Cadastro { get; private set; }
//    }
//}//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Runtime.Serialization;

//namespace CasaDoCodigo.Doidera
//{
//    [DataContract]
//    public class BaseModel
//    {
//        [DataMember]
//        public int Id { get; protected set; }
//    }

//    public class Produto : BaseModel
//    {
//        public Produto()
//        {

//        }

//        [Required]
//        public string Codigo { get; private set; }
//        [Required]
//        public string Nome { get; private set; }
//        [Required]
//        public decimal Preco { get; private set; }

//        public Produto(string codigo, string nome, decimal preco)
//        {
//            this.Codigo = codigo;
//            this.Nome = nome;
//            this.Preco = preco;
//        }
//    }

//    public class Cadastro : BaseModel
//    {
//        public Cadastro()
//        {
//        }

//        public virtual PedidoController Pedido { get; set; }
//        [Required]
//        public string Nome { get; set; } = "";
//        [Required]
//        public string Email { get; set; } = "";
//        [Required]
//        public string Telefone { get; set; } = "";
//        [Required]
//        public string Endereco { get; set; } = "";
//        [Required]
//        public string Complemento { get; set; } = "";
//        [Required]
//        public string Bairro { get; set; } = "";
//        [Required]
//        public string Municipio { get; set; } = "";
//        [Required]
//        public string UF { get; set; } = "";
//        [Required]
//        public string CEP { get; set; } = "";
//    }

//    public class ItemPedido : BaseModel
//    {
//        [Required]
//        public PedidoController Pedido { get; private set; }
//        [Required]
//        public Produto Produto { get; private set; }
//        [Required]
//        public int Quantidade { get; private set; }
//        [Required]
//        public decimal PrecoUnitario { get; private set; }

//        public ItemPedido()
//        {

//        }

//        public ItemPedido(PedidoController pedido, Produto produto, int quantidade, decimal precoUnitario)
//        {
//            Pedido = pedido;
//            Produto = produto;
//            Quantidade = quantidade;
//            PrecoUnitario = precoUnitario;
//        }
//    }

//    public class PedidoController : BaseModel
//    {
//        public PedidoController()
//        {
//            Cadastro = new Cadastro();
//        }

//        public PedidoController(Cadastro cadastro)
//        {
//            Cadastro = cadastro;
//        }

//        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
//        [Required]
//        public virtual Cadastro Cadastro { get; private set; }
//    }
//}
