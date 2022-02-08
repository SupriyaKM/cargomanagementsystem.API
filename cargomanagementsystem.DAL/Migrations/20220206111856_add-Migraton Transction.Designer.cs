﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cargomanagementsystem.DAL.Data;

namespace cargomanagementsystem.DAL.Migrations
{
    [DbContext(typeof(cargomanagementDbContext))]
    [Migration("20220206111856_add-Migraton Transction")]
    partial class addMigratonTransction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.Cust_details", b =>
                {
                    b.Property<int>("Sender_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Receiver_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Receiver_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Receiver_id")
                        .HasColumnType("int");

                    b.Property<int>("Receiver_mobno")
                        .HasColumnType("int");

                    b.Property<string>("Receiver_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Receiver_pincode")
                        .HasColumnType("int");

                    b.Property<string>("Sender_City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sender_mobno")
                        .HasColumnType("int");

                    b.Property<string>("Sender_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sender_pincode")
                        .HasColumnType("int");

                    b.HasKey("Sender_id");

                    b.ToTable("Customer_Details");
                });

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.Transaction", b =>
                {
                    b.Property<int>("Bill_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Goods_Qty")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sending_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trans_amount")
                        .HasColumnType("int");

                    b.Property<string>("Type_of_Goods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("customerid")
                        .HasColumnType("int");

                    b.HasKey("Bill_no");

                    b.HasIndex("customerid");

                    b.ToTable("Transaction_Details");
                });

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.cargomanagementRegister", b =>
                {
                    b.Property<string>("Emailid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emailid");

                    b.ToTable("Register");
                });

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.Transaction", b =>
                {
                    b.HasOne("cargomanagementsystem.Entity.Model.Cust_details", "Sender_id")
                        .WithMany()
                        .HasForeignKey("customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender_id");
                });
#pragma warning restore 612, 618
        }
    }
}
