// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalNotificationReference4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _tn6PlVkyEeGeoaLUQk__nA_237224306
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>OriginalItem</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// Constraints (from spec) — <b>enforced</b>:
/// <list type="bullet">
///   <item><term>ExpectedValueDateRule</term><description>Either ExpectedValueDate or OriginalItem/ExpectedValueDate may be present but not both.</description></item>
///   <item><term>TotalAmountAndAmount1Rule</term><description>If TotalAmount is present, then all occurrences of OriginalItem/Amount must have the same currency as the currency of TotalAmount.</description></item>
///   <item><term>TotalAmountAndAmount2Rule</term><description>If TotalAmount is present, then it must equal the sum of all occurrences of OriginalItem/Amount.</description></item>
///   <item><term>AccountAndCurrencyRule</term><description>If Account is present, then all occurrences of OriginalItem/Amount must have the same currency.</description></item>
/// </list>
///
/// Constraints (from spec) — <b>NOT enforceable, spec/model mismatch</b>: <see cref="OriginalItem3"/>
/// (the type of <see cref="OriginalNotificationReference4.OriginalItem"/>) has only 5 real ISO
/// dictionary children — OriginalItemIdentification, OriginalEndToEndIdentification, Amount,
/// ExpectedValueDate, OriginalItemReference (verified directly against the ISO dictionary entry,
/// not just the generated C#) — it has no Debtor, DebtorAgent, Account, AccountOwner,
/// AccountServicer, IntermediaryAgent, or RelatedAccount element. The following 9 constraints,
/// inherited verbatim from the (structurally different) AccountNotification component family,
/// reference "OriginalItem/X" paths that do not exist on this component and cannot be
/// mechanically evaluated. Left unimplemented rather than fabricating a reinterpretation:
/// <list type="bullet">
///   <item><term>DebtorRule</term><description>Either Debtor or OriginalItem/Debtor may be present but not both.</description></item>
///   <item><term>DebtorAgentRule</term><description>Either DebtorAgent or OriginalItem/DebtorAgent may be present but not both.</description></item>
///   <item><term>IntermediaryAgentRule</term><description>Either IntermediaryAgent or OriginalItem/IntermediaryAgent may be present but not both.</description></item>
///   <item><term>MandatoryDebtorRule</term><description>Either Debtor must be present or OriginalItem/Debtor must be present.</description></item>
///   <item><term>IntermediaryAgentAndDebtorAgentRule</term><description>If IntermediaryAgent is present then DebtorAgent must be present.</description></item>
///   <item><term>AccountRule</term><description>Either Account or OriginalItem/Account may be present but not both.</description></item>
///   <item><term>AccountOwnerRule</term><description>Either AccountOwner or OriginalItem/AccountOwner may be present but not both.</description></item>
///   <item><term>AccountServicerRule</term><description>Either AccountServicer or OriginalItem/AccountServicer may be present but not both.</description></item>
///   <item><term>RelatedAccountRule</term><description>Either RelatedAccount or OriginalItem/RelatedAccount may be present but not both.</description></item>
/// </list>
/// </remarks>
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public class OriginalNotificationReference4Validator : AbstractValidator<OriginalNotificationReference4>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="OriginalNotificationReference4"/>.
    /// </summary>
    public OriginalNotificationReference4Validator()
    {
        // ── Cross-field constraints (enforceable subset — see class remarks) ──────

        RuleFor(x => x)
            .Must(x => !(x.ExpectedValueDate is not null && x.OriginalItem.Any(i => i.ExpectedValueDate is not null)))
            .WithName("ExpectedValueDateRule")
            .WithMessage(
                "Either ExpectedValueDate or OriginalItem/ExpectedValueDate may be present, but not both (ExpectedValueDateRule)."
            );

        RuleFor(x => x)
            .Must(x => x.TotalAmount is null || x.OriginalItem.All(i => i.Amount.Currency == x.TotalAmount.Currency))
            .WithName("TotalAmountAndAmount1Rule")
            .WithMessage(
                "If TotalAmount is present, then all occurrences of OriginalItem/Amount must have the "
                    + "same currency as the currency of TotalAmount (TotalAmountAndAmount1Rule)."
            );

        RuleFor(x => x)
            .Must(x => x.TotalAmount is null || x.TotalAmount.Amount == x.OriginalItem.Sum(i => i.Amount.Amount))
            .WithName("TotalAmountAndAmount2Rule")
            .WithMessage(
                "If TotalAmount is present, then it must equal the sum of all occurrences of "
                    + "OriginalItem/Amount (TotalAmountAndAmount2Rule)."
            );

        RuleFor(x => x)
            .Must(x => x.Account is null || x.OriginalItem.Select(i => i.Amount.Currency).Distinct().Count() <= 1)
            .WithName("AccountAndCurrencyRule")
            .WithMessage(
                "If Account is present, then all occurrences of OriginalItem/Amount must have the same "
                    + "currency (AccountAndCurrencyRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // OriginalItem: OriginalItem3, Min=1,Max=unbounded — the ValueList<T> default ([])
        // satisfies the C# type system but violates the ISO minimum. Enforce at runtime.
        RuleFor(x => x.OriginalItem)
            .NotEmpty()
            .WithMessage("OriginalNotificationReference4.OriginalItem must contain at least one element (1..∞).");

        // Account, RelatedAccount (CashAccount24, 0..1), AccountServicer, DebtorAgent,
        // IntermediaryAgent (BranchAndFinancialInstitutionIdentification5, 0..1), AccountOwner,
        // Debtor (Party12Choice_, 0..1), TotalAmount (ActiveOrHistoricCurrencyAndAmount, 0..1):
        // no validator exists yet for these; nested fields unvalidated beyond the cross-field
        // constraints already enforced above.
    }
}
