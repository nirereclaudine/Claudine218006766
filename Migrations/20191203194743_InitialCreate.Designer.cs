﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pome.Data;

namespace pome.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20191203194743_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("Product_apprication.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("product_description")
                        .HasColumnType("TEXT");

                    b.Property<string>("product_image")
                        .HasColumnType("TEXT");

                    b.Property<string>("product_name")
                        .HasColumnType("TEXT");

                    b.Property<float>("product_price")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("time_expired")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
