using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCS.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class setDefaultImgForUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28307c35-4e3c-40de-a0e3-89f91609ec88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d791740-1df0-4593-90de-985e64dd9a8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5957279f-5576-469e-92f9-a393f01073e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cae3336-a9b7-488c-9882-d3bd2599fefb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95c8c026-263d-491e-8673-821c3dc4dc4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a72d95b6-7720-461c-8919-e3ec7c78879b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5f751e7-d10d-4fa4-8405-e035b2a15e3c");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "085b599e-11de-4398-8b7b-6236ba06ae32", 0, "b49a242f-fcd4-46c3-aa96-299a963adb8c", 4, "Professor", null, false, "firstlang lastname", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s", false, null, null, null, null, null, false, "a1e4b6d8-49aa-4fbd-9a30-2d68f8486ecb", 0, false, 5L, null },
                    { "43af571e-13e1-4b80-b3c1-d4cbeb8c0292", 0, "e96f91da-814e-4c93-8311-9bff85a22abc", 2, "Professor", null, false, "firstee lastname", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s", false, null, null, null, null, null, false, "105b46a3-a57b-45d9-9cd7-401efd6aacdd", 0, false, 3L, null },
                    { "5af8ac63-bd09-4877-9bbd-6681a1616d89", 0, "486e08e5-2a87-4056-a80a-80acdc07e3b7", 5, "Professor", null, false, "firstmath lastname", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s", false, null, null, null, null, null, false, "06b976b3-838d-4937-81bc-38a8693fffcf", 0, false, 6L, null },
                    { "6fd8665d-d27a-4b33-925d-7bf5470a1691", 0, "82248fec-57e1-49ee-917a-76f3c7be5015", 1, "Professor", null, false, "firstce lastname", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s", false, null, null, null, null, null, false, "512e5acc-7830-49f3-b6ac-f74c30d9b04d", 0, false, 2L, null },
                    { "a8a90130-63e8-4e24-9439-63ad854776f3", 0, "4ece332c-e6a1-4420-9c42-0e73f5601fc0", 5, "Professor", null, false, "scndmath lastname", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s", false, null, null, null, null, null, false, "54c7bba9-56c4-40bb-9045-39824b2e6903", 0, false, 1L, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Allowed", "ConcurrencyStamp", "Degree", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Student_State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "ee23c3a5-b812-461b-a61b-d1f87ac84376", 0, true, "d7805078-26b9-45f9-875c-be1bb4425bda", 0, 1, "Student", null, false, "Hosein BN", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s", false, null, 6, null, null, null, null, false, "dbc07923-bfc6-41c0-bda0-ebf8a1e1c7bc", 16, false, 990342348L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "f316d43b-0e82-4896-961b-246b543b0df7", 0, "3bb3fafc-4700-4715-a5b1-48bc7d49be7f", 3, "Professor", null, false, "firstphys lastname", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s", false, null, null, null, null, null, false, "b4bf9e94-892a-44aa-825d-1d70eae44454", 0, false, 4L, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "085b599e-11de-4398-8b7b-6236ba06ae32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43af571e-13e1-4b80-b3c1-d4cbeb8c0292");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5af8ac63-bd09-4877-9bbd-6681a1616d89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fd8665d-d27a-4b33-925d-7bf5470a1691");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8a90130-63e8-4e24-9439-63ad854776f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee23c3a5-b812-461b-a61b-d1f87ac84376");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f316d43b-0e82-4896-961b-246b543b0df7");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "28307c35-4e3c-40de-a0e3-89f91609ec88", 0, "bde4b71b-b966-4060-8b80-35ed77872147", 5, "Professor", null, false, "firstmath lastname", null, false, null, null, null, null, null, false, "ccdc4389-fc4f-44f6-9e1d-2156e4ed8fac", 0, false, 6L, null },
                    { "3d791740-1df0-4593-90de-985e64dd9a8e", 0, "cae73f3c-3e8f-4338-bb60-5db7dd515e65", 4, "Professor", null, false, "firstlang lastname", null, false, null, null, null, null, null, false, "689186d4-3b0b-45e9-a376-d52474c115a5", 0, false, 5L, null },
                    { "5957279f-5576-469e-92f9-a393f01073e9", 0, "1eea3816-e04e-4403-b4ab-c6357932d76e", 5, "Professor", null, false, "scndmath lastname", null, false, null, null, null, null, null, false, "e5cdda32-3c6f-4a03-9fde-e0ea7ef3803a", 0, false, 1L, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Allowed", "ConcurrencyStamp", "Degree", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Student_State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "6cae3336-a9b7-488c-9882-d3bd2599fefb", 0, true, "7dcab5cf-8d63-4782-81af-197d09d63489", 0, 1, "Student", null, false, "Hosein BN", null, false, null, 6, null, null, null, null, false, "77cddc64-6303-49e1-aec0-00a46e06eacc", 16, false, 990342348L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "95c8c026-263d-491e-8673-821c3dc4dc4d", 0, "4e3500c9-7f29-4eb5-a02d-b40877ede203", 2, "Professor", null, false, "firstee lastname", null, false, null, null, null, null, null, false, "021af5d2-7dc8-4fb5-b0b2-89ec07ca5069", 0, false, 3L, null },
                    { "a72d95b6-7720-461c-8919-e3ec7c78879b", 0, "f305c536-3a45-47ae-bd14-a624fb5639a6", 3, "Professor", null, false, "firstphys lastname", null, false, null, null, null, null, null, false, "151d2381-b249-4422-b811-acaca3908e04", 0, false, 4L, null },
                    { "c5f751e7-d10d-4fa4-8405-e035b2a15e3c", 0, "499d8803-a391-46da-94fb-fcadb518d892", 1, "Professor", null, false, "firstce lastname", null, false, null, null, null, null, null, false, "6d755927-7d38-4b2f-a189-da4b52beb86a", 0, false, 2L, null }
                });
        }
    }
}
