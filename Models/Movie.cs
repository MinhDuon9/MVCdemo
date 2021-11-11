using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcMovie.Models
{
    public class Movie
    {
        [DisplayName("Số")]
        public int Id { get; set; }
        [DisplayName("Tên Phim")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Ngày")]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Thể loại")]
        public string Genre { get; set; }
        [DisplayName("Giá")]
        public decimal Price { get; set; }
    }
}