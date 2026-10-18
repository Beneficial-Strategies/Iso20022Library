// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original group, to which the message refers.
/// </summary>
[IsoId("_4qUW4TEyEe6g-ffJsqGiSA")]
public interface IOriginalGroupHeader22 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    Max35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    Max35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    ISODateTime? OriginalCreationDateTime { get; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    Max15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    DecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Specifies the status of a group of transactions.
    /// </summary>
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    ExternalPaymentGroupStatus1Code? GroupStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation14> StatusReasonInformation { get; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; }
}
