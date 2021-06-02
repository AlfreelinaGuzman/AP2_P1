using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
//using AP2_P1.Models;


namespace AP2_P1.DAL
{

    public class Contexto : DbContext{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
        optionsBuilder.UseSqlite(@"Data Source= Data/Producto.db");
      }   
    }
}