// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateRelatedInformation16"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wJuO0TEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details related to a direct debit mandate signed between the creditor and the
/// debtor.
/// <list type="table">
///   <item><term>AmendmentIndicator</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>AmendmentInformationDetails</term><description>AmendmentInformationDetails15 — optional (0..1)</description></item>
///   <item><term>DateOfSignature</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ElectronicSignature</term><description>Max1025Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>FinalCollectionDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>FirstCollectionDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Frequency</term><description>Frequency36Choice_ — optional (0..1)</description></item>
///   <item><term>MandateIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Reason</term><description>MandateSetupReason1Choice_ — optional (0..1)</description></item>
///   <item><term>TrackingDays</term><description>Exact2NumericText — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>AmendmentInformationDetails</c>, <c>Frequency</c>, and <c>Reason</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class MandateRelatedInformation16Validator : AbstractValidator<MandateRelatedInformation16>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public MandateRelatedInformation16Validator(
        IValidator<AmendmentInformationDetails15> amendmentInformationDetailsValidator,
        IValidator<Frequency36Choice_> frequencyValidator,
        IValidator<MandateSetupReason1Choice_> reasonValidator
    )
    {
        When(
            x => x.AmendmentInformationDetails is not null,
            () => RuleFor(x => x.AmendmentInformationDetails).SetValidator(amendmentInformationDetailsValidator!)
        );
        When(x => x.Frequency is not null, () => RuleFor(x => x.Frequency).SetValidator(frequencyValidator!));
        When(x => x.Reason is not null, () => RuleFor(x => x.Reason).SetValidator(reasonValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public MandateRelatedInformation16Validator()
        : this(
            new AmendmentInformationDetails15Validator(),
            new Frequency36Choice_Validator(),
            new MandateSetupReason1Choice_Validator()
        ) { }
}
