using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD_TrainingService.Migrations
{
    public partial class trainings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    MentorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentorName = table.Column<string>(nullable: false),
                    Mentor_email = table.Column<string>(nullable: false),
                    Mentor_Contact = table.Column<int>(nullable: false),
                    Mentor_Password = table.Column<string>(nullable: false),
                    Mentor_Experience = table.Column<string>(nullable: false),
                    Mentor_skills = table.Column<string>(nullable: true),
                    From_Time_slot = table.Column<string>(nullable: true),
                    To_Time_slot = table.Column<string>(nullable: true),
                    Mentor_Avail = table.Column<bool>(nullable: true),
                    Mentor_active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.MentorId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Student_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(nullable: true),
                    Student_email = table.Column<string>(nullable: true),
                    Student_Contact = table.Column<int>(nullable: false),
                    Student_Password = table.Column<string>(nullable: true),
                    Student_active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Student_Id);
                });

            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    Tech_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tech_name = table.Column<string>(nullable: true),
                    TOC = table.Column<string>(nullable: true),
                    Fees = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.Tech_id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Id = table.Column<long>(nullable: false),
                    Student_Name = table.Column<string>(nullable: true),
                    MentorName = table.Column<string>(nullable: true),
                    MentorId = table.Column<long>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    AmountMentor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentor",
                        principalColumn: "MentorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Student_Student_Id",
                        column: x => x.Student_Id,
                        principalTable: "Student",
                        principalColumn: "Student_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Training_id = table.Column<string>(nullable: false),
                    Student_Id = table.Column<long>(nullable: false),
                    MentorId = table.Column<long>(nullable: false),
                    Tech_id = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    timeslot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Training_id);
                    table.ForeignKey(
                        name: "FK_Training_Mentor_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentor",
                        principalColumn: "MentorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Student_Student_Id",
                        column: x => x.Student_Id,
                        principalTable: "Student",
                        principalColumn: "Student_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Technology_Tech_id",
                        column: x => x.Tech_id,
                        principalTable: "Technology",
                        principalColumn: "Tech_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_MentorId",
                table: "Payment",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Student_Id",
                table: "Payment",
                column: "Student_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorId",
                table: "Training",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Student_Id",
                table: "Training",
                column: "Student_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Tech_id",
                table: "Training",
                column: "Tech_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Technology");
        }
    }
}
