using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Models
{
    public partial class lcContext : DbContext
    {
        public lcContext()
        {
        }

        public lcContext(DbContextOptions<lcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Balance> Balances { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<File> Files { get; set; } = null!;
        public virtual DbSet<Good> Goods { get; set; } = null!;
        public virtual DbSet<Lc> Lcs { get; set; } = null!;
        public virtual DbSet<Merchant> Merchants { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Priority> Priorities { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CIRES-SAIDII;Initial Catalog=lc;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.HasIndex(e => e.AccountLc, "account_lc_fk");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountLc).HasColumnName("account_lc");

                entity.Property(e => e.AccountPass)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("account_pass");

                entity.Property(e => e.AccountPassalt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("account_passalt");

                entity.Property(e => e.AccountUsername)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("account_username");

                entity.HasOne(d => d.AccountLcNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountLc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("account_lc_fk");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("address");

                entity.HasIndex(e => e.AddressContact, "account_address_fk");

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("address_city");

                entity.Property(e => e.AddressContact).HasColumnName("address_contact");

                entity.Property(e => e.AddressHousenumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("address_housenumber");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.AddressStreet)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address_street");

                entity.Property(e => e.AddressZipcode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("address_zipcode");

                entity.HasOne(d => d.AddressContactNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AddressContact)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("account_address_fk");
            });

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("balance");

                entity.HasIndex(e => e.BalanceAccount, "balance_account_fk");

                entity.Property(e => e.BalanceAccount).HasColumnName("balance_account");

                entity.Property(e => e.BalanceId).HasColumnName("balance_id");

                entity.Property(e => e.BalanceMoney).HasColumnName("balance_money");

                entity.HasOne(d => d.BalanceAccountNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.BalanceAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("balance_account_fk");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.ContactCustomer).HasColumnName("contact_customer");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact_email");

                entity.Property(e => e.ContactMobile1)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("contact_mobile1");

                entity.Property(e => e.ContactMobile2)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("contact_mobile2");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("contact_phone");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasIndex(e => e.CustomerAccount, "customer_account_pk");

                entity.HasIndex(e => e.CustomerContact, "customer_contact_pk");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerAccount).HasColumnName("customer_account");

                entity.Property(e => e.CustomerContact).HasColumnName("customer_contact");

                entity.Property(e => e.CustomerFamilyname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("customer_familyname");

                entity.Property(e => e.CustomerFirstname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("customer_firstname");

                entity.Property(e => e.CustomerUsername)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("customer_username");

                entity.HasOne(d => d.CustomerAccountNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_account");

                entity.HasOne(d => d.CustomerAccount1)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_contact");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("files");

                entity.HasIndex(e => e.FilesAccount, "files_account_pk");

                entity.Property(e => e.FilesAccount).HasColumnName("files_account");

                entity.Property(e => e.FilesDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("files_desc");

                entity.Property(e => e.FilesId).HasColumnName("files_id");

                entity.Property(e => e.FilesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("files_name");

                entity.Property(e => e.FilesPath)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("files_path");

                entity.HasOne(d => d.FilesAccountNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FilesAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("files_account_pk");
            });

            modelBuilder.Entity<Good>(entity =>
            {
                entity.HasKey(e => e.GoodsId)
                    .HasName("PK__goods__40BA22395B09B114");

                entity.ToTable("goods");

                entity.HasIndex(e => e.GoodsMerchant, "goods_merchant_pk");

                entity.Property(e => e.GoodsId).HasColumnName("goods_id");

                entity.Property(e => e.GoodsMerchant).HasColumnName("goods_merchant");

                entity.Property(e => e.GoodsName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("goods_name");

                entity.Property(e => e.GoodsNumber).HasColumnName("goods_number");

                entity.Property(e => e.GoodsPrice).HasColumnName("goods_price");
            });

            modelBuilder.Entity<Lc>(entity =>
            {
                entity.ToTable("lc");

                entity.HasIndex(e => e.LcContact, "lc_contact_fk");

                entity.Property(e => e.LcId).HasColumnName("lc_id");

                entity.Property(e => e.LcContact).HasColumnName("lc_contact");

                entity.Property(e => e.LcName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("lc_name");

                entity.Property(e => e.LcSerie)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lc_serie");

                entity.HasOne(d => d.LcContactNavigation)
                    .WithMany(p => p.Lcs)
                    .HasForeignKey(d => d.LcContact)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lc_contact_fk");
            });

            modelBuilder.Entity<Merchant>(entity =>
            {
                entity.ToTable("merchant");

                entity.HasIndex(e => e.MerchantAccount, "merchant_account_pk");

                entity.HasIndex(e => e.MerchantContact, "merchant_contact");

                entity.Property(e => e.MerchantId).HasColumnName("merchant_id");

                entity.Property(e => e.MerchantAccount).HasColumnName("merchant_account");

                entity.Property(e => e.MerchantCompany).HasColumnName("merchant_company");

                entity.Property(e => e.MerchantContact).HasColumnName("merchant_contact");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("merchant_name");

                entity.Property(e => e.MerchantType).HasColumnName("merchant_type");

                entity.Property(e => e.MerchantUsername)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("merchant_username");

                entity.HasOne(d => d.MerchantAccountNavigation)
                    .WithMany(p => p.Merchants)
                    .HasForeignKey(d => d.MerchantAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_merchant_account");

                entity.HasOne(d => d.MerchantContactNavigation)
                    .WithMany(p => p.Merchants)
                    .HasForeignKey(d => d.MerchantContact)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_merchant_contact");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notification");

                entity.HasIndex(e => e.NotificationAccount, "notification_account_pk");

                entity.HasIndex(e => e.NotificationPriority, "notification_priority_pk");

                entity.Property(e => e.NotificationId).HasColumnName("notification_id");

                entity.Property(e => e.NotificationAccount).HasColumnName("notification_account");

                entity.Property(e => e.NotificationDate)
                    .HasColumnType("date")
                    .HasColumnName("notification_date");

                entity.Property(e => e.NotificationDesc)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("notification_desc");

                entity.Property(e => e.NotificationLabel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("notification_label");

                entity.Property(e => e.NotificationPriority).HasColumnName("notification_priority");

                entity.HasOne(d => d.NotificationAccountNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_notification_account");

                entity.HasOne(d => d.NotificationPriorityNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationPriority)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_notification_priority");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.OrderCostumer, "order_costumer_pk");

                entity.HasIndex(e => e.OrderGoods, "order_goods_pk");

                entity.HasIndex(e => e.OrderMerchant, "order_merchant_pk");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderCostumer).HasColumnName("order_costumer");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderGoods).HasColumnName("order_goods");

                entity.Property(e => e.OrderMerchant).HasColumnName("order_merchant");

                entity.Property(e => e.Rest).HasColumnName("rest");

                entity.HasOne(d => d.OrderCostumerNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderCostumer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orders_customer");

                entity.HasOne(d => d.OrderGoodsNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderGoods)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orders_goods");

                entity.HasOne(d => d.OrderMerchantNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderMerchant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orders_merchant");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.ToTable("priority");

                entity.Property(e => e.PriorityId).HasColumnName("priority_id");

                entity.Property(e => e.PriorityIcon)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("priority_icon");

                entity.Property(e => e.PriorityLabel)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("priority_label");

                entity.Property(e => e.PriorityLevel).HasColumnName("priority_level");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.HasIndex(e => e.TransactionOrder, "transaction_order_pk");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("transaction_date");

                entity.Property(e => e.TransactionNumber).HasColumnName("transaction_number");

                entity.Property(e => e.TransactionOrder).HasColumnName("transaction_order");

                entity.Property(e => e.TransactionState).HasColumnName("transaction_state");

                entity.HasOne(d => d.TransactionOrderNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransactionOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transaction_order_pk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
