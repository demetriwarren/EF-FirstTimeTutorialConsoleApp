using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstTimeTutorial;

public class AppDbContext : DbContext      //must inherit a class called DbContext. Done by using the "Microsoft.EntityFrameworkCore"
{
    public DbSet<User> Users { get; set; }        //Indicates that in this program any framework can access the users, but nothing else. 
    public DbSet<Vendor> Vendors { get; set; }    //Indicates that in this program any framework can access the users, but nothing else.
    public DbSet<Product> Products { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<RequestLine> RequestLines { get; set; }
    

    public AppDbContext() { }                       //default constructer (will always have this when referencing a SQL Db

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)   //need to override to get to the SQL db
    {
        var connectionString = "server=localhost\\sqlexpress01;" +  //determines which server/machine we're using. In this instance its the localhost or this machine. 
                                "database=tqlprsdb;" +              //determines what database we're accessing
                                "trusted_connection=true;" +          //trust the connection?
                                "trustServerCertificate=true;";     //trust the server cert?
        optionsBuilder.UseSqlServer(connectionString);

    }

}

