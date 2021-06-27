using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROYECTO_BD_POO_FINAL.Migrations
{
    public partial class changeInttoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BOOTH",
                columns: table => new
                {
                    id_booth = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booth_address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    telephone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOOTH__16D433C1E66E6F7D", x => x.id_booth);
                });

            migrationBuilder.CreateTable(
                name: "CHRONIC_DISEASE",
                columns: table => new
                {
                    id_chronic_disease = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chronic_disease = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    chronic_disease_description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHRONIC___6BD38E9733B49E02", x => x.id_chronic_disease);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE_TYPE",
                columns: table => new
                {
                    id_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typename = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EMPLOYEE__C3F091E0738ED4A3", x => x.id_type);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUTION",
                columns: table => new
                {
                    id_institution = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    institution = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INSTITUT__512A185C97148AC6", x => x.id_institution);
                });

            migrationBuilder.CreateTable(
                name: "SIDE_EFFECT",
                columns: table => new
                {
                    id_side_effect = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    side_effect = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    side_effect_description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SIDE_EFF__1301EE9AD63AD170", x => x.id_side_effect);
                });

            migrationBuilder.CreateTable(
                name: "VACCINATION_PLACE",
                columns: table => new
                {
                    id_vaccination_place = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vaccination_place = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    vaccination_place_address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VACCINAT__5C434F1ABEE9653A", x => x.id_vaccination_place);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    id_employee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    employee_address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    employee_username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    employee_password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    id_type = table.Column<int>(type: "int", nullable: false),
                    id_booth = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EMPLOYEE__F807679CDA4D226D", x => x.id_employee);
                    table.ForeignKey(
                        name: "FK__EMPLOYEE__id_boo__412EB0B6",
                        column: x => x.id_booth,
                        principalTable: "BOOTH",
                        principalColumn: "id_booth",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__EMPLOYEE__id_typ__403A8C7D",
                        column: x => x.id_type,
                        principalTable: "EMPLOYEE_TYPE",
                        principalColumn: "id_type",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CITIZEN",
                columns: table => new
                {
                    id_citizen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dui = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    citizen_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    citizen_address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    telephone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    id_institution = table.Column<int>(type: "int", nullable: false),
                    disability = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CITIZEN__44393B8660898FC1", x => x.id_citizen);
                    table.ForeignKey(
                        name: "FK__CITIZEN__id_inst__46E78A0C",
                        column: x => x.id_institution,
                        principalTable: "INSTITUTION",
                        principalColumn: "id_institution",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MANAGEMENT",
                columns: table => new
                {
                    id_management = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_employee = table.Column<int>(type: "int", nullable: false),
                    id_booth = table.Column<int>(type: "int", nullable: false),
                    date_time_login = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MANAGEME__33C4FBFCD7708510", x => x.id_management);
                    table.ForeignKey(
                        name: "FK__MANAGEMEN__id_bo__4222D4EF",
                        column: x => x.id_booth,
                        principalTable: "BOOTH",
                        principalColumn: "id_booth",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MANAGEMEN__id_em__4316F928",
                        column: x => x.id_employee,
                        principalTable: "EMPLOYEE",
                        principalColumn: "id_employee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APPOINTMENT",
                columns: table => new
                {
                    id_appointment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time_appointment_1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_time_appointment_2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    id_employee = table.Column<int>(type: "int", nullable: false),
                    id_vaccination_place = table.Column<int>(type: "int", nullable: false),
                    id_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APPOINTM__F9CC20B753720BDD", x => x.id_appointment);
                    table.ForeignKey(
                        name: "FK__APPOINTME__id_ci__45F365D3",
                        column: x => x.id_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "id_citizen",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__APPOINTME__id_em__440B1D61",
                        column: x => x.id_employee,
                        principalTable: "EMPLOYEE",
                        principalColumn: "id_employee",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__APPOINTME__id_va__44FF419A",
                        column: x => x.id_vaccination_place,
                        principalTable: "VACCINATION_PLACE",
                        principalColumn: "id_vaccination_place",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CITIZENxCHRONIC_DISEASE",
                columns: table => new
                {
                    id_chronic_disease = table.Column<int>(type: "int", nullable: false),
                    id_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CITIZENx__1F901D2FCB2816CE", x => new { x.id_chronic_disease, x.id_citizen });
                    table.ForeignKey(
                        name: "FK__CITIZENxC__id_ch__4AB81AF0",
                        column: x => x.id_chronic_disease,
                        principalTable: "CHRONIC_DISEASE",
                        principalColumn: "id_chronic_disease",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__CITIZENxC__id_ci__49C3F6B7",
                        column: x => x.id_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "id_citizen",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VACCINATION",
                columns: table => new
                {
                    id_vaccination = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time_wait_1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_time_vaccine_1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_time_wait_2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_time_vaccine_2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    id_citizen = table.Column<int>(type: "int", nullable: false),
                    id_vaccination_place = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VACCINAT__6F9C338C69882D94", x => x.id_vaccination);
                    table.ForeignKey(
                        name: "FK__VACCINATI__id_ci__47DBAE45",
                        column: x => x.id_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "id_citizen",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__VACCINATI__id_va__48CFD27E",
                        column: x => x.id_vaccination_place,
                        principalTable: "VACCINATION_PLACE",
                        principalColumn: "id_vaccination_place",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VACCINATIONxSIDE_EFFECT",
                columns: table => new
                {
                    id_side_effect = table.Column<int>(type: "int", nullable: false),
                    id_vaccination = table.Column<int>(type: "int", nullable: false),
                    date_time_showup = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VACCINAT__C5F82DA2F663B080", x => new { x.id_side_effect, x.id_vaccination });
                    table.ForeignKey(
                        name: "FK__VACCINATI__id_si__4BAC3F29",
                        column: x => x.id_side_effect,
                        principalTable: "SIDE_EFFECT",
                        principalColumn: "id_side_effect",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__VACCINATI__id_va__4CA06362",
                        column: x => x.id_vaccination,
                        principalTable: "VACCINATION",
                        principalColumn: "id_vaccination",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_id_citizen",
                table: "APPOINTMENT",
                column: "id_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_id_employee",
                table: "APPOINTMENT",
                column: "id_employee");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_id_vaccination_place",
                table: "APPOINTMENT",
                column: "id_vaccination_place");

            migrationBuilder.CreateIndex(
                name: "UQ__BOOTH__61AE339B8707F9B9",
                table: "BOOTH",
                column: "telephone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CITIZEN_id_institution",
                table: "CITIZEN",
                column: "id_institution");

            migrationBuilder.CreateIndex(
                name: "UQ__CITIZEN__61AE339B879AC2F9",
                table: "CITIZEN",
                column: "telephone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__CITIZEN__D876F1BFDBA309A3",
                table: "CITIZEN",
                column: "dui",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CITIZENxCHRONIC_DISEASE_id_citizen",
                table: "CITIZENxCHRONIC_DISEASE",
                column: "id_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_id_booth",
                table: "EMPLOYEE",
                column: "id_booth");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_id_type",
                table: "EMPLOYEE",
                column: "id_type");

            migrationBuilder.CreateIndex(
                name: "UQ__EMPLOYEE__AB6E61643B3CD28E",
                table: "EMPLOYEE",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MANAGEMENT_id_booth",
                table: "MANAGEMENT",
                column: "id_booth");

            migrationBuilder.CreateIndex(
                name: "IX_MANAGEMENT_id_employee",
                table: "MANAGEMENT",
                column: "id_employee");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINATION_id_citizen",
                table: "VACCINATION",
                column: "id_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINATION_id_vaccination_place",
                table: "VACCINATION",
                column: "id_vaccination_place");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINATIONxSIDE_EFFECT_id_vaccination",
                table: "VACCINATIONxSIDE_EFFECT",
                column: "id_vaccination");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPOINTMENT");

            migrationBuilder.DropTable(
                name: "CITIZENxCHRONIC_DISEASE");

            migrationBuilder.DropTable(
                name: "MANAGEMENT");

            migrationBuilder.DropTable(
                name: "VACCINATIONxSIDE_EFFECT");

            migrationBuilder.DropTable(
                name: "CHRONIC_DISEASE");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");

            migrationBuilder.DropTable(
                name: "SIDE_EFFECT");

            migrationBuilder.DropTable(
                name: "VACCINATION");

            migrationBuilder.DropTable(
                name: "BOOTH");

            migrationBuilder.DropTable(
                name: "EMPLOYEE_TYPE");

            migrationBuilder.DropTable(
                name: "CITIZEN");

            migrationBuilder.DropTable(
                name: "VACCINATION_PLACE");

            migrationBuilder.DropTable(
                name: "INSTITUTION");
        }
    }
}
