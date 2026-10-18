// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupHeader18"/>
[IsoId("_Iup9rXL_EeidQ_AAdEzxQA")]
[DisplayName("Original Group Header")]
public partial record OriginalGroupHeader18
{
    /// <inheritdoc cref="IOriginalGroupHeader18.OriginalMessageIdentification"/>
    [IsoId("_I5-c03L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader18.OriginalMessageNameIdentification"/>
    [IsoId("_I5-c1XL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader18.OriginalCreationDateTime"/>
    [IsoId("_I5-c13L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader18.ReturnReasonInformation"/>
    [IsoId("_I5-c2XL_EeidQ_AAdEzxQA")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason6> ReturnReasonInformation { get; init; } = [];
}
