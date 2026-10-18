// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the original transaction, to which the status report message refers.
/// </summary>
[IsoId("830133ba-0d8f-4554-8a2e-779f67d6fbd1")]
public interface IOriginalPaymentInstruction56 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("a3560f2c-3a9f-43c2-8b52-4ed255ff5e9d")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("c0ef9d4a-4b9e-4f54-88a6-e1478d1d183a")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("b9d9e4e3-c695-4bcd-a6a6-68a30253f8a8")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("c71ae9d9-fb45-43d8-a4af-b01c2dfc0014")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("4c3d7e5b-c9b4-49bb-a096-ca819bc98d66")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation14> StatusReasonInformation { get; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("491ebc1b-7b30-40b2-9a4c-91ac564cd3e5")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; }

    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("daa1b218-cd35-46e9-8318-5e1a7eab1b89")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    IEnumerable<IPaymentTransaction178> TransactionInformationAndStatus { get; }
}
