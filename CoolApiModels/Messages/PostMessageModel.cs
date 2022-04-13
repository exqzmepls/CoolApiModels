using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Messages
{
    public class PostMessageModel
    {
        [Required(ErrorMessage = "Chat Id is empty")]
        public Guid ChatId { get; set; }

        [StringLength(1024)]
        public string Text { get; set; }

        [MaxLength(10)]
        public IEnumerable<string> Attachments { get; set; }
    }
}
