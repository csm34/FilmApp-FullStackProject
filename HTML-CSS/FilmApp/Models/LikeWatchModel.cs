using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmApp.Models
{
    public class LikeWatchModel
    {
        public int FilmId { get; set; }
        public bool IsLike { get; set; }
    }
}