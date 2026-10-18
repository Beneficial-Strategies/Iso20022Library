// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation2"/>
[IsoId("_PhL7Gdp-Ed-ak6NoX_4Aeg_-371975028")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation2
{
    /// <inheritdoc cref="IOriginalGroupInformation2.OriginalMessageIdentification"/>
    [IsoId("_PhL7Gtp-Ed-ak6NoX_4Aeg_-371974792")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation2.OriginalMessageNameIdentification"/>
    [IsoId("_PhL7G9p-Ed-ak6NoX_4Aeg_-371974716")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation2.OriginalCreationDateTime"/>
    [IsoId("_PhL7HNp-Ed-ak6NoX_4Aeg_-1661483633")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation2.ReturnReasonInformation"/>
    [IsoId("_PhL7Hdp-Ed-ak6NoX_4Aeg_885861269")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<ReturnReasonInformation1> ReturnReasonInformation { get; init; } = [];
}
