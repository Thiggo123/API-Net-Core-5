using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Net_Core
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        public string Descr { get; set; }

        public Pessoa pessoa { get; set; }

    }
}
