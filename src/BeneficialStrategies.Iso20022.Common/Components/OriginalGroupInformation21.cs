// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupInformation21"/>
[IsoId("_PlNfc9p-Ed-ak6NoX_4Aeg_-545099253")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation21
{
    /// <inheritdoc cref="IOriginalGroupInformation21.OriginalMessageIdentification"/>
    [IsoId("_PlNfdNp-Ed-ak6NoX_4Aeg_-545099251")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation21.OriginalMessageNameIdentification"/>
    [IsoId("_PlNfddp-Ed-ak6NoX_4Aeg_-545099192")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation21.OriginalCreationDateTime"/>
    [IsoId("_PlNfdtp-Ed-ak6NoX_4Aeg_-544179167")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupInformation21.ReturnReasonInformation"/>
    [IsoId("_PlNfd9p-Ed-ak6NoX_4Aeg_-544179074")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<ReturnReasonInformation9> ReturnReasonInformation { get; init; } = [];
}
