// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupHeader19"/>
[Description(@"Provides information on the original group, to which the message refers.")]
[IsoId("_xUbucTEyEe6g-ffJsqGiSA")]
[DisplayName("Original Group Header19")]
public partial record OriginalGroupHeader19
{
    /// <inheritdoc cref="IOriginalGroupHeader19.OriginalCreationDateTime"/>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader19.OriginalMessageIdentification"/>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader19.OriginalMessageNameIdentification"/>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader19.ReturnReasonInformation"/>
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    public ValueList<PaymentReturnReason7> ReturnReasonInformation { get; init; } = [];
}
