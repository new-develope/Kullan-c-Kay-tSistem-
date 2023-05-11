using KullanıcıKayıtSistemı.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KullanıcıKayıtSistemı.Areas.Identity.Data;

public class KullanıcıKayıtSistemıDbContext : IdentityDbContext<KullanıcıKayıtSistemıUser>
{
    public KullanıcıKayıtSistemıDbContext(DbContextOptions<KullanıcıKayıtSistemıDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new KullanıcıKayıtSistemıUserConfiguration());
    }
}

public class KullanıcıKayıtSistemıUserConfiguration : IEntityTypeConfiguration<KullanıcıKayıtSistemıUser>
{
    public void Configure(EntityTypeBuilder<KullanıcıKayıtSistemıUser> builder)
    {
        builder.Property(u =>u.FirstName).HasMaxLength(255);
        builder.Property(u =>u.LastName).HasMaxLength(255);
        builder.Property(u =>u.PhoneNumber).HasMaxLength(255);

    }
}
