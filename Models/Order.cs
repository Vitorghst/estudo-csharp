using System;
using System.Collections.Generic;

namespace ListApi.Models
{
    public class Order 
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string emailConfirmation { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string number { get; set; }
        public DateTime data { get; set; }
        public string optionalAddress { get; set; }
        public string status { get; set; }
        public string total { get; set; }
        public string pagamentoEntrega { get; set; }
        public string pagamentoAplicativo { get; set; }
        public int usuario { get; set; }
 
        // Navigation property for related order items
        public ICollection<OrderItem> OrderItems { get; set;} 
    }
}
