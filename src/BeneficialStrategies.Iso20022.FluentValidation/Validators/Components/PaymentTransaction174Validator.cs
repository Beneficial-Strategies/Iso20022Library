// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction174"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 5be6bec5-d8be-45bf-83e9-ccc1cafba2ba
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details on the reference and status on the original transactions, included
/// in the original instruction, to which the reversal message applies.
/// <list type="table">
///   <item><term>ReversalIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalInstructionIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalEndToEndIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalUETR</term><description>UUIDv4Identifier — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalInstructedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>ReversedInstructedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>ReversalReasonInformation</term><description>PaymentReversalReason10 collection — optional (0..n)</description></item>
///   <item><term>OriginalTransactionReference</term><description>OriginalTransactionReference47 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ReversalReasonInformation</c>, <c>OriginalTransactionReference</c>,
/// and <c>SupplementaryData</c> are each validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class PaymentTransaction174Validator : AbstractValidator<PaymentTransaction174>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentTransaction174Validator(
        IValidator<PaymentReversalReason10> reversalReasonInformationValidator,
        IValidator<OriginalTransactionReference47> originalTransactionReferenceValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleForEach(x => x.ReversalReasonInformation).SetValidator(reversalReasonInformationValidator!);
        When(
            x => x.OriginalTransactionReference is not null,
            () => RuleFor(x => x.OriginalTransactionReference).SetValidator(originalTransactionReferenceValidator!)
        );
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentTransaction174Validator()
        : this(
            new PaymentReversalReason10Validator(),
            new OriginalTransactionReference47Validator(),
            new SupplementaryData1Validator()
        ) { }
}
