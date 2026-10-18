// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation5"/>
[IsoId("_PhVsF9p-Ed-ak6NoX_4Aeg_-330079515")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation5
{
    /// <inheritdoc cref="IOriginalGroupInformation5.OriginalMessageIdentification"/>
    [IsoId("_PhVsGNp-Ed-ak6NoX_4Aeg_-330079473")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation5.OriginalMessageNameIdentification"/>
    [IsoId("_PhfdENp-Ed-ak6NoX_4Aeg_-330079430")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation5.OriginalCreationDateTime"/>
    [IsoId("_PhfdEdp-Ed-ak6NoX_4Aeg_-1500789550")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation5.ReversalReasonInformation"/>
    [IsoId("_PhfdEtp-Ed-ak6NoX_4Aeg_-330079368")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<ReversalReasonInformation1> ReversalReasonInformation { get; init; } = [];
}
