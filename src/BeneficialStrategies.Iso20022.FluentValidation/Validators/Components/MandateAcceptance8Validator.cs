// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateAcceptance8"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1f7egTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Identifies the mandate, which is being accepted.
/// <list type="table">
///   <item><term>OriginalMessageInformation</term><description>OriginalMessageInformation1 — optional (0..1)</description></item>
///   <item><term>AcceptanceResult</term><description>AcceptanceResult6 — required (1..1)</description></item>
///   <item><term>OriginalMandate</term><description>OriginalMandate11Choice_ — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>OriginalMessageInformation</c>, <c>AcceptanceResult</c>,
/// <c>OriginalMandate</c>, and the <c>SupplementaryData</c> collection are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class MandateAcceptance8Validator : AbstractValidator<MandateAcceptance8>
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
    /// <param name="acceptanceResultValidator">
    /// Validator for the required <c>AcceptanceResult</c> building block (AcceptanceResult6, 1..1).
    /// </param>
    /// <param name="originalMandateValidator">
    /// Validator for the optional <c>OriginalMandate</c> building block
    /// (OriginalMandate11Choice_, 0..1) — only invoked when present.
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateAcceptance8Validator(
        IValidator<OriginalMessageInformation1> originalMessageInformationValidator,
        IValidator<AcceptanceResult6> acceptanceResultValidator,
        IValidator<OriginalMandate11Choice_> originalMandateValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.AcceptanceResult).SetValidator(acceptanceResultValidator);

        When(
            x => x.OriginalMessageInformation is not null,
            () => RuleFor(x => x.OriginalMessageInformation).SetValidator(originalMessageInformationValidator!)
        );
        When(
            x => x.OriginalMandate is not null,
            () => RuleFor(x => x.OriginalMandate).SetValidator(originalMandateValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="OriginalMessageInformation1Validator"/>, <see cref="AcceptanceResult6Validator"/>,
    /// <see cref="OriginalMandate11Choice_Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateAcceptance8Validator()
        : this(
            new OriginalMessageInformation1Validator(),
            new AcceptanceResult6Validator(),
            new OriginalMandate11Choice_Validator(),
            new SupplementaryData1Validator()
        ) { }
}
