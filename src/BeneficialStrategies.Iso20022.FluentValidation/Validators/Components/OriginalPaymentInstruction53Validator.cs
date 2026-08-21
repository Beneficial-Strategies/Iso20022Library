// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalPaymentInstruction53"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 223270f6-eaaf-4b72-8b14-f17478370b64
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides detailed information on the original transaction, to which the status report message
/// refers.
/// <list type="table">
///   <item><term>ReversalPaymentInformationIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalPaymentInformationIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>OriginalNumberOfTransactions</term><description>Max15NumericText — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>BatchBooking</term><description>BatchBookingIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>PaymentInformationReversal</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced; drives the message-level <c>GroupReversalAndNumberOfTransactionsGuideline</c> on <see cref="CustomerPaymentReversalV13Validator"/></description></item>
///   <item><term>ReversalReasonInformation</term><description>PaymentReversalReason10 collection — optional (0..n)</description></item>
///   <item><term>TransactionInformation</term><description>PaymentTransaction174 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints attach directly to this component — the message-level
/// <c>GroupReversalAndNumberOfTransactionsGuideline</c> (referencing this component's own
/// <c>PaymentInformationReversal</c> alongside <c>GroupHeader/GroupReversal</c> and
/// <c>GroupHeader/NumberOfTransactions</c>) spans multiple top-level message building blocks and
/// is enforced on <see cref="CustomerPaymentReversalV13Validator"/> instead, where all three
/// sides of the rule are visible.
///
/// Dependency injection: <c>ReversalReasonInformation</c> and <c>TransactionInformation</c> are
/// each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c>
/// — see the two constructors below.
/// </remarks>
public class OriginalPaymentInstruction53Validator : AbstractValidator<OriginalPaymentInstruction53>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public OriginalPaymentInstruction53Validator(
        IValidator<PaymentReversalReason10> reversalReasonInformationValidator,
        IValidator<PaymentTransaction174> transactionInformationValidator
    )
    {
        RuleForEach(x => x.ReversalReasonInformation).SetValidator(reversalReasonInformationValidator!);
        RuleForEach(x => x.TransactionInformation).SetValidator(transactionInformationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalPaymentInstruction53Validator()
        : this(new PaymentReversalReason10Validator(), new PaymentTransaction174Validator()) { }
}
