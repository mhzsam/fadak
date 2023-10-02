using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class addUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 26, 20, 9, 30, 818, DateTimeKind.Local).AddTicks(7436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 646, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "UserRols",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 26, 20, 9, 30, 819, DateTimeKind.Local).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 26, 20, 9, 30, 819, DateTimeKind.Local).AddTicks(1232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.InsertData(
                table: "Rols",
                columns: new[] { "Id", "IsActive", "RoleName" },
                values: new object[] { 1, true, "SuperAdmin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2023, 6, 26, 20, 9, 31, 426, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.InsertData(
                table: "UserRols",
                columns: new[] { "Id", "DeletedDate", "InsertDate", "RoleId", "UpdateBy", "UpdateDate", "UserId" },
                values: new object[] { 1, null, new DateTime(2023, 6, 26, 20, 9, 31, 426, DateTimeKind.Local).AddTicks(9742), 1, null, null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRols",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rols",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 646, DateTimeKind.Local).AddTicks(9810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 26, 20, 9, 30, 818, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "UserRols",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 26, 20, 9, 30, 819, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(3659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 26, 20, 9, 30, 819, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2023, 6, 23, 19, 25, 26, 302, DateTimeKind.Local).AddTicks(6146));
        }
    }
}
