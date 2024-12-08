using System;
using System.Collections.Generic;

namespace bl_word_game.Components.Models;

public partial class Guess
{
    public int Idx { get; set;}

    public char Letter { get; set; } 

    public string ClassName{get;set;}

    public bool Guessed{get;set;}

}