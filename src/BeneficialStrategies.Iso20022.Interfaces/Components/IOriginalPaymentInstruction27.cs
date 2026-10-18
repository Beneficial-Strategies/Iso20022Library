// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details information on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_jV5c4bPfEeeppqgHuc69jg")]
public interface IOriginalPaymentInstruction27 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_je-ga7PfEeeppqgHuc69jg")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_je-gbbPfEeeppqgHuc69jg")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_je-gb7PfEeeppqgHuc69jg")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_je-gcbPfEeeppqgHuc69jg")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_je-gc7PfEeeppqgHuc69jg")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation11> StatusReasonInformation { get; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_je-gdbPfEeeppqgHuc69jg")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; }

    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_je-gd7PfEeeppqgHuc69jg")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    IEnumerable<IPaymentTransaction92> TransactionInformationAndStatus { get; }
}
