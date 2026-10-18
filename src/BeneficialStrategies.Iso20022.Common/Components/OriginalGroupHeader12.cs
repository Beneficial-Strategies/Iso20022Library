// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupHeader12"/>
[IsoId("_NG1QcbThEeef0oKPLRNatg")]
[DisplayName("Original Group Header")]
public partial record OriginalGroupHeader12
{
    /// <inheritdoc cref="IOriginalGroupHeader12.OriginalMessageIdentification"/>
    [IsoId("_NObGM7ThEeef0oKPLRNatg")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader12.OriginalMessageNameIdentification"/>
    [IsoId("_NObGNbThEeef0oKPLRNatg")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader12.OriginalCreationDateTime"/>
    [IsoId("_NObGN7ThEeef0oKPLRNatg")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader12.ReturnReasonInformation"/>
    [IsoId("_NObGObThEeef0oKPLRNatg")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason4> ReturnReasonInformation { get; init; } = [];
}
