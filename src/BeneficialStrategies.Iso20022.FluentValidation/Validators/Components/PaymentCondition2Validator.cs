// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentCondition2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _4N9WwTFNEe6e4MbXgPVc4A
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the conditions for the execution of the payment.
/// <list type="table">
///   <item><term>AmountModificationAllowed</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>DelayPenalty</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>EarlyPaymentAllowed</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>GuaranteedPaymentRequested</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>ImmediatePaymentRebate</term><description>AmountOrRate1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ImmediatePaymentRebate</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class PaymentCondition2Validator : AbstractValidator<PaymentCondition2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentCondition2Validator(IValidator<AmountOrRate1Choice_> immediatePaymentRebateValidator)
    {
        When(
            x => x.ImmediatePaymentRebate is not null,
            () => RuleFor(x => x.ImmediatePaymentRebate).SetValidator(immediatePaymentRebateValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentCondition2Validator()
        : this(new AmountOrRate1Choice_Validator()) { }
}
