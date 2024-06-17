using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityChanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "eb11eff1-7697-474c-979d-f7ae56a0c530", "admin@gmail.com", true, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEILEvMFJX3gvimmB1QeH3Qf8ttQKgNHTXnSqwo9lDHW2QgFsGNfD+KVpQQIQVZ98og==", "1234567890", false, "5f9c743c-7aaa-4914-a823-0353641e8888", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "BookDefinitions",
                columns: new[] { "Id", "Author", "Title" },
                values: new object[,]
                {
                    { new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), "Camilla Läckberg", "Ofiara losu" },
                    { new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), "Juliusz Słowacki", "Balladyna" },
                    { new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"), "J.K. Rowling", "Harry Potter i Książę Półkrwi" },
                    { new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), "J.K. Rowling", "Harry Potter i Zakon Feniksa" },
                    { new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), "J.K. Rowling", "Harry Potter i Czara Ognia" },
                    { new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), "Kornel Makuszyński", "Szatan z siódmej klasy" },
                    { new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), "Juliusz Słowacki", "Kordian" },
                    { new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), "Stieg Larsson", "Mężczyźni, którzy nienawidzą kobiet" },
                    { new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), "Andrzej Sapkowski", "Narrenturm" },
                    { new Guid("3e0d0ba3-8d04-4700-91bf-f3e3d78129ef"), "George R.R. Martin", "Gra o tron (edycja ilustrowana)" },
                    { new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), "Christopher Paolini", "Dziedzictwo" },
                    { new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), "Władysław Stanisław Reymont", "Chłopi" },
                    { new Guid("512a64d4-2940-4897-b202-cb519ece9f19"), "Andrzej Ziemiański", "Achaja. Tom I" },
                    { new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), "J.K. Rowling", "Harry Potter i więzień Azkabanu" },
                    { new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), "Johann Wolfgang von Goethe", "Cierpienia młodego Wertera" },
                    { new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), "Cassandra Clare", "Miasto upadłych aniołów" },
                    { new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), "Camilla Läckberg", "Niemiecki bękart" },
                    { new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"), "Camilla Läckberg", "Księżniczka z lodu" },
                    { new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), "William Shakespeare", "Romeo i Julia" },
                    { new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), "George R.R. Martin", "Starcie królów (edycja ilustrowana)" },
                    { new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"), "George R.R. Martin", "Nawałnica mieczy: Stal i śnieg" },
                    { new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), "Jo Nesbø", "Człowiek nietoperz" },
                    { new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), "J.K. Rowling, Jack Thorne", "Harry Potter i Przeklęte Dziecko" },
                    { new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"), "Camilla Läckberg", "Kaznodzieja" },
                    { new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), "Dan Brown", "Inferno" },
                    { new Guid("c687f724-506d-448b-9511-e686b91f3dda"), "Veronica Roth", "Niezgodna" },
                    { new Guid("c72c0bbb-32eb-4676-a628-2b1aea7e434b"), "Stanisław Wyspiański", "Wesele" },
                    { new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"), "J.K. Rowling", "Harry Potter i Komnata Tajemnic" },
                    { new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), "J.K. Rowling", "Harry Potter i Kamień Filozoficzny" },
                    { new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), "Camilla Läckberg", "Kamieniarz" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "City", "Code", "Name", "Street" },
                values: new object[,]
                {
                    { new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), "Poznań", "61-842", "Jan Kowalski", "Za Bramką 12" },
                    { new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), "Poznań", "61-111", "Tomasz Rydz", "Garbary 1" },
                    { new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), "Poznań", "61-111", "Aleksandra Mechrzycka", "Solna 2" },
                    { new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), "Poznań", "61-311", "Jan Nowak", "Wieżowa 3" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDefinitionId", "Comment", "Status" },
                values: new object[,]
                {
                    { new Guid("04458325-54c3-4f25-b16e-5e8f0fce2562"), new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"), null, 2 },
                    { new Guid("079638cb-6d07-4ad6-963f-56cfccee80c7"), new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"), null, 1 },
                    { new Guid("1102a15c-bc66-4291-ac12-8069ef385393"), new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"), null, 1 },
                    { new Guid("16aa5a85-50e6-4b37-b310-1ca8ffabd155"), new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), null, 1 },
                    { new Guid("19a2c0cf-b56a-4cc6-9d55-cce66a648bd2"), new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), null, 2 },
                    { new Guid("1ca457bb-65a3-4368-87a7-cfb4c60fb149"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 1 },
                    { new Guid("20ec3e8b-8c3b-4dee-9da7-093579c71a4f"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 1 },
                    { new Guid("217e2ead-b9de-4a38-a2ab-995f9515a8b7"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 2 },
                    { new Guid("21c536c4-494c-44f1-84c5-be8fe6145b58"), new Guid("c687f724-506d-448b-9511-e686b91f3dda"), null, 1 },
                    { new Guid("28e868af-842e-43f2-8a45-447f8e14031c"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 1 },
                    { new Guid("29a2798b-2d43-429c-b232-704e0e42a61e"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 2 },
                    { new Guid("2bafac4d-096e-493a-be81-b862350189e7"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 0 },
                    { new Guid("30dc1b8c-6f90-48ba-8434-dcd5be4d8276"), new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), null, 2 },
                    { new Guid("3273742c-d607-4b81-ae55-3d65b3941f9c"), new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"), null, 2 },
                    { new Guid("3550d8b6-c72e-47a8-bf8c-3982f945105d"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 1 },
                    { new Guid("3dedc88b-8f8b-403e-9468-e782adfe22ef"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 2 },
                    { new Guid("3df99c7e-dc10-420d-ac5c-9547f930c9bc"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("428d8f2a-4f09-4f20-bff6-cd9de70e8204"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 2 },
                    { new Guid("42aae123-5f81-439c-b85c-86b194f5ac84"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 0 },
                    { new Guid("435579ed-f57d-45d5-bfc2-41aeaa03b0bc"), new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), null, 0 },
                    { new Guid("461e28c6-ed59-4055-80a7-a34730a367ba"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("4746d247-4e52-40e2-8d46-e9c97fd9748d"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 1 },
                    { new Guid("4c2cbb8e-f1b7-4bc8-b5b6-0b64a62ae510"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 2 },
                    { new Guid("4d2cc9be-bb09-44ed-9f37-0e9ef3466926"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 0 },
                    { new Guid("522672d0-5c49-45a0-8533-142c81cfe905"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("52f38433-da32-445e-aeed-769c21c5e6de"), new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), null, 1 },
                    { new Guid("53e62ef4-f0fe-419b-8e02-34f920862cbb"), new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), null, 2 },
                    { new Guid("5694a295-f5ea-46ec-bd54-8f625aa4707c"), new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), null, 2 },
                    { new Guid("57650987-400b-4a05-9314-472676a3e68f"), new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), null, 0 },
                    { new Guid("5d7826ed-31e5-4ae8-93f4-ebd17dd2ff53"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("687f20d1-fcb5-40d4-8261-96469633348a"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 0 },
                    { new Guid("68dd801b-29a6-49e0-9615-1116b02d4f29"), new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), null, 0 },
                    { new Guid("69a4237b-f0f7-46f3-84c7-08893d583391"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 0 },
                    { new Guid("6c3cc738-65cc-4c63-9cfd-8bdcae010a84"), new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), null, 1 },
                    { new Guid("7006ca97-25b0-4d67-a7a4-b91bc6fc4d16"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 1 },
                    { new Guid("706c489e-ba97-47d9-b65b-1c131a39acab"), new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), null, 2 },
                    { new Guid("73d4d398-6788-4b58-87ff-dfdc5b977dc9"), new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), null, 2 },
                    { new Guid("740f47fe-fd84-4362-aeee-0466b0361aa9"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 0 },
                    { new Guid("7748142b-c549-45af-b7e9-7857acf63d63"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("77b9510b-5310-4a1f-b5ad-3b310fc432ea"), new Guid("512a64d4-2940-4897-b202-cb519ece9f19"), null, 1 },
                    { new Guid("77d2ebd2-1446-448f-8099-4a45f20f0ffb"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("78587f17-5dec-4ae4-b4f0-216b0e1866ed"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 1 },
                    { new Guid("7a0a4ec2-dad5-41e5-9702-0b942b0043dd"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 0 },
                    { new Guid("7d977b68-ea78-4217-b6a4-a16afdc6b18c"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 1 },
                    { new Guid("80c3cac4-9b75-431f-93dd-12b3e480281d"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 1 },
                    { new Guid("812d4f76-5d7e-4801-bb46-826f0521fa65"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 0 },
                    { new Guid("818d1105-03f3-4ea0-adcd-516f3f413842"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("85c515c7-3ae7-4845-b5ab-043eb413bd22"), new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), null, 1 },
                    { new Guid("8600bd80-5d2f-4a26-93c9-8ad950b4f87e"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 1 },
                    { new Guid("86a88a4e-d4aa-44c7-9a56-e0253efc60fc"), new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"), null, 1 },
                    { new Guid("872ff021-0db3-4d31-be94-58d48b8be986"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 2 },
                    { new Guid("874c32cd-7e95-479e-b709-c044b3a43896"), new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"), null, 0 },
                    { new Guid("8e956fed-01da-421c-8ea4-790d0c14bffa"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 2 },
                    { new Guid("97fd701a-3ea5-4420-be7d-0f0d00f31958"), new Guid("c687f724-506d-448b-9511-e686b91f3dda"), null, 0 },
                    { new Guid("98ddb6e6-db0b-4066-8ac6-d84b0453856a"), new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"), null, 0 },
                    { new Guid("9a42a451-c4a1-4a6c-934a-3ad5315b0bc8"), new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), null, 2 },
                    { new Guid("9aa721a3-8746-43c9-b1eb-6476d2dacacc"), new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), null, 1 },
                    { new Guid("9b61bcd3-8c89-4c6e-bbd6-f983861c0a98"), new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), null, 0 },
                    { new Guid("9cdcb892-7152-4032-a402-a9ba267b3b02"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 2 },
                    { new Guid("a26434dd-0bce-44c6-b47d-7fa81425e9a6"), new Guid("512a64d4-2940-4897-b202-cb519ece9f19"), null, 2 },
                    { new Guid("a404267e-8bbf-4d7c-a099-35583479fefa"), new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), null, 2 },
                    { new Guid("a4263179-198f-471a-b7f5-747e2aa05c50"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 1 },
                    { new Guid("a77ab981-9426-40c4-8289-735bdca7ef3f"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 1 },
                    { new Guid("a908b462-f860-42eb-aba6-f1cbbaab0989"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 1 },
                    { new Guid("a9ef1d77-4272-49b4-aa5b-77a0b0dbee80"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("ab9d7520-8bdc-4e8a-8e1c-597d8678b846"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 0 },
                    { new Guid("b0572f4e-2e8d-41d8-8bb1-3711f72a58a8"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 2 },
                    { new Guid("b0c59b6f-3213-4ce4-adc6-f8450208d0ab"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 0 },
                    { new Guid("b2d99989-50e6-4a17-a9ae-a7480e127f53"), new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), null, 2 },
                    { new Guid("b64e0711-4ac0-4cf9-aa4d-9e5d2e6167ac"), new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"), null, 1 },
                    { new Guid("b9bc4d99-c0a1-4a67-85f8-b276d406b8f9"), new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), null, 2 },
                    { new Guid("b9ff10df-1674-4c96-8a0b-2c6a5790f58a"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("bbc5b71a-f9c8-4bc4-928e-7cf043fbcac5"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 1 },
                    { new Guid("bda065a6-57f6-4a7e-9d8e-5a976fa1d57f"), new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), null, 2 },
                    { new Guid("c2c0d065-3029-4971-ac6b-4bd326256bbe"), new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"), null, 1 },
                    { new Guid("ce1cd65c-8361-47d1-84c7-f96e6fbc3ed3"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 1 },
                    { new Guid("cf817901-5d82-4394-ba7c-f89466bf2384"), new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"), null, 0 },
                    { new Guid("d2159c46-4ed0-492f-b189-d16d28cac813"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 0 },
                    { new Guid("d3e80909-4838-4a08-bf68-917e7d5de7af"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 2 },
                    { new Guid("d6946216-8d7c-47d0-b272-d780d3b033dc"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 0 },
                    { new Guid("d6967918-e933-4539-9bdf-0abe2d95b0a7"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("d77275d7-fc21-4288-b44b-28d845cc4a75"), new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), null, 1 },
                    { new Guid("d8cd43f1-c23f-4a5c-98d6-ab2ffd9ac952"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 0 },
                    { new Guid("d91ae0ee-5b54-43cb-8070-1b8da1b3175c"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 0 },
                    { new Guid("e120d5f1-f62d-41ad-bbe9-b3b482575115"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 2 },
                    { new Guid("e20c0a42-43ce-4271-a01f-9935df0aa371"), new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), null, 2 },
                    { new Guid("e29817aa-3989-4831-903b-450f638e174e"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 1 },
                    { new Guid("e8321ee2-91dd-470f-aba4-6d3195d24b1a"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 2 },
                    { new Guid("e8377740-6ec2-43fd-8ee8-70508351a088"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 0 },
                    { new Guid("e8744ae4-f299-4ff8-ada8-e23f90845ec3"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("e8d38cf2-f461-46e8-a4b2-6582436ec489"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("e936176e-a4f6-43d4-a060-7e164013496d"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 2 },
                    { new Guid("eac4e213-434d-4dd1-ae8d-90b4cd8a4b7f"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 0 },
                    { new Guid("ec8deff1-7591-4845-920a-2cafb3d5c461"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 0 },
                    { new Guid("eeec2a56-72c0-46c1-8b3b-e61450030ead"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("f2adcd4e-f13c-4dfd-84e9-f4da752a3e05"), new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), null, 0 },
                    { new Guid("f46924fb-f28f-4374-8175-3f50ee53edb3"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 2 },
                    { new Guid("f6cdb6ed-9555-46ba-b8d1-c548c2c9e0ab"), new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), null, 1 },
                    { new Guid("fad3d981-ae34-4af0-8458-f0a9b1dcfc30"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 2 },
                    { new Guid("fb6d47ec-fa02-4573-a76d-daba68e75860"), new Guid("c687f724-506d-448b-9511-e686b91f3dda"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("09803399-58b7-4fa8-a1a9-c7167b6d3615"), new Guid("7006ca97-25b0-4d67-a7a4-b91bc6fc4d16"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0fe4a8e2-569f-4cf1-bf79-0469b3a1b1fb"), new Guid("4746d247-4e52-40e2-8d46-e9c97fd9748d"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("115deabf-638d-486c-bbab-ec0455efa5d3"), new Guid("21c536c4-494c-44f1-84c5-be8fe6145b58"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1474b77c-c36f-4958-954b-5a34bd490776"), new Guid("c2c0d065-3029-4971-ac6b-4bd326256bbe"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("17caf637-4546-4c3f-aa46-d16f5a638818"), new Guid("16aa5a85-50e6-4b37-b310-1ca8ffabd155"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("255062c4-802b-42d2-b56e-a8ce547a9916"), new Guid("1ca457bb-65a3-4368-87a7-cfb4c60fb149"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2c762346-63bf-4c24-857c-8ce60239520f"), new Guid("28e868af-842e-43f2-8a45-447f8e14031c"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2d826f51-fa20-449e-ac91-cf6a80b767f6"), new Guid("ce1cd65c-8361-47d1-84c7-f96e6fbc3ed3"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2e818f47-8877-441e-825c-27898feeda23"), new Guid("78587f17-5dec-4ae4-b4f0-216b0e1866ed"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("370afe36-391d-4138-a401-bd4870cdbd06"), new Guid("86a88a4e-d4aa-44c7-9a56-e0253efc60fc"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("39745302-ad15-42df-b432-bc3c16081ea0"), new Guid("bbc5b71a-f9c8-4bc4-928e-7cf043fbcac5"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3a545999-e75b-4669-8efd-d9d0efe00964"), new Guid("8600bd80-5d2f-4a26-93c9-8ad950b4f87e"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("4ef8dc2d-7f9a-4c36-b3fe-257b26d8621f"), new Guid("1102a15c-bc66-4291-ac12-8069ef385393"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5b8dea20-072e-45c8-b753-07cbd6f70f13"), new Guid("80c3cac4-9b75-431f-93dd-12b3e480281d"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6cf8901a-ea30-445b-a1aa-b2b1e5a6e98a"), new Guid("6c3cc738-65cc-4c63-9cfd-8bdcae010a84"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6df44fe1-0f6a-4dad-b679-0d9f74ae70b1"), new Guid("a4263179-198f-471a-b7f5-747e2aa05c50"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7f3613da-8b4f-4878-bf93-ffc15f0e06d3"), new Guid("20ec3e8b-8c3b-4dee-9da7-093579c71a4f"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("853ceaeb-dcdc-4195-b79c-b5630df37f07"), new Guid("a77ab981-9426-40c4-8289-735bdca7ef3f"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8d0dea4d-196c-4896-b64a-f0db40456284"), new Guid("079638cb-6d07-4ad6-963f-56cfccee80c7"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8d71d320-91e6-46be-b208-8f2672bc4ceb"), new Guid("d77275d7-fc21-4288-b44b-28d845cc4a75"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("904038c7-5b75-4c6f-aa69-ed2b15d0d3e3"), new Guid("a908b462-f860-42eb-aba6-f1cbbaab0989"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a4d17889-a4b3-40c9-a5d1-fc61b6717785"), new Guid("9aa721a3-8746-43c9-b1eb-6476d2dacacc"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a781913f-969b-4331-808b-1099106e3699"), new Guid("52f38433-da32-445e-aeed-769c21c5e6de"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b1f26b4a-437d-45ca-98fb-89820a02dd5a"), new Guid("77b9510b-5310-4a1f-b5ad-3b310fc432ea"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b3f3c7bf-a153-4c02-b8ab-e498e142523f"), new Guid("e29817aa-3989-4831-903b-450f638e174e"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ba6494fa-5df5-4422-a064-0d134f70225a"), new Guid("7d977b68-ea78-4217-b6a4-a16afdc6b18c"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c90959bb-766c-4fd9-8b49-61fbce52b78b"), new Guid("3550d8b6-c72e-47a8-bf8c-3982f945105d"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("cda706c8-5201-4206-ab81-f107eab02844"), new Guid("85c515c7-3ae7-4845-b5ab-043eb413bd22"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e1a1f9af-dc08-4366-a216-9e06cd0d891c"), new Guid("b64e0711-4ac0-4cf9-aa4d-9e5d2e6167ac"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e8974f85-31a8-4569-9422-c694fa0ecc18"), new Guid("f6cdb6ed-9555-46ba-b8d1-c548c2c9e0ab"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogEntries");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("3e0d0ba3-8d04-4700-91bf-f3e3d78129ef"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c72c0bbb-32eb-4676-a628-2b1aea7e434b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04458325-54c3-4f25-b16e-5e8f0fce2562"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("19a2c0cf-b56a-4cc6-9d55-cce66a648bd2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("217e2ead-b9de-4a38-a2ab-995f9515a8b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29a2798b-2d43-429c-b232-704e0e42a61e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2bafac4d-096e-493a-be81-b862350189e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("30dc1b8c-6f90-48ba-8434-dcd5be4d8276"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3273742c-d607-4b81-ae55-3d65b3941f9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3dedc88b-8f8b-403e-9468-e782adfe22ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3df99c7e-dc10-420d-ac5c-9547f930c9bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("428d8f2a-4f09-4f20-bff6-cd9de70e8204"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42aae123-5f81-439c-b85c-86b194f5ac84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("435579ed-f57d-45d5-bfc2-41aeaa03b0bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("461e28c6-ed59-4055-80a7-a34730a367ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4c2cbb8e-f1b7-4bc8-b5b6-0b64a62ae510"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d2cc9be-bb09-44ed-9f37-0e9ef3466926"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("522672d0-5c49-45a0-8533-142c81cfe905"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53e62ef4-f0fe-419b-8e02-34f920862cbb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5694a295-f5ea-46ec-bd54-8f625aa4707c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57650987-400b-4a05-9314-472676a3e68f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d7826ed-31e5-4ae8-93f4-ebd17dd2ff53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("687f20d1-fcb5-40d4-8261-96469633348a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68dd801b-29a6-49e0-9615-1116b02d4f29"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("69a4237b-f0f7-46f3-84c7-08893d583391"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("706c489e-ba97-47d9-b65b-1c131a39acab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("73d4d398-6788-4b58-87ff-dfdc5b977dc9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("740f47fe-fd84-4362-aeee-0466b0361aa9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7748142b-c549-45af-b7e9-7857acf63d63"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77d2ebd2-1446-448f-8099-4a45f20f0ffb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7a0a4ec2-dad5-41e5-9702-0b942b0043dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("812d4f76-5d7e-4801-bb46-826f0521fa65"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("818d1105-03f3-4ea0-adcd-516f3f413842"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("872ff021-0db3-4d31-be94-58d48b8be986"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("874c32cd-7e95-479e-b709-c044b3a43896"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e956fed-01da-421c-8ea4-790d0c14bffa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("97fd701a-3ea5-4420-be7d-0f0d00f31958"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98ddb6e6-db0b-4066-8ac6-d84b0453856a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a42a451-c4a1-4a6c-934a-3ad5315b0bc8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b61bcd3-8c89-4c6e-bbd6-f983861c0a98"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9cdcb892-7152-4032-a402-a9ba267b3b02"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a26434dd-0bce-44c6-b47d-7fa81425e9a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a404267e-8bbf-4d7c-a099-35583479fefa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9ef1d77-4272-49b4-aa5b-77a0b0dbee80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ab9d7520-8bdc-4e8a-8e1c-597d8678b846"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b0572f4e-2e8d-41d8-8bb1-3711f72a58a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b0c59b6f-3213-4ce4-adc6-f8450208d0ab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2d99989-50e6-4a17-a9ae-a7480e127f53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9bc4d99-c0a1-4a67-85f8-b276d406b8f9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9ff10df-1674-4c96-8a0b-2c6a5790f58a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bda065a6-57f6-4a7e-9d8e-5a976fa1d57f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cf817901-5d82-4394-ba7c-f89466bf2384"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d2159c46-4ed0-492f-b189-d16d28cac813"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3e80909-4838-4a08-bf68-917e7d5de7af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6946216-8d7c-47d0-b272-d780d3b033dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6967918-e933-4539-9bdf-0abe2d95b0a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8cd43f1-c23f-4a5c-98d6-ab2ffd9ac952"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d91ae0ee-5b54-43cb-8070-1b8da1b3175c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e120d5f1-f62d-41ad-bbe9-b3b482575115"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e20c0a42-43ce-4271-a01f-9935df0aa371"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8321ee2-91dd-470f-aba4-6d3195d24b1a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8377740-6ec2-43fd-8ee8-70508351a088"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8744ae4-f299-4ff8-ada8-e23f90845ec3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8d38cf2-f461-46e8-a4b2-6582436ec489"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e936176e-a4f6-43d4-a060-7e164013496d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eac4e213-434d-4dd1-ae8d-90b4cd8a4b7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec8deff1-7591-4845-920a-2cafb3d5c461"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eeec2a56-72c0-46c1-8b3b-e61450030ead"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f2adcd4e-f13c-4dfd-84e9-f4da752a3e05"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f46924fb-f28f-4374-8175-3f50ee53edb3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fad3d981-ae34-4af0-8458-f0a9b1dcfc30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb6d47ec-fa02-4573-a76d-daba68e75860"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("09803399-58b7-4fa8-a1a9-c7167b6d3615"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("0fe4a8e2-569f-4cf1-bf79-0469b3a1b1fb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("115deabf-638d-486c-bbab-ec0455efa5d3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1474b77c-c36f-4958-954b-5a34bd490776"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("17caf637-4546-4c3f-aa46-d16f5a638818"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("255062c4-802b-42d2-b56e-a8ce547a9916"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2c762346-63bf-4c24-857c-8ce60239520f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2d826f51-fa20-449e-ac91-cf6a80b767f6"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2e818f47-8877-441e-825c-27898feeda23"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("370afe36-391d-4138-a401-bd4870cdbd06"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("39745302-ad15-42df-b432-bc3c16081ea0"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("3a545999-e75b-4669-8efd-d9d0efe00964"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("4ef8dc2d-7f9a-4c36-b3fe-257b26d8621f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("5b8dea20-072e-45c8-b753-07cbd6f70f13"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("6cf8901a-ea30-445b-a1aa-b2b1e5a6e98a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("6df44fe1-0f6a-4dad-b679-0d9f74ae70b1"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("7f3613da-8b4f-4878-bf93-ffc15f0e06d3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("853ceaeb-dcdc-4195-b79c-b5630df37f07"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8d0dea4d-196c-4896-b64a-f0db40456284"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8d71d320-91e6-46be-b208-8f2672bc4ceb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("904038c7-5b75-4c6f-aa69-ed2b15d0d3e3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("a4d17889-a4b3-40c9-a5d1-fc61b6717785"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("a781913f-969b-4331-808b-1099106e3699"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b1f26b4a-437d-45ca-98fb-89820a02dd5a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b3f3c7bf-a153-4c02-b8ab-e498e142523f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ba6494fa-5df5-4422-a064-0d134f70225a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("c90959bb-766c-4fd9-8b49-61fbce52b78b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("cda706c8-5201-4206-ab81-f107eab02844"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("e1a1f9af-dc08-4366-a216-9e06cd0d891c"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("e8974f85-31a8-4569-9422-c694fa0ecc18"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2ba37673-a6e9-4539-9f68-24921544db84"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("079638cb-6d07-4ad6-963f-56cfccee80c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1102a15c-bc66-4291-ac12-8069ef385393"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("16aa5a85-50e6-4b37-b310-1ca8ffabd155"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1ca457bb-65a3-4368-87a7-cfb4c60fb149"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("20ec3e8b-8c3b-4dee-9da7-093579c71a4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("21c536c4-494c-44f1-84c5-be8fe6145b58"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("28e868af-842e-43f2-8a45-447f8e14031c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3550d8b6-c72e-47a8-bf8c-3982f945105d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4746d247-4e52-40e2-8d46-e9c97fd9748d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52f38433-da32-445e-aeed-769c21c5e6de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c3cc738-65cc-4c63-9cfd-8bdcae010a84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7006ca97-25b0-4d67-a7a4-b91bc6fc4d16"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77b9510b-5310-4a1f-b5ad-3b310fc432ea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78587f17-5dec-4ae4-b4f0-216b0e1866ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d977b68-ea78-4217-b6a4-a16afdc6b18c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80c3cac4-9b75-431f-93dd-12b3e480281d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85c515c7-3ae7-4845-b5ab-043eb413bd22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8600bd80-5d2f-4a26-93c9-8ad950b4f87e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86a88a4e-d4aa-44c7-9a56-e0253efc60fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9aa721a3-8746-43c9-b1eb-6476d2dacacc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4263179-198f-471a-b7f5-747e2aa05c50"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a77ab981-9426-40c4-8289-735bdca7ef3f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a908b462-f860-42eb-aba6-f1cbbaab0989"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b64e0711-4ac0-4cf9-aa4d-9e5d2e6167ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bbc5b71a-f9c8-4bc4-928e-7cf043fbcac5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c2c0d065-3029-4971-ac6b-4bd326256bbe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce1cd65c-8361-47d1-84c7-f96e6fbc3ed3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d77275d7-fc21-4288-b44b-28d845cc4a75"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e29817aa-3989-4831-903b-450f638e174e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6cdb6ed-9555-46ba-b8d1-c548c2c9e0ab"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("b757d55d-529d-4cc8-89ae-82036564055e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("512a64d4-2940-4897-b202-cb519ece9f19"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c687f724-506d-448b-9511-e686b91f3dda"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"));
        }
    }
}
