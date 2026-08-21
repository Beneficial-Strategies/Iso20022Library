// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Mandate21"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yR4OUTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information that serves as a basis to debit an account.
/// <list type="table">
///   <item><term>MandateIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>MandateRequestIdentification</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>Authentication</term><description>MandateAuthentication1 — optional (0..1)</description></item>
///   <item><term>Type</term><description>MandateTypeInformation2 — optional (0..1)</description></item>
///   <item><term>Occurrences</term><description>MandateOccurrences5 — optional (0..1)</description></item>
///   <item><term>TrackingIndicator</term><description>TrueFalseIndicator — required (1..1)</description></item>
///   <item><term>FirstCollectionAmount</term><description>ActiveCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>CollectionAmount</term><description>ActiveCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>MaximumAmount</term><description>ActiveCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>Adjustment</term><description>MandateAdjustment1 — optional (0..1)</description></item>
///   <item><term>Reason</term><description>MandateSetupReason1Choice_ — optional (0..1)</description></item>
///   <item><term>CreditorSchemeIdentification</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>MandateReference</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>ReferredDocument</term><description>ReferredMandateDocument2 — optional (0..∞)</description></item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>UltimateDebtorGuideline</term>
///     <description>UltimateDebtor may only be present if different from Debtor.</description>
///   </item>
///   <item>
///     <term>UltimateCreditorGuideline</term>
///     <description>UltimateCreditor may only be present if different from Creditor.</description>
///   </item>
/// </list>
/// Both guidelines are structurally checkable — <see cref="PartyIdentification272"/> is a record,
/// so <c>Equals</c>/<c>==</c> gives correct hierarchical, structural equality — so both are
/// implemented as real rules below rather than left as non-enforceable commentary. Same shape as
/// the sibling types <see cref="Mandate20Validator"/> and <see cref="Mandate23Validator"/>, which
/// carry the identical pair of constraints. Unlike those two, <c>Creditor</c> and <c>Debtor</c>
/// here are optional (0..1) rather than required — the guideline checks below handle a null
/// <c>Creditor</c>/<c>Debtor</c> the same way as a null <c>UltimateCreditor</c>/<c>UltimateDebtor</c>:
/// nothing to compare, so nothing is flagged.
///
/// Dependency injection: every nested building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below. <c>PartyIdentification272</c> is shared across five properties
/// (<c>Creditor</c>, <c>Debtor</c>, <c>CreditorSchemeIdentification</c>, <c>UltimateCreditor</c>,
/// <c>UltimateDebtor</c>); <c>BranchAndFinancialInstitutionIdentification8</c> across two
/// (<c>CreditorAgent</c>, <c>DebtorAgent</c>); <c>CashAccount40</c> across two
/// (<c>CreditorAccount</c>, <c>DebtorAccount</c>) — one injected validator serves all properties
/// of the same validated type.
/// </remarks>
public class Mandate21Validator : AbstractValidator<Mandate21>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every nested building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    /// <param name="partyValidator">
    /// Validator for the <c>Creditor</c>, <c>Debtor</c>, <c>CreditorSchemeIdentification</c>,
    /// <c>UltimateCreditor</c>, and <c>UltimateDebtor</c> building blocks (all
    /// PartyIdentification272).
    /// </param>
    /// <param name="agentValidator">
    /// Validator for the <c>CreditorAgent</c> and <c>DebtorAgent</c> building blocks (both
    /// BranchAndFinancialInstitutionIdentification8).
    /// </param>
    /// <param name="cashAccountValidator">
    /// Validator for the <c>CreditorAccount</c> and <c>DebtorAccount</c> building blocks (both
    /// CashAccount40).
    /// </param>
    /// <param name="adjustmentValidator">
    /// Validator for the optional <c>Adjustment</c> building block (MandateAdjustment1, 0..1).
    /// </param>
    /// <param name="authenticationValidator">
    /// Validator for the optional <c>Authentication</c> building block (MandateAuthentication1,
    /// 0..1).
    /// </param>
    /// <param name="occurrencesValidator">
    /// Validator for the optional <c>Occurrences</c> building block (MandateOccurrences5, 0..1).
    /// </param>
    /// <param name="reasonValidator">
    /// Validator for the optional <c>Reason</c> building block (MandateSetupReason1Choice_, 0..1).
    /// </param>
    /// <param name="typeValidator">
    /// Validator for the optional <c>Type</c> building block (MandateTypeInformation2, 0..1).
    /// </param>
    /// <param name="referredDocumentValidator">
    /// Validator for each item of the <c>ReferredDocument</c> collection (ReferredMandateDocument2,
    /// 0..∞).
    /// </param>
    public Mandate21Validator(
        IValidator<PartyIdentification272> partyValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<MandateAdjustment1> adjustmentValidator,
        IValidator<MandateAuthentication1> authenticationValidator,
        IValidator<MandateOccurrences5> occurrencesValidator,
        IValidator<MandateSetupReason1Choice_> reasonValidator,
        IValidator<MandateTypeInformation2> typeValidator,
        IValidator<ReferredMandateDocument2> referredDocumentValidator
    )
    {
        // ── UltimateDebtorGuideline ───────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x => x.UltimateDebtor is null || !x.UltimateDebtor.Equals(x.Debtor))
            .WithName("UltimateDebtorGuideline")
            .WithMessage(
                "Mandate21.UltimateDebtor may only be present if different from Debtor "
                    + "(UltimateDebtorGuideline)."
            );

        // ── UltimateCreditorGuideline ─────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x => x.UltimateCreditor is null || !x.UltimateCreditor.Equals(x.Creditor))
            .WithName("UltimateCreditorGuideline")
            .WithMessage(
                "Mandate21.UltimateCreditor may only be present if different from Creditor "
                    + "(UltimateCreditorGuideline)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────
        // MandateIdentification, TrackingIndicator: required (1..1) and already `required` C#
        // properties — format enforced by struct constructors.
        // MandateRequestIdentification, MandateReference: optional scalars, length enforced by
        // struct constructors — no rule needed.
        // FirstCollectionAmount, CollectionAmount, MaximumAmount: ActiveCurrencyAndAmount,
        // optional — format enforced by the Amounts-namespace type itself, no validator exists
        // for that type (matches project convention elsewhere for Amounts types).

        When(x => x.Creditor is not null, () => RuleFor(x => x.Creditor).SetValidator(partyValidator!));
        When(x => x.Debtor is not null, () => RuleFor(x => x.Debtor).SetValidator(partyValidator!));
        When(
            x => x.DebtorAgent is not null,
            () => RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!)
        );

        When(
            x => x.CreditorSchemeIdentification is not null,
            () => RuleFor(x => x.CreditorSchemeIdentification).SetValidator(partyValidator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!)
        );
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!)
        );

        When(
            x => x.CreditorAgent is not null,
            () => RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!)
        );

        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );

        When(
            x => x.Adjustment is not null,
            () => RuleFor(x => x.Adjustment).SetValidator(adjustmentValidator!)
        );
        When(
            x => x.Authentication is not null,
            () => RuleFor(x => x.Authentication).SetValidator(authenticationValidator!)
        );
        When(
            x => x.Occurrences is not null,
            () => RuleFor(x => x.Occurrences).SetValidator(occurrencesValidator!)
        );
        When(x => x.Reason is not null, () => RuleFor(x => x.Reason).SetValidator(reasonValidator!));
        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));

        RuleForEach(x => x.ReferredDocument).SetValidator(referredDocumentValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block is
    /// validated by its own default validator (<see cref="PartyIdentification272Validator"/>,
    /// <see cref="BranchAndFinancialInstitutionIdentification8Validator"/>,
    /// <see cref="CashAccount40Validator"/>, <see cref="MandateAdjustment1Validator"/>,
    /// <see cref="MandateAuthentication1Validator"/>, <see cref="MandateOccurrences5Validator"/>,
    /// <see cref="MandateSetupReason1Choice_Validator"/>, <see cref="MandateTypeInformation2Validator"/>,
    /// <see cref="ReferredMandateDocument2Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public Mandate21Validator()
        : this(
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new MandateAdjustment1Validator(),
            new MandateAuthentication1Validator(),
            new MandateOccurrences5Validator(),
            new MandateSetupReason1Choice_Validator(),
            new MandateTypeInformation2Validator(),
            new ReferredMandateDocument2Validator()
        ) { }
}
