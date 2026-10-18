// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the original transaction, to which the status report message refers.
/// </summary>
[IsoId("_y2Vb5cloEem0vqvvoqYsqQ")]
public interface IOriginalPaymentInstruction38 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_zA67G8loEem0vqvvoqYsqQ")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_zA67HcloEem0vqvvoqYsqQ")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_zA67H8loEem0vqvvoqYsqQ")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_zA67IcloEem0vqvvoqYsqQ")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_zA67I8loEem0vqvvoqYsqQ")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation12> StatusReasonInformation { get; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_zA67JcloEem0vqvvoqYsqQ")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; }

    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_zA67J8loEem0vqvvoqYsqQ")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    IEnumerable<IPaymentTransaction126> TransactionInformationAndStatus { get; }
}
