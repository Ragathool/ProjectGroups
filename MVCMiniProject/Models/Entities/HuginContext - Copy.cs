using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCMiniProject.Models.Entities
{
    public partial class HuginContext : DbContext
    {
        public HuginContext(DbContextOptions<HuginContext> options) : base(options)
        {

        }
    }
}
