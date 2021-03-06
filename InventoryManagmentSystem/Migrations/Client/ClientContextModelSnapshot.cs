// <auto-generated />
using InventoryManagmentSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryManagmentSystem.Migrations.Client
{
    [DbContext(typeof(ClientContext))]
    partial class ClientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("InventoryManagmentSystem.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNo")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CreditAllowed")
                        .HasColumnType("INTEGER");

                    b.Property<double>("CreditLimit")
                        .HasColumnType("REAL");

                    b.Property<string>("Disrict")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<double>("OpeiningBalance")
                        .HasColumnType("REAL");

                    b.Property<string>("PinCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
