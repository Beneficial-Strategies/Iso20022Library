// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalNotificationReference15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: f3661683-1059-491d-b800-a893be378870
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>OriginalItemAndStatus</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// Constraints (from spec) — <b>enforced</b>:
/// <list type="bullet">
///   <item><term>ExpectedValueDateRule</term><description>Either ExpectedValueDate or OriginalItemAndStatus/ExpectedValueDate may be present but not both.</description></item>
///   <item><term>TotalAmountAndAmount1Rule</term><description>If TotalAmount is present, then all occurrences of OriginalItemAndStatus/Amount must have the same currency as the currency of TotalAmount.</description></item>
///   <item><term>TotalAmountAndAmount2Rule</term><description>If TotalAmount is present, then it must equal the sum of all occurrences of OriginalItemAndStatus/Amount.</description></item>
///   <item><term>AccountAndCurrencyRule</term><description>If Account is present, then all occurrences of OriginalItemAndStatus/Amount must have the same currency.</description></item>
/// </list>
///
/// Constraints (from spec) — <b>NOT enforceable, spec/model mismatch</b>: <see cref="OriginalItemAndStatus9"/>
/// (the type of <see cref="OriginalNotificationReference15.OriginalItemAndStatus"/>) has only 5 real ISO
/// dictionary children — OriginalItemIdentification, OriginalEndToEndIdentification, Amount,
/// ExpectedValueDate, OriginalItemReference (verified directly against the ISO dictionary entry,
/// not just the generated C#) — it has no Debtor, DebtorAgent, Account, AccountOwner,
/// AccountServicer, IntermediaryAgent, or RelatedAccount element. The following 9 constraints,
/// inherited verbatim from the (structurally different) AccountNotification component family,
/// reference "OriginalItemAndStatus/X" paths that do not exist on this component and cannot be
/// mechanically evaluated. Left unimplemented rather than fabricating a reinterpretation:
/// <list type="bullet">
///   <item><term>DebtorRule</term><description>Either Debtor or OriginalItemAndStatus/Debtor may be present but not both.</description></item>
///   <item><term>DebtorAgentRule</term><description>Either DebtorAgent or OriginalItemAndStatus/DebtorAgent may be present but not both.</description></item>
///   <item><term>IntermediaryAgentRule</term><description>Either IntermediaryAgent or OriginalItemAndStatus/IntermediaryAgent may be present but not both.</description></item>
///   <item><term>MandatoryDebtorRule</term><description>Either Debtor must be present or OriginalItemAndStatus/Debtor must be present.</description></item>
///   <item><term>IntermediaryAgentAndDebtorAgentRule</term><description>If IntermediaryAgent is present then DebtorAgent must be present.</description></item>
///   <item><term>AccountRule</term><description>Either Account or OriginalItemAndStatus/Account may be present but not both.</description></item>
///   <item><term>AccountOwnerRule</term><description>Either AccountOwner or OriginalItemAndStatus/AccountOwner may be present but not both.</description></item>
///   <item><term>AccountServicerRule</term><description>Either AccountServicer or OriginalItemAndStatus/AccountServicer may be present but not both.</description></item>
///   <item><term>RelatedAccountRule</term><description>Either RelatedAccount or OriginalItemAndStatus/RelatedAccount may be present but not both.</description></item>
/// </list>
/// </remarks>
public class OriginalNotificationReference15Validator : AbstractValidator<OriginalNotificationReference15>
{
    public OriginalNotificationReference15Validator()
    {
        // ── Cross-field constraints (enforceable subset — see class remarks) ──────

        RuleFor(x => x)
            .Must(x => !(x.ExpectedValueDate is not null && x.OriginalItemAndStatus.Any(i => i.ExpectedValueDate is not null)))
            .WithName("ExpectedValueDateRule")
            .WithMessage(
                "Either ExpectedValueDate or OriginalItemAndStatus/ExpectedValueDate may be present, but not both (ExpectedValueDateRule)."
            );

        RuleFor(x => x)
            .Must(x => x.TotalAmount is null || x.OriginalItemAndStatus.All(i => i.Amount.Currency == x.TotalAmount.Currency))
            .WithName("TotalAmountAndAmount1Rule")
            .WithMessage(
                "If TotalAmount is present, then all occurrences of OriginalItemAndStatus/Amount must have the "
                    + "same currency as the currency of TotalAmount (TotalAmountAndAmount1Rule)."
            );

        RuleFor(x => x)
            .Must(x => x.TotalAmount is null || x.TotalAmount.Amount == x.OriginalItemAndStatus.Sum(i => i.Amount.Amount))
            .WithName("TotalAmountAndAmount2Rule")
            .WithMessage(
                "If TotalAmount is present, then it must equal the sum of all occurrences of "
                    + "OriginalItemAndStatus/Amount (TotalAmountAndAmount2Rule)."
            );

        RuleFor(x => x)
            .Must(x => x.Account is null || x.OriginalItemAndStatus.Select(i => i.Amount.Currency).Distinct().Count() <= 1)
            .WithName("AccountAndCurrencyRule")
            .WithMessage(
                "If Account is present, then all occurrences of OriginalItemAndStatus/Amount must have the same "
                    + "currency (AccountAndCurrencyRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // OriginalItemAndStatus: OriginalItemAndStatus9, Min=1,Max=unbounded — the ValueList<T> default ([])
        // satisfies the C# type system but violates the ISO minimum. Enforce at runtime.
        RuleFor(x => x.OriginalItemAndStatus)
            .NotEmpty()
            .WithMessage("OriginalNotificationReference15.OriginalItemAndStatus must contain at least one element (1..∞).");

        // Account, RelatedAccount (CashAccount40, 0..1), AccountServicer, DebtorAgent,
        // IntermediaryAgent (BranchAndFinancialInstitutionIdentification8, 0..1), AccountOwner,
        // Debtor (Party50Choice_, 0..1), TotalAmount (ActiveOrHistoricCurrencyAndAmount, 0..1):
        // no validator exists yet for these; nested fields unvalidated beyond the cross-field
        // constraints already enforced above.
    }
}
