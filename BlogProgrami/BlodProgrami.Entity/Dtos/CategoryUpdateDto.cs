using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgrami.Entity.Dtos
{
   public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} Adı Boş Geçilemez.")]
        [MaxLength(70, ErrorMessage = "{0} {1} Büyük Olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olamaz.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} Büyük Olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olamaz.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Nota Alanı.")]
        [MaxLength(500, ErrorMessage = "{0} {1} Büyük Olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olamaz.")]
        public string Notes { get; set; }
        [DisplayName("Aktifmi ?")]
        [Required(ErrorMessage = "{0} Adı Boş Geçilemez.")]
        public bool IsActive { get; set; }
        [DisplayName("Silindimi ?")]
        [Required(ErrorMessage = "{0} Adı Boş Geçilemez.")]
        public bool IsDeleted { get; set; }
    }
}
