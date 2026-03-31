// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the header data such as the identification and the creation date and time, specific to the message.
/// </summary>
[IsoId("_riYGEYm6Eeipw6hHPgB4Sw")]
[DisplayName("Message Header")]
public record MessageHeader11
{
    /// <summary>
    /// Point to point reference, as assigned by the sender, to unambiguously identify the message.|Usage: The sender has to make sure that MessageIdentification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_rxijc4m6Eeipw6hHPgB4Sw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_rxijdYm6Eeipw6hHPgB4Sw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Specific actions to be executed through the request.
    /// </summary>
    [IsoId("_rxijd4m6Eeipw6hHPgB4Sw")]
    [DisplayName("Request Type")]
    [IsoXmlTag("ReqTp")]
    public RequestType4Choice_? RequestType { get; init; }

    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_rxijeYm6Eeipw6hHPgB4Sw")]
    [DisplayName("Original Business Query")]
    [IsoXmlTag("OrgnlBizQry")]
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; }
}
