using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class initdatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 646, DateTimeKind.Local).AddTicks(9810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 15, 36, 387, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "UserRols",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 15, 36, 387, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(3659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 15, 36, 387, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "MobileNumber" },
                values: new object[] { new DateTime(2023, 6, 23, 19, 25, 26, 167, DateTimeKind.Local).AddTicks(2775), "09120198177" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NationalCode",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 15, 36, 387, DateTimeKind.Local).AddTicks(2277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 646, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "UserRols",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 15, 36, 387, DateTimeKind.Local).AddTicks(5790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 23, 19, 15, 36, 387, DateTimeKind.Local).AddTicks(7807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 23, 19, 25, 25, 647, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "MobileNumber" },
                values: new object[] { new DateTime(2023, 6, 23, 19, 15, 36, 798, DateTimeKind.Local).AddTicks(1272), 0 });
        }
    }
}
