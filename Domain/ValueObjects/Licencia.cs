using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.ValueObjects
{
    public class Licencia
    {
        public int Id { get; set; }
        public string Description { get; set; }    

        public Licencia() { }
    }
}
