using Microsoft.EntityFrameworkCore.Migrations;

namespace PROYECTO_BD_POO_FINAL.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__VACCINAT__C5F82DA2F663B080",
                table: "VACCINATIONxSIDE_EFFECT");

            migrationBuilder.DropPrimaryKey(
                name: "PK__VACCINAT__5C434F1ABEE9653A",
                table: "VACCINATION_PLACE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__VACCINAT__6F9C338C69882D94",
                table: "VACCINATION");

            migrationBuilder.DropPrimaryKey(
                name: "PK__SIDE_EFF__1301EE9AD63AD170",
                table: "SIDE_EFFECT");

            migrationBuilder.DropPrimaryKey(
                name: "PK__MANAGEME__33C4FBFCD7708510",
                table: "MANAGEMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK__INSTITUT__512A185C97148AC6",
                table: "INSTITUTION");

            migrationBuilder.DropPrimaryKey(
                name: "PK__EMPLOYEE__C3F091E0738ED4A3",
                table: "EMPLOYEE_TYPE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__EMPLOYEE__F807679CDA4D226D",
                table: "EMPLOYEE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__CITIZENx__1F901D2FCB2816CE",
                table: "CITIZENxCHRONIC_DISEASE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__CITIZEN__44393B8660898FC1",
                table: "CITIZEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK__CHRONIC___6BD38E9733B49E02",
                table: "CHRONIC_DISEASE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BOOTH__16D433C1E66E6F7D",
                table: "BOOTH");

            migrationBuilder.DropPrimaryKey(
                name: "PK__APPOINTM__F9CC20B753720BDD",
                table: "APPOINTMENT");

            migrationBuilder.RenameIndex(
                name: "UQ__EMPLOYEE__AB6E61643B3CD28E",
                table: "EMPLOYEE",
                newName: "UQ__EMPLOYEE__AB6E6164A9B228ED");

            migrationBuilder.RenameIndex(
                name: "UQ__CITIZEN__D876F1BFDBA309A3",
                table: "CITIZEN",
                newName: "UQ__CITIZEN__D876F1BFBBBC09C6");

            migrationBuilder.RenameIndex(
                name: "UQ__CITIZEN__61AE339B879AC2F9",
                table: "CITIZEN",
                newName: "UQ__CITIZEN__61AE339B179EBB30");

            migrationBuilder.RenameIndex(
                name: "UQ__BOOTH__61AE339B8707F9B9",
                table: "BOOTH",
                newName: "UQ__BOOTH__61AE339BE2441342");

            migrationBuilder.AddPrimaryKey(
                name: "PK__VACCINAT__C5F82DA2135E4AAD",
                table: "VACCINATIONxSIDE_EFFECT",
                columns: new[] { "id_side_effect", "id_vaccination" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__VACCINAT__5C434F1AF368A40F",
                table: "VACCINATION_PLACE",
                column: "id_vaccination_place");

            migrationBuilder.AddPrimaryKey(
                name: "PK__VACCINAT__6F9C338CDB25CDB2",
                table: "VACCINATION",
                column: "id_vaccination");

            migrationBuilder.AddPrimaryKey(
                name: "PK__SIDE_EFF__1301EE9A216973CA",
                table: "SIDE_EFFECT",
                column: "id_side_effect");

            migrationBuilder.AddPrimaryKey(
                name: "PK__MANAGEME__33C4FBFCEF24CB1C",
                table: "MANAGEMENT",
                column: "id_management");

            migrationBuilder.AddPrimaryKey(
                name: "PK__INSTITUT__512A185C72DC062A",
                table: "INSTITUTION",
                column: "id_institution");

            migrationBuilder.AddPrimaryKey(
                name: "PK__EMPLOYEE__C3F091E0EA84F535",
                table: "EMPLOYEE_TYPE",
                column: "id_type");

            migrationBuilder.AddPrimaryKey(
                name: "PK__EMPLOYEE__F807679CE875A6AC",
                table: "EMPLOYEE",
                column: "id_employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK__CITIZENx__1F901D2FA802FF45",
                table: "CITIZENxCHRONIC_DISEASE",
                columns: new[] { "id_chronic_disease", "id_citizen" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__CITIZEN__44393B86C995009C",
                table: "CITIZEN",
                column: "id_citizen");

            migrationBuilder.AddPrimaryKey(
                name: "PK__CHRONIC___6BD38E97AAB18AA8",
                table: "CHRONIC_DISEASE",
                column: "id_chronic_disease");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BOOTH__16D433C13AAA55BA",
                table: "BOOTH",
                column: "id_booth");

            migrationBuilder.AddPrimaryKey(
                name: "PK__APPOINTM__F9CC20B71396F311",
                table: "APPOINTMENT",
                column: "id_appointment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__VACCINAT__C5F82DA2135E4AAD",
                table: "VACCINATIONxSIDE_EFFECT");

            migrationBuilder.DropPrimaryKey(
                name: "PK__VACCINAT__5C434F1AF368A40F",
                table: "VACCINATION_PLACE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__VACCINAT__6F9C338CDB25CDB2",
                table: "VACCINATION");

            migrationBuilder.DropPrimaryKey(
                name: "PK__SIDE_EFF__1301EE9A216973CA",
                table: "SIDE_EFFECT");

            migrationBuilder.DropPrimaryKey(
                name: "PK__MANAGEME__33C4FBFCEF24CB1C",
                table: "MANAGEMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK__INSTITUT__512A185C72DC062A",
                table: "INSTITUTION");

            migrationBuilder.DropPrimaryKey(
                name: "PK__EMPLOYEE__C3F091E0EA84F535",
                table: "EMPLOYEE_TYPE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__EMPLOYEE__F807679CE875A6AC",
                table: "EMPLOYEE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__CITIZENx__1F901D2FA802FF45",
                table: "CITIZENxCHRONIC_DISEASE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__CITIZEN__44393B86C995009C",
                table: "CITIZEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK__CHRONIC___6BD38E97AAB18AA8",
                table: "CHRONIC_DISEASE");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BOOTH__16D433C13AAA55BA",
                table: "BOOTH");

            migrationBuilder.DropPrimaryKey(
                name: "PK__APPOINTM__F9CC20B71396F311",
                table: "APPOINTMENT");

            migrationBuilder.RenameIndex(
                name: "UQ__EMPLOYEE__AB6E6164A9B228ED",
                table: "EMPLOYEE",
                newName: "UQ__EMPLOYEE__AB6E61643B3CD28E");

            migrationBuilder.RenameIndex(
                name: "UQ__CITIZEN__D876F1BFBBBC09C6",
                table: "CITIZEN",
                newName: "UQ__CITIZEN__D876F1BFDBA309A3");

            migrationBuilder.RenameIndex(
                name: "UQ__CITIZEN__61AE339B179EBB30",
                table: "CITIZEN",
                newName: "UQ__CITIZEN__61AE339B879AC2F9");

            migrationBuilder.RenameIndex(
                name: "UQ__BOOTH__61AE339BE2441342",
                table: "BOOTH",
                newName: "UQ__BOOTH__61AE339B8707F9B9");

            migrationBuilder.AddPrimaryKey(
                name: "PK__VACCINAT__C5F82DA2F663B080",
                table: "VACCINATIONxSIDE_EFFECT",
                columns: new[] { "id_side_effect", "id_vaccination" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__VACCINAT__5C434F1ABEE9653A",
                table: "VACCINATION_PLACE",
                column: "id_vaccination_place");

            migrationBuilder.AddPrimaryKey(
                name: "PK__VACCINAT__6F9C338C69882D94",
                table: "VACCINATION",
                column: "id_vaccination");

            migrationBuilder.AddPrimaryKey(
                name: "PK__SIDE_EFF__1301EE9AD63AD170",
                table: "SIDE_EFFECT",
                column: "id_side_effect");

            migrationBuilder.AddPrimaryKey(
                name: "PK__MANAGEME__33C4FBFCD7708510",
                table: "MANAGEMENT",
                column: "id_management");

            migrationBuilder.AddPrimaryKey(
                name: "PK__INSTITUT__512A185C97148AC6",
                table: "INSTITUTION",
                column: "id_institution");

            migrationBuilder.AddPrimaryKey(
                name: "PK__EMPLOYEE__C3F091E0738ED4A3",
                table: "EMPLOYEE_TYPE",
                column: "id_type");

            migrationBuilder.AddPrimaryKey(
                name: "PK__EMPLOYEE__F807679CDA4D226D",
                table: "EMPLOYEE",
                column: "id_employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK__CITIZENx__1F901D2FCB2816CE",
                table: "CITIZENxCHRONIC_DISEASE",
                columns: new[] { "id_chronic_disease", "id_citizen" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__CITIZEN__44393B8660898FC1",
                table: "CITIZEN",
                column: "id_citizen");

            migrationBuilder.AddPrimaryKey(
                name: "PK__CHRONIC___6BD38E9733B49E02",
                table: "CHRONIC_DISEASE",
                column: "id_chronic_disease");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BOOTH__16D433C1E66E6F7D",
                table: "BOOTH",
                column: "id_booth");

            migrationBuilder.AddPrimaryKey(
                name: "PK__APPOINTM__F9CC20B753720BDD",
                table: "APPOINTMENT",
                column: "id_appointment");
        }
    }
}
