using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Database: DbContext
    {
        public DbSet<User> Users { get; set; }

        public Database() : base("name=Connection") { }
    }
}
