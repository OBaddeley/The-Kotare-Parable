using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KotareParable
{
    public class Response
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public int? NarrationId { get; set; }
        [ForeignKey("NarrationId")]
        public Narration Narration { get; set; }
    }
}