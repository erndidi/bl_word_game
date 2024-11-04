using System.ComponentModel.DataAnnotations;
using bl_word_game.Components.Models;

namespace bl_word_game.Components.Models.DTO;

    public class SessionDTO
    {
        [Required]
        public string? SessionId { get; set; }
        [Required]
        public string? UserName { get; set; }
    }

