using Microsoft.EntityFrameworkCore;
using ServiceWorkerDemo.Models;

namespace ServiceWorkerDemo.Data
{
    public class WebPushDemoContext : DbContext
    {
        public WebPushDemoContext(DbContextOptions<WebPushDemoContext> options) : base(options) { }
        public DbSet<Devices> Devices { get; set; }
    }
}
