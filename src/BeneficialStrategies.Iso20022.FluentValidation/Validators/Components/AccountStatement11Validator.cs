// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AccountStatement11"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _zoNd0StwEeysar7zFstVmw
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
public class AccountStatement11Validator : AbstractValidator<AccountStatement11>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="AccountStatement11"/>.
    /// </summary>
    public AccountStatement11Validator()
    {
        // Identification (Max35Text): required (1..1), already `required` C# property — no
        // rule needed.
        // ElectronicSequenceNumber, LegalSequenceNumber, CopyDuplicateIndicator,
        // CreationDateTime, AdditionalStatementInformation: optional (0..1) scalars, no
        // sub-constraints — no rule needed.
        // StatementPagination (Pagination1), FromToDate (DateTimePeriod1), RelatedAccount
        // (CashAccount40), TransactionsSummary (TotalTransactions6): optional (0..1)
        // components with no validator yet — nested fields unvalidated.
        // Account (CashAccount41): required (1..1) component, no validator yet — nested
        // fields unvalidated.
        // Interest (AccountInterest4) and Entry (ReportEntry12): 0..∞ collections — any
        // size including empty is valid, no rule needed.
        // ReportingSequence (SequenceRange1Choice_) and ReportingSource
        // (ReportingSource1Choice_): optional (0..1) choices; every variant's field is a
        // `required` Max35Text/ExternalCode struct whose format is already enforced by the
        // struct's own constructor — no rule needed.

        // Balance: CashBalance8, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Balance)
            .NotEmpty()
            .WithMessage("AccountStatement11.Balance must contain at least one element (1..*).");
    }
}
