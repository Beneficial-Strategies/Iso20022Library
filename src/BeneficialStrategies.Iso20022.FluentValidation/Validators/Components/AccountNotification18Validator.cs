// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AccountNotification18"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _beowQdcZEeqRFcf2R4bPBw
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>Item</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item><term>DebtorRule</term><description>Either Debtor or Item/Debtor may be present but not both.</description></item>
///   <item><term>DebtorAgentRule</term><description>Either DebtorAgent or Item/DebtorAgent may be present but not both.</description></item>
///   <item><term>IntermediaryAgentRule</term><description>Either IntermediaryAgent or Item/IntermediaryAgent may be present but not both.</description></item>
///   <item><term>MandatoryDebtorRule</term><description>Either Debtor must be present or Item/Debtor must be present.</description></item>
///   <item><term>IntermediaryAgentAndDebtorAgentRule</term><description>If IntermediaryAgent is present then DebtorAgent must be present.</description></item>
///   <item><term>TotalAmountAndAmount1Rule</term><description>If TotalAmount is present, then all occurrences of Item/Amount must have the same currency as the currency of TotalAmount.</description></item>
///   <item><term>AccountAndCurrencyRule</term><description>If Account is present, then all occurrences of Item/Amount must have the same currency.</description></item>
///   <item><term>TotalAmountAndAmount2Rule</term><description>If TotalAmount is present, then it must equal the sum of all occurrences of Item/Amount.</description></item>
///   <item><term>AccountRule</term><description>Either Account or Item/Account may be present but not both.</description></item>
///   <item><term>AccountOwnerRule</term><description>Either AccountOwner or Item/AccountOwner may be present but not both.</description></item>
///   <item><term>AccountServicerRule</term><description>Either AccountServicer or Item/AccountServicer may be present but not both.</description></item>
///   <item><term>ExpectedValueDateRule</term><description>Either ExpectedValueDate or Item/ExpectedValueDate may be present but not both.</description></item>
///   <item><term>RelatedAccountRule</term><description>Either RelatedAccount or Item/RelatedAccount may be present but not both.</description></item>
/// </list>
/// </remarks>
public class AccountNotification18Validator : AbstractValidator<AccountNotification18>
{
    public AccountNotification18Validator()
    {
        // ── Cross-field constraints ───────────────────────────────────────────────

        RuleFor(x => x)
            .Must(x => !(x.Debtor is not null && x.Item.Any(i => i.Debtor is not null)))
            .WithName("DebtorRule")
            .WithMessage("Either Debtor or Item/Debtor may be present, but not both (DebtorRule).");

        RuleFor(x => x)
            .Must(x => !(x.DebtorAgent is not null && x.Item.Any(i => i.DebtorAgent is not null)))
            .WithName("DebtorAgentRule")
            .WithMessage("Either DebtorAgent or Item/DebtorAgent may be present, but not both (DebtorAgentRule).");

        RuleFor(x => x)
            .Must(x => !(x.IntermediaryAgent is not null && x.Item.Any(i => i.IntermediaryAgent is not null)))
            .WithName("IntermediaryAgentRule")
            .WithMessage(
                "Either IntermediaryAgent or Item/IntermediaryAgent may be present, but not both (IntermediaryAgentRule)."
            );

        RuleFor(x => x)
            .Must(x => x.Debtor is not null || (x.Item.Count > 0 && x.Item.All(i => i.Debtor is not null)))
            .WithName("MandatoryDebtorRule")
            .WithMessage("Either Debtor must be present or Item/Debtor must be present (MandatoryDebtorRule).");

        RuleFor(x => x)
            .Must(x => x.IntermediaryAgent is null || x.DebtorAgent is not null)
            .WithName("IntermediaryAgentAndDebtorAgentRule")
            .WithMessage(
                "If IntermediaryAgent is present then DebtorAgent must be present (IntermediaryAgentAndDebtorAgentRule)."
            );

        RuleFor(x => x)
            .Must(x => x.TotalAmount is null || x.Item.All(i => i.Amount.Currency == x.TotalAmount.Currency))
            .WithName("TotalAmountAndAmount1Rule")
            .WithMessage(
                "If TotalAmount is present, then all occurrences of Item/Amount must have the same currency "
                    + "as the currency of TotalAmount (TotalAmountAndAmount1Rule)."
            );

        RuleFor(x => x)
            .Must(x => x.Account is null || x.Item.Select(i => i.Amount.Currency).Distinct().Count() <= 1)
            .WithName("AccountAndCurrencyRule")
            .WithMessage(
                "If Account is present, then all occurrences of Item/Amount must have the same currency (AccountAndCurrencyRule)."
            );

        RuleFor(x => x)
            .Must(x => x.TotalAmount is null || x.TotalAmount.Amount == x.Item.Sum(i => i.Amount.Amount))
            .WithName("TotalAmountAndAmount2Rule")
            .WithMessage(
                "If TotalAmount is present, then it must equal the sum of all occurrences of Item/Amount (TotalAmountAndAmount2Rule)."
            );

        RuleFor(x => x)
            .Must(x => !(x.Account is not null && x.Item.Any(i => i.Account is not null)))
            .WithName("AccountRule")
            .WithMessage("Either Account or Item/Account may be present, but not both (AccountRule).");

        RuleFor(x => x)
            .Must(x => !(x.AccountOwner is not null && x.Item.Any(i => i.AccountOwner is not null)))
            .WithName("AccountOwnerRule")
            .WithMessage("Either AccountOwner or Item/AccountOwner may be present, but not both (AccountOwnerRule).");

        RuleFor(x => x)
            .Must(x => !(x.AccountServicer is not null && x.Item.Any(i => i.AccountServicer is not null)))
            .WithName("AccountServicerRule")
            .WithMessage(
                "Either AccountServicer or Item/AccountServicer may be present, but not both (AccountServicerRule)."
            );

        RuleFor(x => x)
            .Must(x => !(x.ExpectedValueDate is not null && x.Item.Any(i => i.ExpectedValueDate is not null)))
            .WithName("ExpectedValueDateRule")
            .WithMessage(
                "Either ExpectedValueDate or Item/ExpectedValueDate may be present, but not both (ExpectedValueDateRule)."
            );

        RuleFor(x => x)
            .Must(x => !(x.RelatedAccount is not null && x.Item.Any(i => i.RelatedAccount is not null)))
            .WithName("RelatedAccountRule")
            .WithMessage(
                "Either RelatedAccount or Item/RelatedAccount may be present, but not both (RelatedAccountRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // Identification: Max35Text, Min=1,Max=1 — already `required` in C# and length/pattern
        // enforced by the Max35Text struct constructor. No rule needed.

        // Item: NotificationItem8, Min=1,Max=unbounded — the ValueList<T> default ([]) satisfies
        // the C# type system but violates the ISO minimum. Enforce at runtime.
        RuleFor(x => x.Item)
            .NotEmpty()
            .WithMessage("AccountNotification18.Item must contain at least one element (1..∞).");

        // Account, RelatedAccount: CashAccount40 (0..1) — no validator exists yet for
        // CashAccount40; nested fields unvalidated.

        // AccountServicer, DebtorAgent, IntermediaryAgent:
        // BranchAndFinancialInstitutionIdentification6 (0..1) — no validator exists yet for
        // BranchAndFinancialInstitutionIdentification6; nested fields unvalidated.

        // TotalAmount: ActiveOrHistoricCurrencyAndAmount (0..1) — Currency and Amount are
        // already `required`; no validator exists for this type, but cross-field consistency
        // with Item/Amount is enforced above (TotalAmountAndAmount1Rule/2Rule).

        // ExpectedValueDate: ISODate (0..1), backed by System.DateOnly — no sub-constraints to
        // enforce for an optional scalar beyond the presence rule above. No further rule needed.

        // AccountOwner, Debtor: Party40Choice_ (0..1). Both variants reviewed:
        //   - Party: Name, PostalAddress, Identification, CountryOfResidence, ContactDetails are
        //     all optional (0..1); any Max140Text/CountryCode value present is already enforced
        //     by its struct constructor, and the nested Component/Choice types have no
        //     validators yet.
        //   - Agent: FinancialInstitutionIdentification is already `required` in C# (matches the
        //     spec's Min=1,Max=1); BranchIdentification is an optional Component (0..1) with no
        //     validator yet.
        // No additional field-level rule needed for either field beyond the cross-field
        // constraints already enforced above.
    }
}
