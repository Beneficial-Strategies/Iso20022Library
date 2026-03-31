// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_2sb70SNsEeKdIYatzYH-pQ")]
[DisplayName("Original Payment Instruction")]
public record OriginalPaymentInstruction9
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_23ANJSNsEeKdIYatzYH-pQ")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_23ANKSNsEeKdIYatzYH-pQ")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_23ANLSNsEeKdIYatzYH-pQ")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_23ANMSNsEeKdIYatzYH-pQ")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_23ANOSNsEeKdIYatzYH-pQ")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_23ANPSNsEeKdIYatzYH-pQ")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_23ANQSNsEeKdIYatzYH-pQ")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction49> TransactionInformationAndStatus { get; init; } = [];
}
