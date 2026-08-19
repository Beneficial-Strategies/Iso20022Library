// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AccountStatement6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _VDVqMTqwEeWZFYSPlduMhw
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>Balance</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public class AccountStatement6Validator : AbstractValidator<AccountStatement6>
{
    public AccountStatement6Validator()
    {
        // Identification (Max35Text) and CreationDateTime (ISODateTime): required (1..1) and
        // already `required` C# properties — no rule needed.
        // ElectronicSequenceNumber, LegalSequenceNumber, CopyDuplicateIndicator,
        // AdditionalStatementInformation: optional (0..1) scalars, no sub-constraints — no
        // rule needed.
        // FromToDate (DateTimePeriodDetails), RelatedAccount (CashAccount24),
        // TransactionsSummary (TotalTransactions5), ReportingSource (ReportingSource1Choice),
        // StatementPagination (Pagination): optional (0..1) components with no validator yet —
        // nested fields unvalidated.
        // Account (CashAccount25): required (1..1) component, no validator yet — nested fields
        // unvalidated.
        // Interest (AccountInterest3) and Entry (ReportEntry8): 0..∞ collections — any size
        // including empty is valid, no rule needed.

        // Balance: CashBalance7, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Balance)
            .NotEmpty()
            .WithMessage("AccountStatement6.Balance must contain at least one element (1..*).");
    }
}
