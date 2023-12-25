using System.ComponentModel.DataAnnotations;

namespace FilmApp.Data
{
    public class Film{
        [Key]
        public int FilmId { get; set; }
        public String? FilmName { get; set; }
        public String? FilmDirector { get; set; }
        public String? ReleaseDate { get; set; }
        public decimal Rating { get; set; }
        public int LikeCount { get; set; }
        public int WatchList { get; set; }
        public String? ImageUrl { get; set; }
        
    }
}