// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reference information to the original message.
/// </summary>
[IsoId("_tqS1MlkyEeGeoaLUQk__nA_-2039309166")]
[DisplayName("Original Transaction Reference")]
public record OriginalTransactionReference18
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_tqS1M1kyEeGeoaLUQk__nA_-785757445")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_tqcmMFkyEeGeoaLUQk__nA_-1896668864")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_tqcmMVkyEeGeoaLUQk__nA_517992792")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Provides reference information to the original transaction.
    /// </summary>
    [IsoId("_tqcmMlkyEeGeoaLUQk__nA_-592918627")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public ValueList<PaymentIdentification4> OriginalTransaction { get; init; } = [];
}
