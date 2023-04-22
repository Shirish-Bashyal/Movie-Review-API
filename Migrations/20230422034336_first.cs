using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Review_API.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Director", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Reviewer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Reviewer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rating = table.Column<double>(type: "float", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Movie_tbl_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "tbl_Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Movie_tbl_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "tbl_Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Movie_tbl_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "tbl_Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Reviews_tbl_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "tbl_Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Reviews_tbl_Reviewer_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "tbl_Reviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Movie_CountryId",
                table: "tbl_Movie",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Movie_DirectorId",
                table: "tbl_Movie",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Movie_GenreId",
                table: "tbl_Movie",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Reviews_MovieId",
                table: "tbl_Reviews",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Reviews_ReviewerId",
                table: "tbl_Reviews",
                column: "ReviewerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Reviews");

            migrationBuilder.DropTable(
                name: "tbl_Movie");

            migrationBuilder.DropTable(
                name: "tbl_Reviewer");

            migrationBuilder.DropTable(
                name: "tbl_Country");

            migrationBuilder.DropTable(
                name: "tbl_Director");

            migrationBuilder.DropTable(
                name: "tbl_Genre");
        }
    }
}
