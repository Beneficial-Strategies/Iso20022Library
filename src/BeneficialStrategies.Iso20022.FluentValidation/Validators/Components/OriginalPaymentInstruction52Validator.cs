// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalPaymentInstruction52"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: bf9235eb-bfaf-490c-99bb-dbbbce3ca4c3
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides details on the original transactions, to which the status report message refers.
/// <list type="table">
///   <item><term>OriginalPaymentInformationIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>OriginalNumberOfTransactions</term><description>Max15NumericText — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>PaymentInformationStatus</term><description>ExternalPaymentGroupStatus1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>StatusReasonInformation</term><description>StatusReasonInformation14 collection — optional (0..n)</description></item>
///   <item><term>NumberOfTransactionsPerStatus</term><description>NumberOfTransactionsPerStatus5 collection — optional (0..n)</description></item>
///   <item><term>TransactionInformationAndStatus</term><description>PaymentTransaction169 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>StatusReasonInformation</c>, <c>NumberOfTransactionsPerStatus</c>,
/// and <c>TransactionInformationAndStatus</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class OriginalPaymentInstruction52Validator : AbstractValidator<OriginalPaymentInstruction52>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public OriginalPaymentInstruction52Validator(
        IValidator<StatusReasonInformation14> statusReasonInformationValidator,
        IValidator<NumberOfTransactionsPerStatus5> numberOfTransactionsPerStatusValidator,
        IValidator<PaymentTransaction169> transactionInformationAndStatusValidator
    )
    {
        RuleForEach(x => x.StatusReasonInformation).SetValidator(statusReasonInformationValidator!);
        RuleForEach(x => x.NumberOfTransactionsPerStatus).SetValidator(numberOfTransactionsPerStatusValidator!);
        RuleForEach(x => x.TransactionInformationAndStatus).SetValidator(transactionInformationAndStatusValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalPaymentInstruction52Validator()
        : this(
            new StatusReasonInformation14Validator(),
            new NumberOfTransactionsPerStatus5Validator(),
            new PaymentTransaction169Validator()
        ) { }
}
