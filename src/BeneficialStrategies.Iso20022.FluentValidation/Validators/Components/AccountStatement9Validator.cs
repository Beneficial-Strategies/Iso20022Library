// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AccountStatement9"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _91eAC248EeiU9cctagi5ow
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
public class AccountStatement9Validator : AbstractValidator<AccountStatement9>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="AccountStatement9"/>.
    /// </summary>
    public AccountStatement9Validator()
    {
        // Identification (Max35Text): required (1..1) and already `required` C# property — no
        // rule needed.
        // ElectronicSequenceNumber, LegalSequenceNumber, CreationDateTime, CopyDuplicateIndicator,
        // AdditionalStatementInformation: optional (0..1) scalars, no sub-constraints — no
        // rule needed.
        // FromToDate (DateTimePeriod1), RelatedAccount (CashAccount38), ReportingSequence
        // (SequenceRange1Choice), ReportingSource (ReportingSource1Choice), TransactionsSummary
        // (TotalTransactions6), StatementPagination (Pagination1): optional (0..1) components
        // with no validator yet — nested fields unvalidated.
        // Account (CashAccount39): required (1..1) component, no validator yet — nested fields
        // unvalidated.
        // Interest (AccountInterest4) and Entry (ReportEntry10): 0..∞ collections — any size
        // including empty is valid, no rule needed.

        // Balance: CashBalance8, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Balance)
            .NotEmpty()
            .WithMessage("AccountStatement9.Balance must contain at least one element (1..*).");
    }
}
