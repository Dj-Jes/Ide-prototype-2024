using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Efc;

public class DataContext : DbContext
{
    public DbSet<Item> Items { get; set; }
   // public DbSet<DrinksMenu> DrinkMenus { get; set; }

    public string DbPath { get; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source = Data/DataBase.db");            
    // }

    /// <summary>
    /// I ran in to some issues with the path to the database file.
    /// while running it in a console application it went through the debug files, and the database coudn't be reached.
    ///  in the string dbPath i used the .. to go out of the debug scope and in to the Data folder.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbFileName = "DataBase.db";
        string dbPath = Path.Combine("..", "..", "..", "Data", dbFileName);
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string fullDbPath = Path.GetFullPath(Path.Combine(currentDirectory, dbPath));

        optionsBuilder.UseSqlite($"Data Source={fullDbPath}");
        Console.WriteLine(fullDbPath);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasKey(d => d.ItemId);
       // modelBuilder.Entity<DrinksMenu>().HasKey(dm => dm.DrinkMenuId);
    }
}