using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }        //Id
        public DateTime Date { get; set; } //Data
        public double Amount { get; set; } //Quantia
        public SaleStatus Status { get; set; } //Status da venda

        //Associação da Classe Registro de Vendas [SalesRecord], com a classe Vendedor [Seller]
        public Seller Seller { get; set; }

        public SalesRecord() //Construtor padrão vazio
        {
        
        }
        //Construtor com argumentos
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}


