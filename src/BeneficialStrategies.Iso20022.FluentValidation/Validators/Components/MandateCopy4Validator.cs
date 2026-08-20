// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateCopy4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _5GXZsTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Identifies the mandate, for which a copy of the details is requested.
/// <list type="table">
///   <item><term>MandateStatus</term><description>MandateStatus1Choice_ — optional (0..1)</description></item>
///   <item><term>OriginalMandate</term><description>OriginalMandate10Choice_ — required (1..1)</description></item>
///   <item><term>OriginalMessageInformation</term><description>OriginalMessageInformation1 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>MandateStatus</c>, <c>OriginalMandate</c>,
/// <c>OriginalMessageInformation</c>, and the <c>SupplementaryData</c> collection are each
/// validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see
/// the two constructors below.
/// </remarks>
public class MandateCopy4Validator : AbstractValidator<MandateCopy4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for <c>MandateStatus</c>, <c>OriginalMandate</c>, <c>OriginalMessageInformation</c>, and
    /// the <c>SupplementaryData</c> collection's item type — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="mandateStatusValidator">
    /// Validator for the optional <c>MandateStatus</c> building block (MandateStatus1Choice_,
    /// 0..1) — only invoked when present.
    /// </param>
    /// <param name="originalMandateValidator">
    /// Validator for the required <c>OriginalMandate</c> building block (OriginalMandate10Choice_,
    /// 1..1).
    /// </param>
    /// <param name="originalMessageInformationValidator">
    /// Validator for the optional <c>OriginalMessageInformation</c> building block
    /// (OriginalMessageInformation1, 0..1) — only invoked when present.
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateCopy4Validator(
        IValidator<MandateStatus1Choice_> mandateStatusValidator,
        IValidator<OriginalMandate10Choice_> originalMandateValidator,
        IValidator<OriginalMessageInformation1> originalMessageInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        When(
            x => x.MandateStatus is not null,
            () => RuleFor(x => x.MandateStatus).SetValidator(mandateStatusValidator!)
        );

        RuleFor(x => x.OriginalMandate).SetValidator(originalMandateValidator);

        When(
            x => x.OriginalMessageInformation is not null,
            () =>
                RuleFor(x => x.OriginalMessageInformation)
                    .SetValidator(originalMessageInformationValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MandateStatus</c>,
    /// <c>OriginalMandate</c>, <c>OriginalMessageInformation</c>, and the
    /// <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="MandateStatus1Choice_Validator"/>, <see cref="OriginalMandate10Choice_Validator"/>,
    /// <see cref="OriginalMessageInformation1Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateCopy4Validator()
        : this(
            new MandateStatus1Choice_Validator(),
            new OriginalMandate10Choice_Validator(),
            new OriginalMessageInformation1Validator(),
            new SupplementaryData1Validator()
        ) { }
}
