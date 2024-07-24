﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using react_chat_app_backend.Context;

#nullable disable

namespace react_chat_app_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("react_chat_app_backend.Models.MessageData", b =>
                {
                    b.Property<string>("senderId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("receiverId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("senderId");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
