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
[IsoId("_UXQgr2XlEeap-P22vGV91g")]
[DisplayName("Original Payment Instruction")]
public record OriginalPaymentInstruction22
{
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    [IsoId("_Ukg5iWXlEeap-P22vGV91g")]
    [DisplayName("Original Payment Information Cancellation Identification")]
    [IsoXmlTag("OrgnlPmtInfCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_Ukg5i2XlEeap-P22vGV91g")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case3? ResolvedCase { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_Ukg5jWXlEeap-P22vGV91g")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_Ukg5j2XlEeap-P22vGV91g")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_Ukg5kWXlEeap-P22vGV91g")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_Ukg5k2XlEeap-P22vGV91g")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    [IsoId("_Ukg5lWXlEeap-P22vGV91g")]
    [DisplayName("Payment Information Cancellation Status")]
    [IsoXmlTag("PmtInfCxlSts")]
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_Ukg5l2XlEeap-P22vGV91g")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public ValueList<CancellationStatusReason2> CancellationStatusReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_Ukg5mWXlEeap-P22vGV91g")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public ValueList<NumberOfCancellationsPerStatus1> NumberOfTransactionsPerCancellationStatus { get; init; } =
        [];

    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_Ukg5m2XlEeap-P22vGV91g")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction78> TransactionInformationAndStatus { get; init; } = [];
}
