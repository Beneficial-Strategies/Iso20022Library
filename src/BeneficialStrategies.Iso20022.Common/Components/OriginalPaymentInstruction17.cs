// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_k8pBDzq3EeWZFYSPlduMhw")]
[DisplayName("Original Payment Instruction")]
public record OriginalPaymentInstruction17
{
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    [IsoId("_lFIOqTq3EeWZFYSPlduMhw")]
    [DisplayName("Original Payment Information Cancellation Identification")]
    [IsoXmlTag("OrgnlPmtInfCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_lFIOqzq3EeWZFYSPlduMhw")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case3? ResolvedCase { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_lFIOrTq3EeWZFYSPlduMhw")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_lFIOrzq3EeWZFYSPlduMhw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_lFIOsTq3EeWZFYSPlduMhw")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_lFIOszq3EeWZFYSPlduMhw")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    [IsoId("_lFIOtTq3EeWZFYSPlduMhw")]
    [DisplayName("Payment Information Cancellation Status")]
    [IsoXmlTag("PmtInfCxlSts")]
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_lFIOtzq3EeWZFYSPlduMhw")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public ValueList<CancellationStatusReason2> CancellationStatusReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_lFIOuTq3EeWZFYSPlduMhw")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public ValueList<NumberOfCancellationsPerStatus1> NumberOfTransactionsPerCancellationStatus { get; init; } =
        [];

    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_lFIOuzq3EeWZFYSPlduMhw")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction66> TransactionInformationAndStatus { get; init; } = [];
}
