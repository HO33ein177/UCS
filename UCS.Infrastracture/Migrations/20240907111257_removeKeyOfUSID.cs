using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCS.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class removeKeyOfUSID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40f62ce1-76b0-4dce-99d1-6bec646440ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72f5e62f-8f4f-419f-9cd3-b892567eda64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f7ee44f-fdb3-484a-98ad-2494fa747b9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b37344-0acd-4f03-a4fd-138d97edd7bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f595cf70-a628-4381-a614-888fd3576848");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f69ffb4e-5f4a-4357-8650-bcb5134c4aa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb9f5cfb-2cea-447d-a851-20f8ad658842");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "40f62ce1-76b0-4dce-99d1-6bec646440ac", 0, "ba9991f8-11d2-43b4-8473-093713e727e6", 2, "Professor", null, false, "firstee lastname", false, null, null, null, null, null, false, "727b24a0-820a-4e20-a92f-138728ff3a92", 0, false, 3L, null },
                    { "72f5e62f-8f4f-419f-9cd3-b892567eda64", 0, "17af40c9-d19b-4d68-a1cb-2343a2338896", 1, "Professor", null, false, "firstce lastname", false, null, null, null, null, null, false, "7c72c6e3-fc16-4f33-8bd4-e49b010f9dfc", 0, false, 2L, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Degree", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Student_State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "9f7ee44f-fdb3-484a-98ad-2494fa747b9d", 0, "0ffc99db-e181-4193-a52f-10679fd9ed08", 0, 1, "Student", null, false, "Hosein BN", false, null, 6, null, null, null, null, false, "8a6233a9-6722-46fb-841f-3296c51dc1ac", 16, false, 990342348L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "a7b37344-0acd-4f03-a4fd-138d97edd7bd", 0, "44082549-24ae-4b6e-aed5-9d0a88c36b5d", 3, "Professor", null, false, "firstphys lastname", false, null, null, null, null, null, false, "563ecfcb-9ae8-46fb-b3dd-6cec776a1633", 0, false, 4L, null },
                    { "f595cf70-a628-4381-a614-888fd3576848", 0, "ac24d744-89a4-4803-8c18-3b12ca864419", 5, "Professor", null, false, "scndmath lastname", false, null, null, null, null, null, false, "7783c571-2136-4fee-98ab-8a9e1e30360b", 0, false, 1L, null },
                    { "f69ffb4e-5f4a-4357-8650-bcb5134c4aa2", 0, "9dadb120-7f99-44a9-b7d3-ee0fad200c61", 4, "Professor", null, false, "firstlang lastname", false, null, null, null, null, null, false, "8f443b9f-0ea2-4dac-87eb-ede2daff2445", 0, false, 5L, null },
                    { "fb9f5cfb-2cea-447d-a851-20f8ad658842", 0, "c3a372dd-0eb1-4699-9472-cf02869e4d9b", 5, "Professor", null, false, "firstmath lastname", false, null, null, null, null, null, false, "0bad5af9-b609-4364-82b3-8ca3b9b2a2bd", 0, false, 6L, null }
                });
        }
    }
}
