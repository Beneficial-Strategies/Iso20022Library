// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation25"/>
[IsoId("_Pe9Ge9p-Ed-ak6NoX_4Aeg_-379878312")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation25
{
    /// <inheritdoc cref="IOriginalGroupInformation25.OriginalMessageIdentification"/>
    [IsoId("_Pe9GfNp-Ed-ak6NoX_4Aeg_-714905591")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation25.OriginalMessageNameIdentification"/>
    [IsoId("_Pe9Gfdp-Ed-ak6NoX_4Aeg_225247229")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation25.OriginalCreationDateTime"/>
    [IsoId("_Pe9Gftp-Ed-ak6NoX_4Aeg_-1000778660")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation25.OriginalNumberOfTransactions"/>
    [IsoId("_Pe9Gf9p-Ed-ak6NoX_4Aeg_1490921697")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation25.OriginalControlSum"/>
    [IsoId("_Pe9GgNp-Ed-ak6NoX_4Aeg_-1231894763")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation25.GroupStatus"/>
    [IsoId("_Pe9Ggdp-Ed-ak6NoX_4Aeg_-1895110724")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    public TransactionGroupStatus3Code? GroupStatus { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation25.StatusReasonInformation"/>
    [IsoId("_PfG3cNp-Ed-ak6NoX_4Aeg_-686759930")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalGroupInformation25.NumberOfTransactionsPerStatus"/>
    [IsoId("_PfG3cdp-Ed-ak6NoX_4Aeg_28156858")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];
}
