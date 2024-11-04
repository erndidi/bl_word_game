using System;
using System.Collections.Generic;

namespace bl_word_game.Components.Models;

public partial class Player
{
    public string? Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? Score { get; set; }

    public int? GamesPlayed { get; set; }
}
