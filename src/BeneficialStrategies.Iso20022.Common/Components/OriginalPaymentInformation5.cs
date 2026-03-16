// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_PezVcNp-Ed-ak6NoX_4Aeg_-1733791998")]
[DisplayName("Original Payment Information")]
public record OriginalPaymentInformation5
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_PezVcdp-Ed-ak6NoX_4Aeg_270359479")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_PezVctp-Ed-ak6NoX_4Aeg_259260702")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_PezVc9p-Ed-ak6NoX_4Aeg_1199413522")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_PezVdNp-Ed-ak6NoX_4Aeg_22953502")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_PezVddp-Ed-ak6NoX_4Aeg_1477413669")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public StatusReasonInformation9? StatusReasonInformation { get; init; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_PezVdtp-Ed-ak6NoX_4Aeg_558768294")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public NumberOfTransactionsPerStatus3? NumberOfTransactionsPerStatus { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_PezVd9p-Ed-ak6NoX_4Aeg_-476783969")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public PaymentTransactionInformation34? TransactionInformationAndStatus { get; init; }
}
