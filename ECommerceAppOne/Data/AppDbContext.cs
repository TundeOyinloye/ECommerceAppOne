using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECommerceAppOne.Data
{
    public class AppDbContext : DbContext
    {
        // dbcontex file will serve as the translator between the models and the database
        //we use the model to send data to the database or to get data from the database
        //for the database to understand the c# code and vise versa, the dbcontext is what does the magic


        //we will create a custom dbcontext file that will inherit from the dbcontext base class
        // define the constructor, that will take the parameter DbContextOptions that will take
        // AppDbContext file name as its parameter, name it option, and then pass the options to the base class using 
        // the base keyword options
        // then add the DbContext to the program.cs file, pass in the filename as its parameter

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
