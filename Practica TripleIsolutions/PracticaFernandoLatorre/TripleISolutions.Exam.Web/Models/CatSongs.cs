using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleISolutions.Exam.Web.Models
{
    [Table("CAT_SONG")]
    public class CatSongs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required, Column("SONGID")]
        public int SongId { get; set; }

        [Required, DisplayName("Titulo de la canción"), MinLength(2, ErrorMessage = "El nombre de la canción no puede estar vacío"), Column("TITLENAME")]
        public string? TitleName { get; set; }

        [Required, DisplayName("Nombre del grupo"), MinLength(2, ErrorMessage = "El nombre de la banda no puede estar vacío"), Column("BANDNAME")]
        public string? BandName { get; set; }

        [Required, DisplayName("Año de lanzamiento"), Range(1900,2022 , ErrorMessage = "Ingrese una año de lanzamiento correcto"), Column("LAUNCHYEAR")]
        public int LaunchYear { get; set; }

        [Required, DisplayName("Genero Musical"), MinLength(2, ErrorMessage = "El genero no puede estar vacío"), Column("MUSICGENRE")]
        public string? MusicGenre { get; set; }
    }
}
