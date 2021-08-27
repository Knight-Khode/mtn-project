using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Church_Web.Migrations
{
    public partial class addedCoreBusinessTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChurchLists",
                columns: table => new
                {
                    ChurchID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChurchName = table.Column<string>(type: "text", nullable: true),
                    ChurchDetails = table.Column<string>(type: "text", nullable: true),
                    ChurchMsisdn = table.Column<string>(type: "text", nullable: true),
                    ChurchAddress = table.Column<string>(type: "text", nullable: true),
                    ChurchCounty = table.Column<string>(type: "text", nullable: true),
                    AppPassword = table.Column<string>(type: "text", nullable: true),
                    AppUser = table.Column<string>(type: "text", nullable: true),
                    ChurchDateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChurchLists", x => x.ChurchID);
                });

            migrationBuilder.CreateTable(
                name: "EbuCusComments",
                columns: table => new
                {
                    EbuCusCommentsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Comments = table.Column<string>(type: "text", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbuCusComments", x => x.EbuCusCommentsId);
                    table.ForeignKey(
                        name: "FK_EbuCusComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParentComments",
                columns: table => new
                {
                    ParentCommentID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CommentM = table.Column<string>(type: "text", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    VID = table.Column<string>(type: "text", nullable: true),
                    CID = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentComments", x => x.ParentCommentID);
                    table.ForeignKey(
                        name: "FK_ParentComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChurchMembers",
                columns: table => new
                {
                    ChurchMemberID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateSubscribe = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ChurchId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChurchMembers", x => x.ChurchMemberID);
                    table.ForeignKey(
                        name: "FK_ChurchMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChurchMembers_ChurchLists_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "ChurchLists",
                        principalColumn: "ChurchID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpComingEvents",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventName = table.Column<string>(type: "text", nullable: true),
                    EventDescription = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ChurchID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpComingEvents", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_UpComingEvents_ChurchLists_ChurchID",
                        column: x => x.ChurchID,
                        principalTable: "ChurchLists",
                        principalColumn: "ChurchID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoLists",
                columns: table => new
                {
                    VideoListID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VID = table.Column<string>(type: "text", nullable: true),
                    STRMDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    STRMURL = table.Column<string>(type: "text", nullable: true),
                    EmbedHtml = table.Column<string>(type: "text", nullable: true),
                    Creationtime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Churchthumbnail = table.Column<string>(type: "text", nullable: true),
                    Alerts = table.Column<string>(type: "text", nullable: true),
                    VidStatus = table.Column<string>(type: "text", nullable: true),
                    Lblply = table.Column<string>(type: "text", nullable: true),
                    ChurchPic = table.Column<string>(type: "text", nullable: true),
                    ChurchId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLists", x => x.VideoListID);
                    table.ForeignKey(
                        name: "FK_VideoLists_ChurchLists_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "ChurchLists",
                        principalColumn: "ChurchID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChildComments",
                columns: table => new
                {
                    ChildCommentID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ParentCommentID = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildComments", x => x.ChildCommentID);
                    table.ForeignKey(
                        name: "FK_ChildComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChildComments_ParentComments_ParentCommentID",
                        column: x => x.ParentCommentID,
                        principalTable: "ParentComments",
                        principalColumn: "ParentCommentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Currency = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<string>(type: "text", nullable: true),
                    PaymentType = table.Column<string>(type: "text", nullable: true),
                    Remark = table.Column<string>(type: "text", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    OPAtransID = table.Column<string>(type: "text", nullable: true),
                    XReferenceID = table.Column<string>(type: "text", nullable: true),
                    Desc = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ChurchMembersID = table.Column<string>(type: "text", nullable: true),
                    ChurchMembersChurchMemberID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_ChurchMembers_ChurchMembersChurchMemberID",
                        column: x => x.ChurchMembersChurchMemberID,
                        principalTable: "ChurchMembers",
                        principalColumn: "ChurchMemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildComments_ParentCommentID",
                table: "ChildComments",
                column: "ParentCommentID");

            migrationBuilder.CreateIndex(
                name: "IX_ChildComments_UserId",
                table: "ChildComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChurchMembers_ChurchId",
                table: "ChurchMembers",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_ChurchMembers_UserId",
                table: "ChurchMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EbuCusComments_UserId",
                table: "EbuCusComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentComments_UserId",
                table: "ParentComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ChurchMembersChurchMemberID",
                table: "Payments",
                column: "ChurchMembersChurchMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpComingEvents_ChurchID",
                table: "UpComingEvents",
                column: "ChurchID");

            migrationBuilder.CreateIndex(
                name: "IX_VideoLists_ChurchId",
                table: "VideoLists",
                column: "ChurchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildComments");

            migrationBuilder.DropTable(
                name: "EbuCusComments");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "UpComingEvents");

            migrationBuilder.DropTable(
                name: "VideoLists");

            migrationBuilder.DropTable(
                name: "ParentComments");

            migrationBuilder.DropTable(
                name: "ChurchMembers");

            migrationBuilder.DropTable(
                name: "ChurchLists");
        }
    }
}
