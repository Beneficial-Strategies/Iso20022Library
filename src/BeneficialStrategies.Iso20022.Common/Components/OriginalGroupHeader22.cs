// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupHeader22"/>
[IsoId("_4qUW4TEyEe6g-ffJsqGiSA")]
[Description(@"Provides details on the original group, to which the message refers.")]
[DisplayName("Original Group Header22")]
public partial record OriginalGroupHeader22
{
    /// <inheritdoc cref="IOriginalGroupHeader22.GroupStatus"/>
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    public ExternalPaymentGroupStatus1Code? GroupStatus { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader22.NumberOfTransactionsPerStatus"/>
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalGroupHeader22.OriginalControlSum"/>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader22.OriginalCreationDateTime"/>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader22.OriginalMessageIdentification"/>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader22.OriginalMessageNameIdentification"/>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader22.OriginalNumberOfTransactions"/>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader22.StatusReasonInformation"/>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation14> StatusReasonInformation { get; init; } = [];
}
