// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cargomanagementsystem.DAL.Data;

namespace cargomanagementsystem.DAL.Migrations
{
    [DbContext(typeof(cargomanagementDbContext))]
    [Migration("20220204145137_CargoCreate")]
    partial class CargoCreate
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

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.cargomanagementRegister", b =>
                {
                    b.Property<string>("CustEmailid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Confirmpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Custname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Custpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.HasKey("CustEmailid");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
