// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_PezVcNp-Ed-ak6NoX_4Aeg_-1733791998")]
public interface IOriginalPaymentInformation5 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_PezVcdp-Ed-ak6NoX_4Aeg_270359479")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_PezVctp-Ed-ak6NoX_4Aeg_259260702")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_PezVc9p-Ed-ak6NoX_4Aeg_1199413522")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_PezVdNp-Ed-ak6NoX_4Aeg_22953502")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    TransactionGroupStatus3Code? PaymentInformationStatus { get; }

    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_PezVddp-Ed-ak6NoX_4Aeg_1477413669")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation9> StatusReasonInformation { get; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_PezVdtp-Ed-ak6NoX_4Aeg_558768294")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; }

    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_PezVd9p-Ed-ak6NoX_4Aeg_-476783969")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    IEnumerable<IPaymentTransactionInformation34> TransactionInformationAndStatus { get; }
}
