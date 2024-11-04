using Microsoft.EntityFrameworkCore;
using bl_word_game.Components.Models;

namespace bl_word_game.Components.Models;

public partial class WordGameContext : DbContext
{
    public WordGameContext(DbContextOptions<WordGameContext> options)
        : base(options)
    {
    }

    public DbSet<bl_word_game.Components.Models.Word> Words { get; set; }

    public DbSet<bl_word_game.Components.Models.Player> Players { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}