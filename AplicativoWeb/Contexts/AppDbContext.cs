//Trabalho para amanhã

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

public class AppDbContexts:DbContext{

    //overrride (sobrescrever)
    //NãoTrair () -Contrato
    //CompartilharCarteira ()
    //protected

    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=LAB-F08-16; Database=EscolaDotNet; User Id=sa; Password=senai@123; TrustServerCertificate=True;");
    }


}