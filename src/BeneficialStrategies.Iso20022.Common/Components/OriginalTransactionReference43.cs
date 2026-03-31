// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Transaction Reference43.
/// </summary>
[IsoId("_0a0QkTEyEe6g-ffJsqGiSA")]
[DisplayName("Original Transaction Reference43")]
public record OriginalTransactionReference43
{
    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Message Name Identification.
    /// </summary>
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    public IsoMax35Text? MessageNameIdentification { get; init; }

    /// <summary>
    /// Original Transaction.
    /// </summary>
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public ValueList<PaymentIdentification15> OriginalTransaction { get; init; } = [];
}
