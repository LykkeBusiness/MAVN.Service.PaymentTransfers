﻿// <auto-generated />
using System;
using Lykke.Service.PaymentTransfers.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.PaymentTransfers.MsSqlRepositories.Migrations
{
    [DbContext(typeof(PaymentTransfersContext))]
    [Migration("20191121095538_AddSfAsPrefixForSalesforceSpecificFields")]
    partial class AddSfAsPrefixForSalesforceSpecificFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("payment_transfers")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.PaymentTransfers.MsSqlRepositories.PaymentTransferEntity", b =>
                {
                    b.Property<string>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("transfer_id");

                    b.Property<decimal>("AmountInFiat")
                        .HasColumnName("amount_in_fiat)");

                    b.Property<string>("AmountInTokens")
                        .IsRequired()
                        .HasColumnName("amount_in_tokens)");

                    b.Property<string>("CampaignId")
                        .IsRequired()
                        .HasColumnName("campaign_id");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnName("currency)");

                    b.Property<string>("CustomerAccountNumber")
                        .IsRequired()
                        .HasColumnName("sf_customer_account_number");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("CustomerTrxId")
                        .IsRequired()
                        .HasColumnName("sf_customer_trx_id");

                    b.Property<string>("InstallmentType")
                        .IsRequired()
                        .HasColumnName("sf_installment_type");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnName("invoice_id");

                    b.Property<string>("LocationCode")
                        .IsRequired()
                        .HasColumnName("sf_location_code");

                    b.Property<string>("ReceiptNumber")
                        .IsRequired()
                        .HasColumnName("sf_receipt_number");

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("TransferId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Status");

                    b.ToTable("payment_transfers");
                });
#pragma warning restore 612, 618
        }
    }
}
