using System.Security.Claims;

namespace pnphuc2050531200254.Models
{
    public class congNhan
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string MaCN { get; set; }

        public ICollection<caLamViec> caLamViec { get; set; }
    }
}
