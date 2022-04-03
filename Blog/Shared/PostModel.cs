using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blog.Shared
{
    public class PostModel
    {
        [JsonPropertyName("_id")]
        public string? PostId { get; set; }

        [Required(ErrorMessage = "Require Title")]
        [JsonPropertyName("title")]
        public string? PostTitle { get; set; }

        [Required(ErrorMessage = "Require Content")]
        [JsonPropertyName("post_message")]
        public string? PostContent { get; set; }
    }
}
