// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of the group of transactions as assigned by the original instructing party.
/// </summary>
[IsoId("_Pg5AJ9p-Ed-ak6NoX_4Aeg_312087008")]
public interface IOriginalGroupInformation1 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    [IsoId("_PhCxINp-Ed-ak6NoX_4Aeg_312087051")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    IsoMax35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Name assigned by the sending party to unambiguously identify the file transmitted on the network.
    /// </summary>
    [IsoId("_PhCxIdp-Ed-ak6NoX_4Aeg_312087103")]
    [DisplayName("Network File Name")]
    [IsoXmlTag("NtwkFileNm")]
    IsoMax35Text NetworkFileName { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers, eg, pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_PhCxItp-Ed-ak6NoX_4Aeg_312087145")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    IsoMax35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_PhCxI9p-Ed-ak6NoX_4Aeg_-1531265541")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    IsoISODateTime? OriginalCreationDateTime { get; }

    /// <summary>
    /// Party that sent the file for which the status has been generated.||Usage: this field will only be used when the content of the message could not be decoded at the receiving side.
    /// </summary>
    [IsoId("_PhCxJNp-Ed-ak6NoX_4Aeg_312087552")]
    [DisplayName("File Originator")]
    [IsoXmlTag("FileOrgtr")]
    IsoMax35Text? FileOriginator { get; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_PhCxJdp-Ed-ak6NoX_4Aeg_-1131768667")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_PhCxJtp-Ed-ak6NoX_4Aeg_-1130848635")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Specifies the status of a group of transactions.
    /// </summary>
    [IsoId("_PhCxJ9p-Ed-ak6NoX_4Aeg_312087595")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    TransactionGroupStatus1Code? GroupStatus { get; }

    /// <summary>
    /// Detailed information on the status reason.
    /// </summary>
    [IsoId("_PhCxKNp-Ed-ak6NoX_4Aeg_832816360")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation1> StatusReasonInformation { get; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical individual transaction status.
    /// </summary>
    [IsoId("_PhCxKdp-Ed-ak6NoX_4Aeg_2049376412")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    IEnumerable<INumberOfTransactionsPerStatus1> NumberOfTransactionsPerStatus { get; }
}
