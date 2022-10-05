using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Lab_5_6_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chucvu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chucvu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Giohang",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    IDKhach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giohang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Khachhang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    SepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sep",
                        column: x => x.SepId,
                        principalTable: "Nhanvien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sanpham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Giatien = table.Column<decimal>(type: "decimal", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanpham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chitietchucvu",
                columns: table => new
                {
                    ChucvuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhanvienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietchucvu", x => new { x.NhanvienId, x.ChucvuId });
                    table.ForeignKey(
                        name: "FK_Chucvu",
                        column: x => x.ChucvuId,
                        principalTable: "Chucvu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nhanvien",
                        column: x => x.NhanvienId,
                        principalTable: "Nhanvien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiohangChitiet",
                columns: table => new
                {
                    IDSanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGiohang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluong = table.Column<decimal>(type: "Decimal", nullable: false),
                    Giatien = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiohangChitiet", x => new { x.IDGiohang, x.IDSanpham });
                    table.ForeignKey(
                        name: "FK_Giohang2",
                        column: x => x.IDGiohang,
                        principalTable: "Giohang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sanpham",
                        column: x => x.IDSanpham,
                        principalTable: "Sanpham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hoadon",
                columns: table => new
                {
                    GiohangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhanvienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachhangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadon", x => x.GiohangId);
                    table.ForeignKey(
                        name: "FK",
                        column: x => x.GiohangId,
                        principalTable: "Giohang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoadon_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Voucher",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Khachhang",
                        column: x => x.KhachhangId,
                        principalTable: "Khachhang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nhanvien11",
                        column: x => x.NhanvienId,
                        principalTable: "Nhanvien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chitietchucvu_ChucvuId",
                table: "Chitietchucvu",
                column: "ChucvuId");

            migrationBuilder.CreateIndex(
                name: "IX_GiohangChitiet_IDSanpham",
                table: "GiohangChitiet",
                column: "IDSanpham");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_KhachhangId",
                table: "Hoadon",
                column: "KhachhangId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_NhanvienId",
                table: "Hoadon",
                column: "NhanvienId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_VoucherId",
                table: "Hoadon",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_Nhanvien_SepId",
                table: "Nhanvien",
                column: "SepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chitietchucvu");

            migrationBuilder.DropTable(
                name: "GiohangChitiet");

            migrationBuilder.DropTable(
                name: "Hoadon");

            migrationBuilder.DropTable(
                name: "Chucvu");

            migrationBuilder.DropTable(
                name: "Sanpham");

            migrationBuilder.DropTable(
                name: "Giohang");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "Khachhang");

            migrationBuilder.DropTable(
                name: "Nhanvien");
        }
    }
}
