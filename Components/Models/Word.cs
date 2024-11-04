using System;
using System.Collections.Generic;

namespace bl_word_game.Components.Models;

public partial class Word
{
    public int id { get; set; }

    public string? text { get; set; }

    public string? definition{get;set; }    

    public int? length { get; set; }
}
