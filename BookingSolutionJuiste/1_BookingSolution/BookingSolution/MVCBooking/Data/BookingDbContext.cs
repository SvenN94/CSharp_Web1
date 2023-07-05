using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVCBooking.Data
{
    public class BookingDbContext : IdentityDbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        { }
    }
}
