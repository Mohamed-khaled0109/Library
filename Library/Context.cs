using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Context : DbContext
    {
        public Context():base(@"Data Source=.\sqlExpress;Initial catalog = LibraryProject;Integrated security=true")
        {} 
        public  DbSet<Registrars> Registrars { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Auther>Authers { get; set; }

    }
}
