// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Message7.
/// </summary>
[IsoId("_8CfzrzEyEe6g-ffJsqGiSA")]
[DisplayName("Original Message7")]
public partial record OriginalMessage7
{
    /// <summary>
    /// Original Sender.
    /// </summary>
    [DisplayName("Original Sender")]
    [IsoXmlTag("OrgnlSndr")]
    public Party50Choice_? OriginalSender { get; init; }

    /// <summary>
    /// Original Message Identification.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required Max35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Original Message Name Identification.
    /// </summary>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required Max35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Original Creation Date Time.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public ISODateTime? OriginalCreationDateTime { get; init; }
}
