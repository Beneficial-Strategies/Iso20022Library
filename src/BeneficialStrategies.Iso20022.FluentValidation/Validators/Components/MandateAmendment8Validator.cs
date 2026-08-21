// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateAmendment8"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yLKiITEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Identifies the mandate to be amended and gives details of the new mandate.
/// <list type="table">
///   <item><term>OriginalMessageInformation</term><description>OriginalMessageInformation1 — optional (0..1)</description></item>
///   <item><term>AmendmentReason</term><description>MandateAmendmentReason3 — required (1..1)</description></item>
///   <item><term>Mandate</term><description>Mandate21 — required (1..1)</description></item>
///   <item><term>OriginalMandate</term><description>OriginalMandate10Choice_ — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>OriginalMessageInformation</c>, <c>AmendmentReason</c>,
/// <c>Mandate</c>, <c>OriginalMandate</c>, and the <c>SupplementaryData</c> collection are each
/// validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see
/// the two constructors below.
/// </remarks>
public class MandateAmendment8Validator : AbstractValidator<MandateAmendment8>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every nested building block and the <c>SupplementaryData</c> collection's item type —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="originalMessageInformationValidator">
    /// Validator for the optional <c>OriginalMessageInformation</c> building block
    /// (OriginalMessageInformation1, 0..1) — only invoked when present.
    /// </param>
    /// <param name="amendmentReasonValidator">
    /// Validator for the required <c>AmendmentReason</c> building block
    /// (MandateAmendmentReason3, 1..1).
    /// </param>
    /// <param name="mandateValidator">
    /// Validator for the required <c>Mandate</c> building block (Mandate21, 1..1).
    /// </param>
    /// <param name="originalMandateValidator">
    /// Validator for the required <c>OriginalMandate</c> building block
    /// (OriginalMandate10Choice_, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateAmendment8Validator(
        IValidator<OriginalMessageInformation1> originalMessageInformationValidator,
        IValidator<MandateAmendmentReason3> amendmentReasonValidator,
        IValidator<Mandate21> mandateValidator,
        IValidator<OriginalMandate10Choice_> originalMandateValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.AmendmentReason).SetValidator(amendmentReasonValidator);
        RuleFor(x => x.Mandate).SetValidator(mandateValidator);
        RuleFor(x => x.OriginalMandate).SetValidator(originalMandateValidator);

        When(
            x => x.OriginalMessageInformation is not null,
            () => RuleFor(x => x.OriginalMessageInformation).SetValidator(originalMessageInformationValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="OriginalMessageInformation1Validator"/>, <see cref="MandateAmendmentReason3Validator"/>,
    /// <see cref="Mandate21Validator"/>, <see cref="OriginalMandate10Choice_Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public MandateAmendment8Validator()
        : this(
            new OriginalMessageInformation1Validator(),
            new MandateAmendmentReason3Validator(),
            new Mandate21Validator(),
            new OriginalMandate10Choice_Validator(),
            new SupplementaryData1Validator()
        ) { }
}
