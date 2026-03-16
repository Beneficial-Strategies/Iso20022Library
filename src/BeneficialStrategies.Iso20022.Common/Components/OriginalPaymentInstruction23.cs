// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details information on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_VWH872XlEeap-P22vGV91g")]
[DisplayName("Original Payment Instruction")]
public record OriginalPaymentInstruction23
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_ViC4y2XlEeap-P22vGV91g")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_ViC4zWXlEeap-P22vGV91g")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_ViC4z2XlEeap-P22vGV91g")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_ViC40WXlEeap-P22vGV91g")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_ViC402XlEeap-P22vGV91g")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_ViC41WXlEeap-P22vGV91g")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_ViC412XlEeap-P22vGV91g")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction82> TransactionInformationAndStatus { get; init; } = [];
}
