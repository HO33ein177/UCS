using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCS.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class addedImageToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "219d3ba0-b8ee-44c0-8af3-090905fea709");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2feff522-9d27-456d-9d70-6ed0c1366a46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a76b4bd-16c9-4fb0-9bfa-115a0a682bcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65b35bdf-92d1-469d-9ea7-b4fd1700f622");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "692ac7f2-d777-4761-a192-0e0689a4ee24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a27f534b-b522-409c-a9be-ec4a66c53b48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f95ee578-a0a2-4852-ab6a-3435449f05e7");

            migrationBuilder.AddColumn<bool>(
                name: "Allowed",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Allowed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "219d3ba0-b8ee-44c0-8af3-090905fea709", 0, "5a789c5f-ab89-4bca-ba30-27c67c406104", 3, "Professor", null, false, "firstphys lastname", false, null, null, null, null, null, false, "e07e007f-a648-4f97-9623-2961f9b15879", 0, false, 4L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Degree", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Student_State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "2feff522-9d27-456d-9d70-6ed0c1366a46", 0, "45119a5e-5657-4e43-9647-e36c0109f269", 0, 1, "Student", null, false, "Hosein BN", false, null, 6, null, null, null, null, false, "81e0636c-62d2-40bf-8a82-8e88bd43556e", 16, false, 990342348L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "5a76b4bd-16c9-4fb0-9bfa-115a0a682bcf", 0, "aad2aa43-a4d2-430b-8ab1-7b09f739112c", 5, "Professor", null, false, "firstmath lastname", false, null, null, null, null, null, false, "eb07c9d2-2857-4add-8cae-81665a9ff77b", 0, false, 6L, null },
                    { "65b35bdf-92d1-469d-9ea7-b4fd1700f622", 0, "05707da8-b50a-47ed-9a03-bd805961e292", 4, "Professor", null, false, "firstlang lastname", false, null, null, null, null, null, false, "f62393f0-6894-4b56-8a88-add58f5e760b", 0, false, 5L, null },
                    { "692ac7f2-d777-4761-a192-0e0689a4ee24", 0, "3d513d66-d9a9-48e1-921c-da083863856e", 5, "Professor", null, false, "scndmath lastname", false, null, null, null, null, null, false, "7fcbcf52-ad77-492d-bb45-f5d6ae02ecb9", 0, false, 1L, null },
                    { "a27f534b-b522-409c-a9be-ec4a66c53b48", 0, "5ec659fe-005e-4391-933d-18a952ddd2db", 2, "Professor", null, false, "firstee lastname", false, null, null, null, null, null, false, "4ba6ae4e-24a5-4221-8a94-18c71cbc74cb", 0, false, 3L, null },
                    { "f95ee578-a0a2-4852-ab6a-3435449f05e7", 0, "ddeb1c94-d421-4b2d-b29f-fc0693ab7983", 1, "Professor", null, false, "firstce lastname", false, null, null, null, null, null, false, "74dcc72e-bc86-4471-813b-b0164a0d1531", 0, false, 2L, null }
                });
        }
    }
}
