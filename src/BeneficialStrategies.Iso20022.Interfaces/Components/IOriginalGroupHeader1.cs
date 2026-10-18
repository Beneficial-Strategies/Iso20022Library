// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original group, to which the message refers.
/// </summary>
[IsoId("_sniXsFkyEeGeoaLUQk__nA_1278270511")]
public interface IOriginalGroupHeader1 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_sniXsVkyEeGeoaLUQk__nA_1164431445")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    Max35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_snrhoFkyEeGeoaLUQk__nA_281198158")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    Max35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_snrhoVkyEeGeoaLUQk__nA_167359092")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    ISODateTime? OriginalCreationDateTime { get; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_snrholkyEeGeoaLUQk__nA_-829713261")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    Max15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_sn1SoFkyEeGeoaLUQk__nA_-1826785614")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    DecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Specifies the status of a group of transactions.
    /// </summary>
    [IsoId("_sn_DoFkyEeGeoaLUQk__nA_-1057875524")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    TransactionGroupStatus3Code? GroupStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_sn_DoVkyEeGeoaLUQk__nA_-2054947877")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation9> StatusReasonInformation { get; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_soINkFkyEeGeoaLUQk__nA_1242947066")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; }
}
