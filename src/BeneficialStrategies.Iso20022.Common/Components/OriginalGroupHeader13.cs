// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupHeader13"/>
[IsoId("_FfcoUbThEeef0oKPLRNatg")]
[DisplayName("Original Group Header")]
public partial record OriginalGroupHeader13
{
    /// <inheritdoc cref="IOriginalGroupHeader13.OriginalMessageIdentification"/>
    [IsoId("_FsipJ7ThEeef0oKPLRNatg")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader13.OriginalMessageNameIdentification"/>
    [IsoId("_FsipKbThEeef0oKPLRNatg")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader13.OriginalCreationDateTime"/>
    [IsoId("_FsipK7ThEeef0oKPLRNatg")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader13.OriginalNumberOfTransactions"/>
    [IsoId("_FsipLbThEeef0oKPLRNatg")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader13.OriginalControlSum"/>
    [IsoId("_FsipL7ThEeef0oKPLRNatg")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader13.GroupStatus"/>
    [IsoId("_FsipMbThEeef0oKPLRNatg")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    public ExternalPaymentGroupStatus1Code? GroupStatus { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader13.StatusReasonInformation"/>
    [IsoId("_FsipM7ThEeef0oKPLRNatg")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation11> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalGroupHeader13.NumberOfTransactionsPerStatus"/>
    [IsoId("_FsipNbThEeef0oKPLRNatg")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];
}
