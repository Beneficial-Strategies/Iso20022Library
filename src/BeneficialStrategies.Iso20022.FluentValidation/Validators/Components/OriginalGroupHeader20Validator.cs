// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalGroupHeader20"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yCJJATEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides details on the original group, to which the message refers.
/// <list type="table">
///   <item><term>OriginalCreationDateTime</term><description>ISODateTime — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalMessageIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>OriginalMessageNameIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>ReversalReasonInformation</term><description>PaymentReversalReason10 collection — optional (0..n); drives the message-level <c>GroupReversalAndReasonRule</c> on <see cref="BeneficialStrategies.Iso20022.Validation.pain.CustomerPaymentReversalV13Validator"/></description></item>
/// </list>
///
/// No cross-field constraints attach directly to this component — <c>GroupReversalAndReasonRule</c>
/// (referencing both <c>GroupHeader/GroupReversal</c> and this component's own
/// <c>ReversalReasonInformation/Reason</c>) spans multiple top-level message building blocks and
/// is enforced on <see cref="BeneficialStrategies.Iso20022.Validation.pain.CustomerPaymentReversalV13Validator"/> instead, where both sides of
/// the rule are visible.
///
/// Dependency injection: <c>ReversalReasonInformation</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class OriginalGroupHeader20Validator : AbstractValidator<OriginalGroupHeader20>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public OriginalGroupHeader20Validator(IValidator<PaymentReversalReason10> reversalReasonInformationValidator)
    {
        RuleForEach(x => x.ReversalReasonInformation).SetValidator(reversalReasonInformationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalGroupHeader20Validator()
        : this(new PaymentReversalReason10Validator()) { }
}
