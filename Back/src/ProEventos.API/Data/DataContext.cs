//Contexto utilizado para fazer a criação da tabela de evento no banco
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{//herda do DbContext que vem do Microsoft.EntityFrameworkCore 
    public class DataContext : DbContext
    {
        //construtor porque é necessário que DbSet vire uma classe no BD  
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
    }
}