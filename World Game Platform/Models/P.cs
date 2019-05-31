using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace World_Game_Platform.Models
{
    public class P
{
        [Key]
        [MaxLength(30)]
        public string GameName { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        public List<P> Game { get; set; }
    }
}
