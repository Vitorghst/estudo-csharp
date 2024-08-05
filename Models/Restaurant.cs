using System.ComponentModel.DataAnnotations;

namespace ListApi.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Endereco { get; set; }
        [Required]
        public string? Cidade { get; set; }
        [Required]
        public string? Estado { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Cep { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Cnpj { get; set; }
        public int EntregaTempo { get; set; }
        public string? Retirada { get; set; }
        public double PedidoMin { get; set; }
        public string? Frete { get; set; }
    }
}