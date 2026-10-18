// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation3"/>
[IsoId("_PhL7Htp-Ed-ak6NoX_4Aeg_1562111657")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation3
{
    /// <inheritdoc cref="IOriginalGroupInformation3.OriginalMessageIdentification"/>
    [IsoId("_PhL7H9p-Ed-ak6NoX_4Aeg_1562112141")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation3.OriginalMessageNameIdentification"/>
    [IsoId("_PhVsENp-Ed-ak6NoX_4Aeg_1562112527")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation3.OriginalCreationDateTime"/>
    [IsoId("_PhVsEdp-Ed-ak6NoX_4Aeg_-1535886012")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }
}
