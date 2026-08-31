// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace RequestToPayDebtorActivation.Demo.Persistence;

/// <summary>
/// EF Core context backing the saga's MySQL persistence. Exists only to prove
/// <c>DebtorActivationSagaState</c> genuinely round-trips through a real database between saga
/// transitions — MassTransit's <c>EntityFrameworkSagaRepository</c> loads/saves an instance of
/// this on every correlated event, so nothing here is a demo-only shortcut: this is the real
/// persistence path a production deployment of this saga would use, just pointed at a throwaway
/// local MySQL container instead of a managed one.
/// </summary>
internal sealed class DebtorActivationSagaDbContext(DbContextOptions<DebtorActivationSagaDbContext> options)
    : DbContext(options)
{
    public DbSet<DebtorActivationSagaState> Sagas => Set<DebtorActivationSagaState>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DebtorActivationSagaState>(b =>
        {
            b.ToTable("debtor_activation_saga");
            b.HasKey(x => x.CorrelationId);

            b.Property(x => x.CurrentState).HasMaxLength(64).IsRequired();
            // ISO 20022 Max35Text — the widest of the message-identification fields this saga
            // correlates on.
            b.Property(x => x.LastMessageIdentification).HasMaxLength(35).IsRequired();
            b.Property(x => x.OriginalMessageIdentification).HasMaxLength(35).IsRequired();
            b.Property(x => x.PartyIdentityKey).HasMaxLength(256);

            // See Iso20022JsonValueConverter's own remarks: these columns hold the SAME JSON
            // serialization this library uses for real wire payloads (Iso20022JsonSerializerOptions
            // .Default), not an ad hoc demo format. Pomelo maps "json" to MySQL's native JSON
            // column type.
            b.Property(x => x.Debtor).HasConversion(Iso20022JsonValueConverter.ForClass<RTPPartyIdentification2>()).HasColumnType("json");
            b.Property(x => x.Creditor).HasConversion(Iso20022JsonValueConverter.ForClass<RTPPartyIdentification2>()).HasColumnType("json");
            b.Property(x => x.DebtorSolutionProvider).HasConversion(Iso20022JsonValueConverter.ForClass<RTPPartyIdentification2>()).HasColumnType("json");
            b.Property(x => x.UltimateDebtor).HasConversion(Iso20022JsonValueConverter.ForClass<RTPPartyIdentification2>()).HasColumnType("json");
            b.Property(x => x.EffectiveActivationDate).HasConversion(Iso20022JsonValueConverter.ForClass<DateAndDateTime2Choice_>()).HasColumnType("json");

            // A plain ISO codeset enum, but still routed through the shared JSON converter rather
            // than EF's built-in enum-to-string conversion — that would persist the .NET member
            // name ("Accepted"), not the ISO wire code the [EnumMember] attribute actually defines.
            // Kept as a small "json"-typed column (a bare quoted string) purely for consistency
            // with the other converted columns above, not because it needs JSON structure.
            b.Property(x => x.LastStatus).HasConversion(Iso20022JsonValueConverter.ForStruct<ServiceRequestStatus1Code>()).HasColumnType("json");

            b.Property(x => x.ReviewNote).HasMaxLength(1024);
        });
    }
}
