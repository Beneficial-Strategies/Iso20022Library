// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupHeader11"/>
[IsoId("_RdfHobThEeef0oKPLRNatg")]
[DisplayName("Original Group Header")]
public partial record OriginalGroupHeader11
{
    /// <inheritdoc cref="IOriginalGroupHeader11.OriginalMessageIdentification"/>
    [IsoId("_RlOHU7ThEeef0oKPLRNatg")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader11.OriginalMessageNameIdentification"/>
    [IsoId("_RlOHVbThEeef0oKPLRNatg")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader11.OriginalCreationDateTime"/>
    [IsoId("_RlOHV7ThEeef0oKPLRNatg")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader11.ReversalReasonInformation"/>
    [IsoId("_RlOHWbThEeef0oKPLRNatg")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason8> ReversalReasonInformation { get; init; } = [];
}
