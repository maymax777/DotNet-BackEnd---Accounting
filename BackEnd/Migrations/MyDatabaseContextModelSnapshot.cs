﻿// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    partial class MyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Models.AuthRoleModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("created_by");

                    b.Property<DateTime>("created_date");

                    b.Property<bool>("deleteRole");

                    b.Property<string>("menu");

                    b.Property<bool>("printRole");

                    b.Property<int>("roll_id");

                    b.Property<bool>("saveRole");

                    b.Property<bool>("status");

                    b.Property<bool>("updateRole");

                    b.Property<bool>("viewRole");

                    b.HasKey("id");

                    b.ToTable("tbl_authrole");
                });

            modelBuilder.Entity("BackEnd.Models.BankModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("acc_number");

                    b.Property<string>("acc_type");

                    b.Property<int?>("branch");

                    b.Property<int>("created_by");

                    b.Property<DateTime>("created_date");

                    b.Property<string>("level_value");

                    b.Property<string>("name");

                    b.Property<bool>("status");

                    b.Property<string>("swift_code");

                    b.Property<string>("url");

                    b.HasKey("id");

                    b.ToTable("tbl_bank");
                });

            modelBuilder.Entity("BackEnd.Models.Branch", b =>
                {
                    b.Property<int>("Branch_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Branch_Code");

                    b.Property<string>("Branch_Name");

                    b.Property<int>("Created_by");

                    b.Property<DateTime>("Created_date");

                    b.Property<string>("Email_Id");

                    b.Property<string>("Telephone_No");

                    b.HasKey("Branch_Id");

                    b.ToTable("tbl_Branch");
                });

            modelBuilder.Entity("BackEnd.Models.ChartOfAccountModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_by");

                    b.Property<string>("Ledger_name");

                    b.Property<int>("Mast_Code");

                    b.Property<bool>("Status");

                    b.Property<DateTime>("created_date");

                    b.Property<bool>("is_ledger");

                    b.Property<bool>("is_subledger");

                    b.Property<int>("ledger_Code");

                    b.Property<int>("ledger_Group");

                    b.HasKey("id");

                    b.ToTable("tbl_chartofacc");
                });

            modelBuilder.Entity("BackEnd.Models.CompanyModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Country");

                    b.Property<int>("Createdby");

                    b.Property<string>("Email");

                    b.Property<string>("Logo");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<int>("Pan");

                    b.Property<string>("Regd");

                    b.Property<string>("StateCity");

                    b.Property<string>("Telephone");

                    b.Property<string>("Website");

                    b.HasKey("ID");

                    b.ToTable("tbl_Company");
                });

            modelBuilder.Entity("BackEnd.Models.FiscalModel", b =>
                {
                    b.Property<int>("Fiscal_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_by");

                    b.Property<DateTime>("Created_date");

                    b.Property<string>("Fiscalyear");

                    b.Property<DateTime>("Fromdate");

                    b.Property<bool>("Status");

                    b.Property<DateTime>("Todate");

                    b.HasKey("Fiscal_Id");

                    b.ToTable("tbl_Fiscal");
                });

            modelBuilder.Entity("BackEnd.Models.ProductGroupModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("created_by");

                    b.Property<DateTime>("created_date");

                    b.Property<string>("group_name");

                    b.Property<int>("ledger_code");

                    b.Property<bool>("status");

                    b.HasKey("id");

                    b.ToTable("tbl_pro_group");
                });

            modelBuilder.Entity("BackEnd.Models.ProductServiceModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("barcode");

                    b.Property<int>("created_by");

                    b.Property<DateTime>("created_date");

                    b.Property<string>("d_name");

                    b.Property<int>("e_account");

                    b.Property<int>("i_account");

                    b.Property<string>("image");

                    b.Property<bool>("istaxable");

                    b.Property<int>("p_group");

                    b.Property<string>("p_name");

                    b.Property<decimal>("p_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("p_type");

                    b.Property<int>("qtyonhand");

                    b.Property<int>("reorder");

                    b.Property<decimal>("s_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("status");

                    b.Property<int>("taxtype");

                    b.HasKey("id");

                    b.ToTable("tbl_product");
                });

            modelBuilder.Entity("BackEnd.Models.TransactionModel", b =>
                {
                    b.Property<int>("Tr_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_by");

                    b.Property<decimal>("Credit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Debit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Fiscal")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Gl_type")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Narration")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("Status");

                    b.Property<int>("Trans_Id");

                    b.Property<string>("Vouc_No")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("branch_id");

                    b.Property<int>("ledger_Code");

                    b.Property<int>("project_id");

                    b.Property<string>("tran_type")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Tr_Id");

                    b.ToTable("tbl_Transaction");
                });

            modelBuilder.Entity("BackEnd.Models.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Branch_Id");

                    b.Property<int>("Created_by");

                    b.Property<int>("Emp_Id");

                    b.Property<string>("Password");

                    b.Property<int>("Roll_Id");

                    b.Property<int>("Status");

                    b.Property<string>("Token");

                    b.Property<string>("Useremail");

                    b.Property<string>("Username");

                    b.HasKey("User_Id");

                    b.ToTable("tbl_User");
                });

            modelBuilder.Entity("BackEnd.Models.UserLogModel", b =>
                {
                    b.Property<int>("SN")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity");

                    b.Property<DateTime>("Datetime");

                    b.Property<string>("Event");

                    b.Property<string>("Type");

                    b.Property<int>("Username");

                    b.HasKey("SN");

                    b.ToTable("tbl_Userlog");
                });

            modelBuilder.Entity("BackEnd.Models.UserRoleModel", b =>
                {
                    b.Property<int>("Roll_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_by");

                    b.Property<string>("Rollname");

                    b.Property<bool>("Status");

                    b.HasKey("Roll_Id");

                    b.ToTable("tbl_User_Roll");
                });
#pragma warning restore 612, 618
        }
    }
}
