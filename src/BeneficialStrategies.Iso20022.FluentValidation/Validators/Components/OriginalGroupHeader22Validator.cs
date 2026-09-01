// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalGroupHeader22"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _4qUW4TEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides details on the original group, to which the message refers.
/// <list type="table">
///   <item><term>GroupStatus</term><description>ExternalPaymentGroupStatus1Code — optional (0..1), closed enum, fully enforced; drives the message-level cross-field rules on <see cref="BeneficialStrategies.Iso20022.Validation.pain.CustomerPaymentStatusReportV15Validator"/></description></item>
///   <item><term>NumberOfTransactionsPerStatus</term><description>NumberOfTransactionsPerStatus5 collection — optional (0..n)</description></item>
///   <item><term>OriginalControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalCreationDateTime</term><description>ISODateTime — optional (0..1), fully struct-enforced</description></item>
///   <item><term>OriginalMessageIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>OriginalMessageNameIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>OriginalNumberOfTransactions</term><description>Max15NumericText — optional (0..1), fully struct-enforced</description></item>
///   <item><term>StatusReasonInformation</term><description>StatusReasonInformation14 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints attach directly to this component — the message-level
/// <c>GroupStatusAcceptedRule</c>/<c>GroupStatusPendingRule</c>/<c>GroupStatusRejectedRule</c>/
/// <c>GroupStatusReceivedRule</c> (referencing this component's own <c>GroupStatus</c> alongside
/// the sibling <c>OriginalPaymentInformationAndStatus</c> building block) span multiple top-level
/// message building blocks and are enforced on <see cref="BeneficialStrategies.Iso20022.Validation.pain.CustomerPaymentStatusReportV15Validator"/>
/// instead, where both sides of each rule are visible.
///
/// Dependency injection: <c>NumberOfTransactionsPerStatus</c> and <c>StatusReasonInformation</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class OriginalGroupHeader22Validator : AbstractValidator<OriginalGroupHeader22>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public OriginalGroupHeader22Validator(
        IValidator<NumberOfTransactionsPerStatus5> numberOfTransactionsPerStatusValidator,
        IValidator<StatusReasonInformation14> statusReasonInformationValidator
    )
    {
        RuleForEach(x => x.NumberOfTransactionsPerStatus).SetValidator(numberOfTransactionsPerStatusValidator!);
        RuleForEach(x => x.StatusReasonInformation).SetValidator(statusReasonInformationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalGroupHeader22Validator()
        : this(new NumberOfTransactionsPerStatus5Validator(), new StatusReasonInformation14Validator()) { }
}
