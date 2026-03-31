// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original group, to which the message refers.
/// </summary>
[IsoId("_Pk6khNp-Ed-ak6NoX_4Aeg_1311252989")]
[DisplayName("Original Group Information")]
public record OriginalGroupInformation20
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_Pk6khdp-Ed-ak6NoX_4Aeg_1311253011")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_Pk6khtp-Ed-ak6NoX_4Aeg_1311253103")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_PlEVgNp-Ed-ak6NoX_4Aeg_1311253535")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_PlEVgdp-Ed-ak6NoX_4Aeg_1311253473")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_PlEVgtp-Ed-ak6NoX_4Aeg_1311253504")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of a group of transactions.
    /// </summary>
    [IsoId("_PlEVg9p-Ed-ak6NoX_4Aeg_1311253195")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    public TransactionGroupStatus3Code? GroupStatus { get; init; }

    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_PlEVhNp-Ed-ak6NoX_4Aeg_1311253875")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation8> StatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_PlEVhdp-Ed-ak6NoX_4Aeg_1311253580")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];
}
