using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetBankingProject.Migrations
{
    public partial class ApplicationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountRights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RetailUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryModeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RetailUsers_DeliveryModes_DeliveryModeId",
                        column: x => x.DeliveryModeId,
                        principalTable: "DeliveryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RetailAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteFlag = table.Column<bool>(type: "bit", nullable: false),
                    RetailUserId = table.Column<int>(type: "int", nullable: false),
                    DeliveryModeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RetailAccounts_DeliveryModes_DeliveryModeId",
                        column: x => x.DeliveryModeId,
                        principalTable: "DeliveryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RetailAccounts_RetailUsers_RetailUserId",
                        column: x => x.RetailUserId,
                        principalTable: "RetailUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountRights",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DeleteFlag", "IsActive", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, "Pamela", new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(6823), new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(7152), true, true, " Admin", " Stan" },
                    { 2, "Pamela", new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(8033), new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(8038), true, true, " Admin", " Isaac" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryModes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DeleteFlag", "IsActive", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, "Pamela", new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(4086), true, true, " Admin", " Emmauel" },
                    { 2, "Pamela", new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(5003), new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(5008), true, true, " Admin", " Isaac" }
                });

            migrationBuilder.InsertData(
                table: "RetailUsers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DeleteFlag", "DeliveryModeId", "Email", "FirstName", "IsActive", "LastName", "MiddleName", "ModifiedBy", "Password", "Phone", "UserId" },
                values: new object[] { 1, "Pamela", new DateTime(2022, 1, 29, 15, 30, 2, 955, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 1, 29, 15, 30, 2, 956, DateTimeKind.Local).AddTicks(8668), true, 1, "Samuelo@gmail.com ", " Samuel", true, " Osoufia", "Ajayi", " Admin", "forever222", "+2348124536609", 1 });

            migrationBuilder.InsertData(
                table: "RetailUsers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DeleteFlag", "DeliveryModeId", "Email", "FirstName", "IsActive", "LastName", "MiddleName", "ModifiedBy", "Password", "Phone", "UserId" },
                values: new object[] { 2, "Pamela", new DateTime(2022, 1, 29, 15, 30, 2, 956, DateTimeKind.Local).AddTicks(9833), new DateTime(2022, 1, 29, 15, 30, 2, 956, DateTimeKind.Local).AddTicks(9839), true, 2, " abasa@gmail.com", " Abayomi", true, " Osoufia", "Abas", " Admin", "forever12345", "+2347124536609", 2 });

            migrationBuilder.InsertData(
                table: "RetailAccounts",
                columns: new[] { "Id", "AccountLimit", "AccountType", "CreatedBy", "Currency", "CustomerId", "DateCreated", "DateModified", "DeleteFlag", "DeliveryModeId", "ModifiedBy", "Name", "RetailUserId", "Rights" },
                values: new object[] { 1, 10000000m, "Current", "Pamela", "Naira", 1, new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(1705), new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(2034), true, null, " Admin", " Emmauel", 1, " Customer" });

            migrationBuilder.InsertData(
                table: "RetailAccounts",
                columns: new[] { "Id", "AccountLimit", "AccountType", "CreatedBy", "Currency", "CustomerId", "DateCreated", "DateModified", "DeleteFlag", "DeliveryModeId", "ModifiedBy", "Name", "RetailUserId", "Rights" },
                values: new object[] { 2, 20000000m, "Savings", "Pamela", "Naira", 2, new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(3180), new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(3184), true, null, " Admin", " Steph", 1, " Customer" });

            migrationBuilder.CreateIndex(
                name: "IX_RetailAccounts_DeliveryModeId",
                table: "RetailAccounts",
                column: "DeliveryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailAccounts_RetailUserId",
                table: "RetailAccounts",
                column: "RetailUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailUsers_DeliveryModeId",
                table: "RetailUsers",
                column: "DeliveryModeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRights");

            migrationBuilder.DropTable(
                name: "RetailAccounts");

            migrationBuilder.DropTable(
                name: "RetailUsers");

            migrationBuilder.DropTable(
                name: "DeliveryModes");
        }
    }
}
