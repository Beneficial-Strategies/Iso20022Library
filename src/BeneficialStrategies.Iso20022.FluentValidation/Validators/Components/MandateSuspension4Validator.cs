// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateSuspension4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _4Q5KQTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of elements used to provide the details on the suspension reason of the original mandate.
/// <list type="table">
///   <item><term>OriginalMessageInformation</term><description>OriginalMessageInformation1 — optional (0..1)</description></item>
///   <item><term>OriginalMandate</term><description>OriginalMandate10Choice_ — required (1..1)</description></item>
///   <item><term>SuspensionReason</term><description>MandateSuspensionReason3 — required (1..1)</description></item>
///   <item><term>SuspensionRequestIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>SuspensionRequestIdentification</c>:
/// required (1..1) and already a <c>required</c> C# property — format enforced by the struct
/// constructor.
///
/// Dependency injection: <c>OriginalMessageInformation</c>, <c>OriginalMandate</c>,
/// <c>SuspensionReason</c>, and the <c>SupplementaryData</c> collection are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class MandateSuspension4Validator : AbstractValidator<MandateSuspension4>
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
    /// <param name="suspensionReasonValidator">
    /// Validator for the required <c>SuspensionReason</c> building block
    /// (MandateSuspensionReason3, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateSuspension4Validator(
        IValidator<OriginalMessageInformation1> originalMessageInformationValidator,
        IValidator<OriginalMandate10Choice_> originalMandateValidator,
        IValidator<MandateSuspensionReason3> suspensionReasonValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.OriginalMandate).SetValidator(originalMandateValidator);
        RuleFor(x => x.SuspensionReason).SetValidator(suspensionReasonValidator);

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
    /// <see cref="MandateSuspensionReason3Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateSuspension4Validator()
        : this(
            new OriginalMessageInformation1Validator(),
            new OriginalMandate10Choice_Validator(),
            new MandateSuspensionReason3Validator(),
            new SupplementaryData1Validator()
        ) { }
}
