using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Models
{
    public class SanPhamTrongGio
    {
        public Sach sach { get; set; }
        public int soLuongTrongGio { get; set; }
    }
}