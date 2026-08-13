// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using RptgSrc1 = BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice;
using SeqRange1 = BeneficialStrategies.Iso20022.Choices.SequenceRange1Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AccountStatement15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: f2d5db70-d297-4049-9ae1-97fe2c32f5ef
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
public sealed class AccountStatement15Validator : AbstractValidator<AccountStatement15>
{
    public AccountStatement15Validator()
    {
        // Identification: Max35Text, required — already `required`; length enforced by struct ctor.
        // AdditionalStatementInformation, CopyDuplicateIndicator, CreationDateTime,
        // ElectronicSequenceNumber, LegalSequenceNumber: optional (0..1) scalars, no
        // sub-constraints — no rule needed.
        // Entry, Interest: optional collections (0..∞) — any size including empty is valid,
        // no rule needed.
        // Account, FromToDate, RelatedAccount, StatementPagination, TransactionsSummary:
        // Component types with no validator yet — nested fields unvalidated.

        RuleFor(x => x.Balance)
            .NotEmpty()
            .WithMessage("AccountStatement15.Balance must contain at least one element (1..*).");

        // ── ReportingSequence: SequenceRange1Choice (0..1) ───────────────────────
        // All variants wrap Max35Text — length enforced by struct ctor; NotEmpty() guards
        // against a default(Max35Text) slipping through an object initializer.
        When(
            x => x.ReportingSequence is SeqRange1.FromSequence,
            () => RuleFor(x => ((SeqRange1.FromSequence)x.ReportingSequence!).Value).NotEmpty()
        );

        When(
            x => x.ReportingSequence is SeqRange1.ToSequence,
            () => RuleFor(x => ((SeqRange1.ToSequence)x.ReportingSequence!).Value).NotEmpty()
        );

        When(
            x => x.ReportingSequence is SeqRange1.FromToSequence,
            () =>
            {
                RuleFor(x => ((SeqRange1.FromToSequence)x.ReportingSequence!).FromSequence)
                    .NotEmpty();
                RuleFor(x => ((SeqRange1.FromToSequence)x.ReportingSequence!).ToSequence)
                    .NotEmpty();
            }
        );

        When(
            x => x.ReportingSequence is SeqRange1.EqualSequence,
            () => RuleFor(x => ((SeqRange1.EqualSequence)x.ReportingSequence!).Value).NotEmpty()
        );

        When(
            x => x.ReportingSequence is SeqRange1.NotEqualSequence,
            () =>
                RuleFor(x => ((SeqRange1.NotEqualSequence)x.ReportingSequence!).Value).NotEmpty()
        );

        // ── ReportingSource: ReportingSource1Choice (0..1) ───────────────────────
        // Variant Code wraps an external code enum — cannot be "empty", no rule applicable.
        // Variant Proprietary wraps Max35Text — NotEmpty() guards against a default struct.
        When(
            x => x.ReportingSource is RptgSrc1.Proprietary,
            () => RuleFor(x => ((RptgSrc1.Proprietary)x.ReportingSource!).Value).NotEmpty()
        );
    }
}
