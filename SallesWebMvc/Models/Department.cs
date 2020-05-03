using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department    //2º passo Criar a classe Departamento e seus atributos
    {
        public int Id { get; set; }         //Atributos Id
        public string Name { get; set; }    //Atributo Nome

        //Associação da Classe Departamento com a Classe Vendedores |Instaciamento Lista de Vendedores
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
      
        //Construtores padrão vazio
        public Department() 
        {
        
        }
        //Construtor com argumentos
        public Department(int id, string name)
        {
            Id = id;
            Name = name;           
        }
        //Método Adicionar vendedor
        public void AddSeller(Seller seller) 
        {
            Sellers.Add(seller);
        }
        //Método para somar as vendas de um determinado período
        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sellers.Sum(Seller => Seller.TotalSales(initial, final));
        }
    }
}
