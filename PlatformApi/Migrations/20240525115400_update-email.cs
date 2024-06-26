﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatformApi.Migrations
{
    public partial class updateemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriptionDate",
                table: "newsLetters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "SubscriptionStatus",
                table: "newsLetters",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionDate",
                table: "newsLetters");

            migrationBuilder.DropColumn(
                name: "SubscriptionStatus",
                table: "newsLetters");
        }
    }
}
