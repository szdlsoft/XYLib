using Bodhi.XYLib.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.Users;

namespace Bodhi.XYLib.EntityFrameworkCore
{
    public static class XYLibDbContextModelCreatingExtensions
    {
        public static void ConfigureXYLib(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Libary>(b =>
            {
                b.ToTable(XYLibConsts.DbTablePrefix + "Libary", XYLibConsts.DbSchema);
                //b.Ignore(l => l.User);
            });
            builder.Entity<BookInfo>(b =>
            {
                b.ToTable(XYLibConsts.DbTablePrefix + "BookInfo", XYLibConsts.DbSchema);
            });

           // builder.Entity<AppUser>(b =>
           //{
           //    b.Ignore(u => u.ExtraProperties);
           //});
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}