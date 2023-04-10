using System.Security.Claims;

namespace pnphuc2050531200254.Models
{
    public class bangDangKi
    {
        public int Id { get; set; }
        public congNhan CongNhan { get; set; }
        public caLamViec CaLam { get; set; }
        public DateTime NgayLam { get; set; }
        public ICollection<caLamViec> caLamViec { get; set; }
    }
}
