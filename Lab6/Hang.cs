using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Hang
    {
        string _tenhang, _tenNcc, _diachi;
        public string TenHang
        {
            get { return _tenhang; }
            set
            { _tenhang = value; }
        }
        public string TenNhaCC
        {
            get { return _tenNcc; }
            set { _tenNcc = value; }
        }
        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public Hang() { }
        /// <summary>
        /// Tạo đối tượng hàng
        /// </summary>
        /// <param name="tenhang">Tên hàng</param>
        /// <param name="tenNcc">Tên nhà CC</param>
        /// <param name="diachi">Địa chỉ của nhà cung cấp mặt hàng này.</param>
        public Hang(string tenhang, string tenNcc, string diachi)
        {
            _tenhang = tenhang;
            _tenNcc = tenNcc;
            _diachi = diachi;
        }

    }
}
