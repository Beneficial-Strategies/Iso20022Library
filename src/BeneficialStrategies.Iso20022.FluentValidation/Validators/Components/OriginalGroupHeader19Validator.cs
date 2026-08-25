// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalGroupHeader19"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _xUbucTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID — matched exactly, no gap.
///
/// Provides information on the original group, to which the message refers.
/// <list type="table">
///   <item><term>OriginalMessageIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalMessageNameIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalCreationDateTime</term><description>ISODateTime — optional (0..1); lexical form enforced by struct constructor — no rule needed</description></item>
///   <item><term>ReturnReasonInformation</term><description>PaymentReturnReason7 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// No cross-field constraints found for this component itself.
///
/// Dependency injection: <c>ReturnReasonInformation</c> (each item) is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class OriginalGroupHeader19Validator : AbstractValidator<OriginalGroupHeader19>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for <c>ReturnReasonInformation</c> — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public OriginalGroupHeader19Validator(IValidator<PaymentReturnReason7> returnReasonInformationValidator)
    {
        RuleForEach(x => x.ReturnReasonInformation).SetValidator(returnReasonInformationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalGroupHeader19Validator()
        : this(new PaymentReturnReason7Validator()) { }
}
