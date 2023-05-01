using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recepcion.Migrations
{
  /// <inheritdoc />
  public partial class AdminUser : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'783eb77e-90d1-4b7c-ab58-d8980d48e4a2', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEF1EylxprFb2EZyCNLobKLchim4o37Hq0cwy5aNYMC6Bu5iDjoT3gz9hg833ovNZBA==', N'PXPNQK525IRVCXMF2YEYCT3GVKUZAKK6', N'8440d311-4ba5-4756-babb-4d48f9ee8203', NULL, 0, 0, NULL, 1, 0)");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {

    }
  }
}
