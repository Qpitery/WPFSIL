using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSIL.DBO
{
    internal class TodoDTO
    {
        public int Id { get; set; }

        public string? TodoName { get; set; }

        public string? Description { get; set; }

        public int? StatusId { get; set; }

    }
}
