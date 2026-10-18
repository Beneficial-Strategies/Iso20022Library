// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation1"/>
[IsoId("_Pg5AJ9p-Ed-ak6NoX_4Aeg_312087008")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation1
{
    /// <inheritdoc cref="IOriginalGroupInformation1.OriginalMessageIdentification"/>
    [IsoId("_PhCxINp-Ed-ak6NoX_4Aeg_312087051")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.NetworkFileName"/>
    [IsoId("_PhCxIdp-Ed-ak6NoX_4Aeg_312087103")]
    [DisplayName("Network File Name")]
    [IsoXmlTag("NtwkFileNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text NetworkFileName { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.OriginalMessageNameIdentification"/>
    [IsoId("_PhCxItp-Ed-ak6NoX_4Aeg_312087145")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.OriginalCreationDateTime"/>
    [IsoId("_PhCxI9p-Ed-ak6NoX_4Aeg_-1531265541")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.FileOriginator"/>
    [IsoId("_PhCxJNp-Ed-ak6NoX_4Aeg_312087552")]
    [DisplayName("File Originator")]
    [IsoXmlTag("FileOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FileOriginator { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.OriginalNumberOfTransactions"/>
    [IsoId("_PhCxJdp-Ed-ak6NoX_4Aeg_-1131768667")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.OriginalControlSum"/>
    [IsoId("_PhCxJtp-Ed-ak6NoX_4Aeg_-1130848635")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.GroupStatus"/>
    [IsoId("_PhCxJ9p-Ed-ak6NoX_4Aeg_312087595")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    public TransactionGroupStatus1Code? GroupStatus { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation1.StatusReasonInformation"/>
    [IsoId("_PhCxKNp-Ed-ak6NoX_4Aeg_832816360")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation1> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalGroupInformation1.NumberOfTransactionsPerStatus"/>
    [IsoId("_PhCxKdp-Ed-ak6NoX_4Aeg_2049376412")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus1> NumberOfTransactionsPerStatus { get; init; } =
        [];
}
