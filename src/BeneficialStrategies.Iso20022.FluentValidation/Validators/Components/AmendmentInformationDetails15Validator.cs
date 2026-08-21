// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AmendmentInformationDetails15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wL-4oTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details on the list of direct debit mandate elements that have been modified
/// when the amendment indicator has been set.
/// <list type="table">
///   <item><term>OriginalCreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>OriginalCreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>OriginalCreditorSchemeIdentification</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>OriginalDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>OriginalDebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>OriginalDebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>OriginalDebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>OriginalFinalCollectionDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalFrequency</term><description>Frequency36Choice_ — optional (0..1)</description></item>
///   <item><term>OriginalMandateIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalReason</term><description>MandateSetupReason1Choice_ — optional (0..1)</description></item>
///   <item><term>OriginalTrackingDays</term><description>Exact2NumericText — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every building-block field above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="BranchAndFinancialInstitutionIdentification8"/> validator instance is reused across
/// <c>OriginalCreditorAgent</c> and <c>OriginalDebtorAgent</c>, the same
/// <see cref="CashAccount40"/> validator instance across all three account fields, and the same
/// <see cref="PartyIdentification272"/> validator instance across
/// <c>OriginalCreditorSchemeIdentification</c> and <c>OriginalDebtor</c> — see the two
/// constructors below.
/// </remarks>
public class AmendmentInformationDetails15Validator : AbstractValidator<AmendmentInformationDetails15>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public AmendmentInformationDetails15Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<Frequency36Choice_> frequencyValidator,
        IValidator<MandateSetupReason1Choice_> reasonValidator
    )
    {
        When(
            x => x.OriginalCreditorAgent is not null,
            () => RuleFor(x => x.OriginalCreditorAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.OriginalCreditorAgentAccount is not null,
            () => RuleFor(x => x.OriginalCreditorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.OriginalCreditorSchemeIdentification is not null,
            () => RuleFor(x => x.OriginalCreditorSchemeIdentification).SetValidator(partyValidator!)
        );
        When(
            x => x.OriginalDebtor is not null,
            () => RuleFor(x => x.OriginalDebtor).SetValidator(partyValidator!)
        );
        When(
            x => x.OriginalDebtorAccount is not null,
            () => RuleFor(x => x.OriginalDebtorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.OriginalDebtorAgent is not null,
            () => RuleFor(x => x.OriginalDebtorAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.OriginalDebtorAgentAccount is not null,
            () => RuleFor(x => x.OriginalDebtorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.OriginalFrequency is not null,
            () => RuleFor(x => x.OriginalFrequency).SetValidator(frequencyValidator!)
        );
        When(
            x => x.OriginalReason is not null,
            () => RuleFor(x => x.OriginalReason).SetValidator(reasonValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public AmendmentInformationDetails15Validator()
        : this(
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new PartyIdentification272Validator(),
            new Frequency36Choice_Validator(),
            new MandateSetupReason1Choice_Validator()
        ) { }
}
