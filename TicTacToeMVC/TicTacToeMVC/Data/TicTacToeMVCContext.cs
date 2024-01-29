using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicTacToeMVC.Models;

namespace TicTacToeMVC.Data
{
    public class TicTacToeMVCContext : DbContext
    {
        public TicTacToeMVCContext (DbContextOptions<TicTacToeMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TicTacToeMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
