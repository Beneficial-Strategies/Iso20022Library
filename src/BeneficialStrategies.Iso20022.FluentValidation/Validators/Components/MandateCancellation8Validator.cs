// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateCancellation8"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _5ukCITEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of elements used to provide the details on the cancellation reason of the original
/// mandate.
/// <list type="table">
///   <item><term>OriginalMessageInformation</term><description>OriginalMessageInformation1 — optional (0..1)</description></item>
///   <item><term>OriginalMandate</term><description>OriginalMandate10Choice_ — required (1..1)</description></item>
///   <item><term>CancellationReason</term><description>MandateCancellationReason2 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>OriginalMessageInformation</c>, <c>OriginalMandate</c>,
/// <c>CancellationReason</c>, and the <c>SupplementaryData</c> collection are each validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class MandateCancellation8Validator : AbstractValidator<MandateCancellation8>
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
    /// <param name="originalMandateValidator">
    /// Validator for the required <c>OriginalMandate</c> building block
    /// (OriginalMandate10Choice_, 1..1).
    /// </param>
    /// <param name="cancellationReasonValidator">
    /// Validator for the required <c>CancellationReason</c> building block
    /// (MandateCancellationReason2, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateCancellation8Validator(
        IValidator<OriginalMessageInformation1> originalMessageInformationValidator,
        IValidator<OriginalMandate10Choice_> originalMandateValidator,
        IValidator<MandateCancellationReason2> cancellationReasonValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.OriginalMandate).SetValidator(originalMandateValidator);
        RuleFor(x => x.CancellationReason).SetValidator(cancellationReasonValidator);

        When(
            x => x.OriginalMessageInformation is not null,
            () => RuleFor(x => x.OriginalMessageInformation).SetValidator(originalMessageInformationValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="OriginalMessageInformation1Validator"/>, <see cref="OriginalMandate10Choice_Validator"/>,
    /// <see cref="MandateCancellationReason2Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateCancellation8Validator()
        : this(
            new OriginalMessageInformation1Validator(),
            new OriginalMandate10Choice_Validator(),
            new MandateCancellationReason2Validator(),
            new SupplementaryData1Validator()
        ) { }
}
