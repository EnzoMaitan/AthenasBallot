using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AthenasBallot.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ballots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BallotStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ballots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    LogoImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    InitialDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemOperators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistryDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemOperators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistryDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StudentNumber = table.Column<string>(nullable: true),
                    StudentClass = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Sex = table.Column<string>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    PartyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Parties_PartyID",
                        column: x => x.PartyID,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BallotRegistries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SystemOperatorID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    BallotID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallotRegistries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BallotRegistries_Ballots_BallotID",
                        column: x => x.BallotID,
                        principalTable: "Ballots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BallotRegistries_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BallotRegistries_SystemOperators_SystemOperatorID",
                        column: x => x.SystemOperatorID,
                        principalTable: "SystemOperators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateProcesses",
                columns: table => new
                {
                    CandidateID = table.Column<int>(nullable: false),
                    ProcessID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateProcesses", x => new { x.CandidateID, x.ProcessID });
                    table.ForeignKey(
                        name: "FK_CandidateProcesses_Student_CandidateID",
                        column: x => x.CandidateID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateProcesses_Processes_ProcessID",
                        column: x => x.ProcessID,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoteRegistries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VoterID = table.Column<int>(nullable: false),
                    ProcessID = table.Column<int>(nullable: false),
                    BallotID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteRegistries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteRegistries_Ballots_BallotID",
                        column: x => x.BallotID,
                        principalTable: "Ballots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoteRegistries_Processes_ProcessID",
                        column: x => x.ProcessID,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoteRegistries_Student_VoterID",
                        column: x => x.VoterID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BallotRegistries_BallotID",
                table: "BallotRegistries",
                column: "BallotID");

            migrationBuilder.CreateIndex(
                name: "IX_BallotRegistries_StudentID",
                table: "BallotRegistries",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_BallotRegistries_SystemOperatorID",
                table: "BallotRegistries",
                column: "SystemOperatorID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateProcesses_ProcessID",
                table: "CandidateProcesses",
                column: "ProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_PartyID",
                table: "Student",
                column: "PartyID");

            migrationBuilder.CreateIndex(
                name: "IX_VoteRegistries_BallotID",
                table: "VoteRegistries",
                column: "BallotID");

            migrationBuilder.CreateIndex(
                name: "IX_VoteRegistries_ProcessID",
                table: "VoteRegistries",
                column: "ProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_VoteRegistries_VoterID",
                table: "VoteRegistries",
                column: "VoterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BallotRegistries");

            migrationBuilder.DropTable(
                name: "CandidateProcesses");

            migrationBuilder.DropTable(
                name: "VoteRegistries");

            migrationBuilder.DropTable(
                name: "SystemOperators");

            migrationBuilder.DropTable(
                name: "Ballots");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Parties");
        }
    }
}
