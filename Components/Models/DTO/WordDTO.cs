using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
namespace word_game.Components.Models;

    public class WordDTO 
    {
        public int? id { get; set; }

        public string? text { get; set; }
        [AllowNull]
        public string definition{get;set;}

        public string? length{get;set;}
   
        public string? defchar { get; set; }

        // [JsonPropertyName("Definitions")]

       // public List<DefinitionDTO> Definitions = new List<DefinitionDTO>();

   
    }

