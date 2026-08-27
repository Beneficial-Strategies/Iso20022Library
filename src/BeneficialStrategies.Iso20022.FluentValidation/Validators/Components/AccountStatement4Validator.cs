// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using RptgSrc1 = BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AccountStatement4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _9cVDkSGxEeKjd4jizyIDGA
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>Balance</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints were found for this component (no "constraint" rows in the
/// MCP children table).
/// </remarks>
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public class AccountStatement4Validator : AbstractValidator<AccountStatement4>
{
    public AccountStatement4Validator()
    {
        // Identification, CreationDateTime: required scalars — already `required`; Max35Text
        // length enforced by struct ctor, ISODateTime is a plain DateTime, no further rule.
        // AdditionalStatementInformation, CopyDuplicateIndicator, ElectronicSequenceNumber,
        // LegalSequenceNumber: optional (0..1) scalars, no sub-constraints — no rule needed.
        // Entry, Interest: optional collections (0..∞) — any size including empty is valid,
        // no rule needed.
        // Account, FromToDate, RelatedAccount, StatementPagination, TransactionsSummary:
        // Component types with no validator yet — nested fields unvalidated.

        RuleFor(x => x.Balance)
            .NotEmpty()
            .WithMessage("AccountStatement4.Balance must contain at least one element (1..*).");

        // ── ReportingSource: ReportingSource1Choice (0..1) ───────────────────────
        // Variant Code wraps an external code enum — cannot be "empty", no rule applicable.
        // Variant Proprietary wraps Max35Text — NotEmpty() guards against a default struct.
        When(
            x => x.ReportingSource is RptgSrc1.Proprietary,
            () => RuleFor(x => ((RptgSrc1.Proprietary)x.ReportingSource!).Value).NotEmpty()
        );
    }
}
