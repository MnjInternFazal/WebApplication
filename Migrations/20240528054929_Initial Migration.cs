using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SocialSecurityNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MartialStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PanCardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.PersonalId);
                });

            migrationBuilder.CreateTable(
                name: "Add_Qualification",
                columns: table => new
                {
                    ProgramID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Program = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Institute = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Add_Qualification", x => x.ProgramID);
                    table.ForeignKey(
                        name: "FK_Add_Qualification_PersonalDetails",
                        column: x => x.PersonalId,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalId");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Address_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HouseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Period = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InstantMessagingId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Address_PersonalDetails",
                        column: x => x.PersonalId,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalId");
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    EducationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YOP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDurationFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CourseDurationTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScoreType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CGPAValue = table.Column<int>(type: "int", nullable: true),
                    CGPAScale = table.Column<int>(type: "int", nullable: true),
                    CGPAPercentage = table.Column<int>(type: "int", nullable: true),
                    TotalMarks = table.Column<int>(type: "int", nullable: true),
                    MaxMarks = table.Column<int>(type: "int", nullable: true),
                    MarkPercentage = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Education_PersonalDetails_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalId");
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    FamilyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateOnly>(type: "date", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.FamilyId);
                    table.ForeignKey(
                        name: "FK_Family_PersonalDetails",
                        column: x => x.PersonalId,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalId");
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    LanguageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Speak = table.Column<bool>(type: "bit", nullable: true),
                    Read = table.Column<bool>(type: "bit", nullable: true),
                    Write = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_Languages_PersonalDetails",
                        column: x => x.PersonalId,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalId");
                });

            migrationBuilder.CreateTable(
                name: "Passport",
                columns: table => new
                {
                    PassportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfExpiry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HasValidVisa = table.Column<bool>(type: "bit", nullable: true),
                    IsOpenToTravel = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport", x => x.PassportId);
                    table.ForeignKey(
                        name: "FK_Passport_PersonalDetails",
                        column: x => x.PersonalId,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalId");
                });

            migrationBuilder.CreateTable(
                name: "Seminar",
                columns: table => new
                {
                    SeminarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    SeminarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConductedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationFrom = table.Column<DateOnly>(type: "date", nullable: true),
                    DurationTo = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminar", x => x.SeminarId);
                    table.ForeignKey(
                        name: "FK_Seminar_PersonalDetails_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Add_Qualification_PersonalId",
                table: "Add_Qualification",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonalId",
                table: "Address",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_PersonalId",
                table: "Education",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Family_PersonalId",
                table: "Family",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_PersonalId",
                table: "Languages",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Passport_PersonalId",
                table: "Passport",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Seminar_PersonalId",
                table: "Seminar",
                column: "PersonalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Add_Qualification");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Passport");

            migrationBuilder.DropTable(
                name: "Seminar");

            migrationBuilder.DropTable(
                name: "PersonalDetails");
        }
    }
}
