using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blog.Shared
{
    public class CommentModel
    {
        [JsonPropertyName("_id")]
        public string? CommentId { get; set; }

        [JsonPropertyName("post_id")]
        public string? PostId { get; set; }

        [Required(ErrorMessage = "Require Message")]
        [JsonPropertyName("comment_message")]
        public string? CommentMessage { get; set; }
    }
}
