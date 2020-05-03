using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }        
        //Associação da Classe Vendedor, com a classe Departamento 
        public Department Department { get; set; }
        //Associação da Classe Vendedor com a Classe Registro de Vendas | Lista de registro de vendas
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();        
        public Seller() //Construtor vazio
        {
        }
        //Construtor com argumentos
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }        
        public void AddSales(SalesRecord sr) //Definição do método para adicionar um vendedor
        {
            Sales.Add(sr);
        }       
        public void RemoveSales (SalesRecord sr)  //Definição do método para remover um vendedor
        {
            Sales.Remove(sr);
        }        
        public double TotalSales (DateTime initial, DateTime final) //Método Total de Vendas
        {
            return Sales.Where(sr => sr.Date <= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
