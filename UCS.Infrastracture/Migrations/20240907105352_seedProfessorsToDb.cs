using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCS.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class seedProfessorsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ee806a3-a456-428a-a940-e30d59e26c52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "521e7923-4ecb-4743-83eb-388430a7fb59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc3e740-7777-477a-a9f3-0ef909f5a052");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bda18f05-be45-4ab2-ac9b-1e781cbe5e4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7508609-edda-4350-8148-28b287ad4fd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d764961f-02c0-4a95-a4e0-06903d0673dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa9dbf1-74eb-4892-9c7e-f63cf473f100");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "2ee806a3-a456-428a-a940-e30d59e26c52", 0, "586859db-9c9a-46b4-9397-4df69a822d17", 5, "Professor", null, false, "firstmath lastname", false, null, null, null, null, null, false, "50a42331-1bd9-4d06-b8e7-716bc99ecc6c", 0, false, 6L, null },
                    { "521e7923-4ecb-4743-83eb-388430a7fb59", 0, "4b79f1c8-9233-48d0-acbd-725076cbbf1d", 3, "Professor", null, false, "firstphys lastname", false, null, null, null, null, null, false, "fa09fd7b-ca1a-4891-b8ef-fbbad6958fee", 0, false, 4L, null },
                    { "6bc3e740-7777-477a-a9f3-0ef909f5a052", 0, "0ecc54d3-d78f-4978-a4fe-a5b3d7c1601c", 4, "Professor", null, false, "firstlang lastname", false, null, null, null, null, null, false, "89787908-736f-48f1-ab8f-a7afa63b131f", 0, false, 5L, null },
                    { "bda18f05-be45-4ab2-ac9b-1e781cbe5e4d", 0, "ce86c605-3a04-435d-bb2a-39c059b97d34", 1, "Professor", null, false, "firstce lastname", false, null, null, null, null, null, false, "370de4d5-71ae-48de-b410-de51e80f47f2", 0, false, 2L, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Degree", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Student_State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[] { "c7508609-edda-4350-8148-28b287ad4fd5", 0, "74281312-cccc-411c-bb47-e6c2a7e8d776", 0, 1, "Student", null, false, "Hosein BN", false, null, 6, null, null, null, null, false, "118db891-b645-40ed-9e03-869c1d3078d5", 16, false, 990342348L, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UniqueMemberId", "UserName" },
                values: new object[,]
                {
                    { "d764961f-02c0-4a95-a4e0-06903d0673dc", 0, "af671ebf-abb4-434a-bd33-7a63881c8d3f", 2, "Professor", null, false, "firstee lastname", false, null, null, null, null, null, false, "2ab5a807-d5ff-49a8-b9ac-eec77ae18a76", 0, false, 3L, null },
                    { "faa9dbf1-74eb-4892-9c7e-f63cf473f100", 0, "742210bd-0724-4331-91d3-20a816f801d9", 5, "Professor", null, false, "scndmath lastname", false, null, null, null, null, null, false, "daf17a2c-e3bc-4f85-9f4d-163a9079b66f", 0, false, 1L, null }
                });
        }
    }
}
