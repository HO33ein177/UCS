using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCS.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class addHoseinToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64e41de2-01aa-4804-bc0c-2e2ecb0b469f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b9ffc4-5243-4979-8834-7f5f7eec8ce0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a85492f-cea9-445b-a0b8-e6da09291f63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d58b2f5f-8478-4b45-802c-ec470d305f88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8da45f6-dfb7-4001-b425-8e0501c09d9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2450b15-e5f8-4265-8283-36ec0ea82daa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc5954a0-84d6-43e3-8a33-f03509ddca8c");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Degree", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Student_State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "64e41de2-01aa-4804-bc0c-2e2ecb0b469f", 0, "796c1e0c-6a28-4335-ac25-98f2b5791edf", 0, 1, "Student", null, false, "Hosein BN", false, null, 6, null, null, null, null, false, "6966a7cf-02d1-4d9a-bf21-58d8185d3be2", 16, false, 990342348L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "69b9ffc4-5243-4979-8834-7f5f7eec8ce0", 0, "7dc0a362-9837-420f-afcd-e1bff15179f0", 3, "Professor", null, false, "firstphys lastname", false, null, null, null, null, null, false, "db53d700-3ea1-4be5-be23-661c9cf051d6", 0, false, 4L, null },
                    { "6a85492f-cea9-445b-a0b8-e6da09291f63", 0, "a9409840-0a2b-4c66-8c8b-cb4cb4e0e594", 5, "Professor", null, false, "firstmath lastname", false, null, null, null, null, null, false, "1f90db16-fd7a-460f-8542-674c040fa78d", 0, false, 6L, null },
                    { "d58b2f5f-8478-4b45-802c-ec470d305f88", 0, "e83aedf1-af09-4e58-9609-86a3bfb5fbfe", 4, "Professor", null, false, "firstlang lastname", false, null, null, null, null, null, false, "c423d17a-4081-4515-9e4c-6031e73b5fab", 0, false, 5L, null },
                    { "d8da45f6-dfb7-4001-b425-8e0501c09d9f", 0, "4c4c95c4-7afe-4a48-8894-c8448d611608", 2, "Professor", null, false, "firstee lastname", false, null, null, null, null, null, false, "12e8a14f-1c6a-4ebe-b2fc-b5e191aff648", 0, false, 3L, null },
                    { "e2450b15-e5f8-4265-8283-36ec0ea82daa", 0, "4d12af7c-d61c-4a19-a57a-546437e3c404", 1, "Professor", null, false, "firstce lastname", false, null, null, null, null, null, false, "d04ca291-256d-4b62-b78d-34f159006442", 0, false, 2L, null },
                    { "fc5954a0-84d6-43e3-8a33-f03509ddca8c", 0, "3d83dc93-172a-46e3-be57-38d99f07c687", 5, "Professor", null, false, "scndmath lastname", false, null, null, null, null, null, false, "c256c864-9c38-400b-9333-2b58b4d4c975", 0, false, 1L, null }
                });
        }
    }
}
