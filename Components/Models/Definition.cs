using System;
using System.Collections.Generic;

namespace bl_word_game.Components.Models;

public partial class Definition
{
    public Guid Id { get; set; }

    public int Wordid { get; set; }

    public string Text { get; set; } = null!;
}
