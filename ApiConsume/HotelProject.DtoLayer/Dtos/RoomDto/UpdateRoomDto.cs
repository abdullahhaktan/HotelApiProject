using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarası giriniz...")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen odaya ait resim giriniz...")]

        public string RoomCoverageImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz...")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen başlık giriniz...")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz...")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz...")]
        public string BathCount { get; set; }

        [Required(ErrorMessage = "Lütfen wifi giriniz...")]
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama giriniz...")]
        public string Description { get; set; }
    }
}
