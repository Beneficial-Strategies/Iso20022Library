// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Payment Instruction47.
/// </summary>
[IsoId("_8muJwTEsEe6GxLzpkVnWYg")]
public interface IOriginalPaymentInstruction47 : IIsoComponent
{
    /// <summary>
    /// Number Of Transactions Per Status.
    /// </summary>
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; }

    /// <summary>
    /// Original Control Sum.
    /// </summary>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Original Number Of Transactions.
    /// </summary>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Original Payment Information Identification.
    /// </summary>
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Payment Information Status.
    /// </summary>
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; }

    /// <summary>
    /// Status Reason Information.
    /// </summary>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation14> StatusReasonInformation { get; }

    /// <summary>
    /// Transaction Information And Status.
    /// </summary>
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    IEnumerable<IPaymentTransaction150> TransactionInformationAndStatus { get; }
}
