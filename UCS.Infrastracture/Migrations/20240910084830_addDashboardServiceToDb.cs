using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCS.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class addDashboardServiceToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0403220c-4a5d-4eb1-996c-86363657a006");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0bbb82-b814-4ee1-9572-c25ab685c32b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "834ca086-6a69-431e-a675-0e4ff3c96c1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8354a0cd-2bac-48be-9353-d294aaa07b2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bff20e3-396b-4315-89fe-7590a6d8a69e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a833e5ae-ea71-4eec-942a-546c5dcd4ce9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf358f62-8096-4aa1-9b2a-64815f28549a");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "0403220c-4a5d-4eb1-996c-86363657a006", 0, "5c85a016-d079-4618-940f-a31afdf1044a", 5, "Professor", null, false, "firstmath lastname", null, false, null, null, null, null, null, false, "618f230c-d8c0-4d3b-a822-a532302bbb84", 0, false, 6L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Allowed", "ConcurrencyStamp", "Degree", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Student_State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "2c0bbb82-b814-4ee1-9572-c25ab685c32b", 0, true, "99d4981c-182d-40ce-9aa0-ec2a3d5b06a0", 0, 1, "Student", null, false, "Hosein BN", null, false, null, 6, null, null, null, null, false, "f605f163-4363-4453-a77b-a2be10495586", 16, false, 990342348L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "834ca086-6a69-431e-a675-0e4ff3c96c1b", 0, "a16e0d7a-eb39-4fbb-aabf-7366b62fd364", 3, "Professor", null, false, "firstphys lastname", null, false, null, null, null, null, null, false, "769831d6-bb0b-4770-8cfa-bab055a4f5e2", 0, false, 4L, null },
                    { "8354a0cd-2bac-48be-9353-d294aaa07b2c", 0, "c78e9819-d3be-4dd0-9578-4044af3e521d", 4, "Professor", null, false, "firstlang lastname", null, false, null, null, null, null, null, false, "307fb4d0-4716-4671-bf9d-12e98e36e770", 0, false, 5L, null },
                    { "9bff20e3-396b-4315-89fe-7590a6d8a69e", 0, "733a3ffb-eaa1-4dec-8a67-13008de70500", 2, "Professor", null, false, "firstee lastname", null, false, null, null, null, null, null, false, "00095903-1841-4dfb-98f1-0a863b35765c", 0, false, 3L, null },
                    { "a833e5ae-ea71-4eec-942a-546c5dcd4ce9", 0, "e1229084-bc2d-41d7-b2cb-abf2f9e233c4", 1, "Professor", null, false, "firstce lastname", null, false, null, null, null, null, null, false, "318eaca4-747f-46b7-9838-2782d787d098", 0, false, 2L, null },
                    { "bf358f62-8096-4aa1-9b2a-64815f28549a", 0, "6a49037f-3d06-482c-8398-4c715970fab5", 5, "Professor", null, false, "scndmath lastname", null, false, null, null, null, null, null, false, "552cdca9-1026-4323-b88d-c827ff5df558", 0, false, 1L, null }
                });
        }
    }
}
