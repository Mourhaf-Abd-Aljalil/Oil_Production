using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OilProduction.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Farmers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adderss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalMealProduction = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutriens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutriens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Presses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<double>(type: "float", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soils",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamType = table.Column<int>(type: "int", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherConditions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaindLevel = table.Column<double>(type: "float", nullable: false),
                    WindLevel = table.Column<double>(type: "float", nullable: false),
                    DateRecorded = table.Column<DateOnly>(type: "date", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nut1Id = table.Column<long>(type: "bigint", nullable: false),
                    Nut2Id = table.Column<long>(type: "bigint", nullable: false),
                    Nut3Id = table.Column<long>(type: "bigint", nullable: false),
                    Nut4Id = table.Column<long>(type: "bigint", nullable: false),
                    Nut5Id = table.Column<long>(type: "bigint", nullable: false),
                    Nut1Amount = table.Column<double>(type: "float", nullable: false),
                    Nut2Amount = table.Column<double>(type: "float", nullable: false),
                    Nut3Amount = table.Column<double>(type: "float", nullable: false),
                    Nut4Amount = table.Column<double>(type: "float", nullable: false),
                    Nut5Amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descriptions_Nutriens_Nut1Id",
                        column: x => x.Nut1Id,
                        principalTable: "Nutriens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Descriptions_Nutriens_Nut2Id",
                        column: x => x.Nut2Id,
                        principalTable: "Nutriens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Descriptions_Nutriens_Nut3Id",
                        column: x => x.Nut3Id,
                        principalTable: "Nutriens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Descriptions_Nutriens_Nut4Id",
                        column: x => x.Nut4Id,
                        principalTable: "Nutriens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Descriptions_Nutriens_Nut5Id",
                        column: x => x.Nut5Id,
                        principalTable: "Nutriens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoilId = table.Column<long>(type: "bigint", nullable: false),
                    FarmerId = table.Column<long>(type: "bigint", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Farms_Farmers_FarmerId",
                        column: x => x.FarmerId,
                        principalTable: "Farmers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Soils_SoilId",
                        column: x => x.SoilId,
                        principalTable: "Soils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamWorkJobs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<long>(type: "bigint", nullable: false),
                    WorkId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    JobId1 = table.Column<long>(type: "bigint", nullable: true),
                    TeamId1 = table.Column<long>(type: "bigint", nullable: true),
                    WorkId1 = table.Column<long>(type: "bigint", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamWorkJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamWorkJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamWorkJobs_Jobs_JobId1",
                        column: x => x.JobId1,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeamWorkJobs_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamWorkJobs_Teams_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeamWorkJobs_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamWorkJobs_Works_WorkId1",
                        column: x => x.WorkId1,
                        principalTable: "Works",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamWorks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    IsManeger = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamWorks_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamWorks_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fertilizers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldestTestAge = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fertilizers_Descriptions_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Descriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreesFarms",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmId = table.Column<long>(type: "bigint", nullable: false),
                    TreeId = table.Column<long>(type: "bigint", nullable: false),
                    DatePlanted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsedPersentage = table.Column<double>(type: "float", nullable: false),
                    TreeSpacing = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreesFarms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreesFarms_Farms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "Farms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreesFarms_Trees_TreeId",
                        column: x => x.TreeId,
                        principalTable: "Trees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreeFarmId = table.Column<long>(type: "bigint", nullable: false),
                    TreeFarmsId = table.Column<long>(type: "bigint", nullable: false),
                    HarvestedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ProductionQuantity = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crops_TreesFarms_TreeFarmsId",
                        column: x => x.TreeFarmsId,
                        principalTable: "TreesFarms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreeFarmFertilizers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FertilizerId = table.Column<long>(type: "bigint", nullable: false),
                    FertilizersId = table.Column<long>(type: "bigint", nullable: false),
                    TreeFarmId = table.Column<long>(type: "bigint", nullable: false),
                    TreesFarmsId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeFarmFertilizers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreeFarmFertilizers_Fertilizers_FertilizersId",
                        column: x => x.FertilizersId,
                        principalTable: "Fertilizers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreeFarmFertilizers_TreesFarms_TreesFarmsId",
                        column: x => x.TreesFarmsId,
                        principalTable: "TreesFarms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreeFarmTeams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    TreeFarmId = table.Column<long>(type: "bigint", nullable: false),
                    TreesFarmsId = table.Column<long>(type: "bigint", nullable: false),
                    IsCrop = table.Column<bool>(type: "bit", nullable: false),
                    AmountCollected = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeFarmTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreeFarmTeams_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreeFarmTeams_TreesFarms_TreesFarmsId",
                        column: x => x.TreesFarmsId,
                        principalTable: "TreesFarms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseasesCrops",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropId = table.Column<long>(type: "bigint", nullable: false),
                    DiseaseId = table.Column<long>(type: "bigint", nullable: false),
                    DiseasesId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasesCrops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiseasesCrops_Crops_CropId",
                        column: x => x.CropId,
                        principalTable: "Crops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseasesCrops_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PressOrders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropId = table.Column<long>(type: "bigint", nullable: false),
                    PressId = table.Column<long>(type: "bigint", nullable: false),
                    PressesId = table.Column<long>(type: "bigint", nullable: false),
                    MealId = table.Column<long>(type: "bigint", nullable: false),
                    OrderQuantity = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PressOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PressOrders_Crops_CropId",
                        column: x => x.CropId,
                        principalTable: "Crops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PressOrders_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PressOrders_Presses_PressesId",
                        column: x => x.PressesId,
                        principalTable: "Presses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeatherCrops",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropId = table.Column<long>(type: "bigint", nullable: false),
                    WeatherId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherCrops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeatherCrops_Crops_CropId",
                        column: x => x.CropId,
                        principalTable: "Crops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeatherCrops_WeatherConditions_WeatherId",
                        column: x => x.WeatherId,
                        principalTable: "WeatherConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crops_TreeFarmsId",
                table: "Crops",
                column: "TreeFarmsId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_Nut1Id",
                table: "Descriptions",
                column: "Nut1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_Nut2Id",
                table: "Descriptions",
                column: "Nut2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_Nut3Id",
                table: "Descriptions",
                column: "Nut3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_Nut4Id",
                table: "Descriptions",
                column: "Nut4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_Nut5Id",
                table: "Descriptions",
                column: "Nut5Id");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasesCrops_CropId",
                table: "DiseasesCrops",
                column: "CropId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasesCrops_DiseasesId",
                table: "DiseasesCrops",
                column: "DiseasesId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_FarmerId",
                table: "Farms",
                column: "FarmerId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_SoilId",
                table: "Farms",
                column: "SoilId");

            migrationBuilder.CreateIndex(
                name: "IX_Fertilizers_DescriptionId",
                table: "Fertilizers",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PressOrders_CropId",
                table: "PressOrders",
                column: "CropId");

            migrationBuilder.CreateIndex(
                name: "IX_PressOrders_MealId",
                table: "PressOrders",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_PressOrders_PressesId",
                table: "PressOrders",
                column: "PressesId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorkJobs_JobId",
                table: "TeamWorkJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorkJobs_JobId1",
                table: "TeamWorkJobs",
                column: "JobId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorkJobs_TeamId",
                table: "TeamWorkJobs",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorkJobs_TeamId1",
                table: "TeamWorkJobs",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorkJobs_WorkId",
                table: "TeamWorkJobs",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorkJobs_WorkId1",
                table: "TeamWorkJobs",
                column: "WorkId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorks_TeamId",
                table: "TeamWorks",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWorks_WorkId",
                table: "TeamWorks",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeFarmFertilizers_FertilizersId",
                table: "TreeFarmFertilizers",
                column: "FertilizersId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeFarmFertilizers_TreesFarmsId",
                table: "TreeFarmFertilizers",
                column: "TreesFarmsId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeFarmTeams_TeamId",
                table: "TreeFarmTeams",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeFarmTeams_TreesFarmsId",
                table: "TreeFarmTeams",
                column: "TreesFarmsId");

            migrationBuilder.CreateIndex(
                name: "IX_TreesFarms_FarmId",
                table: "TreesFarms",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_TreesFarms_TreeId",
                table: "TreesFarms",
                column: "TreeId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherCrops_CropId",
                table: "WeatherCrops",
                column: "CropId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherCrops_WeatherId",
                table: "WeatherCrops",
                column: "WeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_JobId",
                table: "Works",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseasesCrops");

            migrationBuilder.DropTable(
                name: "PressOrders");

            migrationBuilder.DropTable(
                name: "TeamWorkJobs");

            migrationBuilder.DropTable(
                name: "TeamWorks");

            migrationBuilder.DropTable(
                name: "TreeFarmFertilizers");

            migrationBuilder.DropTable(
                name: "TreeFarmTeams");

            migrationBuilder.DropTable(
                name: "WeatherCrops");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Presses");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Fertilizers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Crops");

            migrationBuilder.DropTable(
                name: "WeatherConditions");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "TreesFarms");

            migrationBuilder.DropTable(
                name: "Nutriens");

            migrationBuilder.DropTable(
                name: "Farms");

            migrationBuilder.DropTable(
                name: "Trees");

            migrationBuilder.DropTable(
                name: "Farmers");

            migrationBuilder.DropTable(
                name: "Soils");
        }
    }
}
