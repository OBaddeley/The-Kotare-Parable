using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KotareParable
{
    public class NtoR
    {
        public int Id { get; set; }
        public int NarrationId { get; set; }
        [ForeignKey("NarrationId")]
        public Narration Narration { get; set; }
        public int ResponseId { get; set; }
        [ForeignKey("ResponseId")]
        public Response Response { get; set; }
    }
}