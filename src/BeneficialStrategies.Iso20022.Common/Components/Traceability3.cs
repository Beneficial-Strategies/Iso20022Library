// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
/// </summary>
[IsoId("_rCd1QXrUEeSfJf8ETXpBxg")]
[DisplayName("Traceability")]
public partial record Traceability3
{
    #nullable enable
    
    /// <summary>
    /// Identification of a partner of a message exchange.
    /// </summary>
    [IsoId("_rPm5YXrUEeSfJf8ETXpBxg")]
    [DisplayName("Relay Identification")]
    [IsoXmlTag("RlayId")]
    public required GenericIdentification74 RelayIdentification { get; init; } 
    
    /// <summary>
    /// Date and time of incoming data exchange for relaying or processing.
    /// </summary>
    [IsoId("_rPm5Y3rUEeSfJf8ETXpBxg")]
    [DisplayName("Trace Date Time In")]
    [IsoXmlTag("TracDtTmIn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TraceDateTimeIn { get; init; } 
    
    /// <summary>
    /// Date and time of the outgoing exchange for relaying or processing.
    /// </summary>
    [IsoId("_rPm5ZXrUEeSfJf8ETXpBxg")]
    [DisplayName("Trace Date Time Out")]
    [IsoXmlTag("TracDtTmOut")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TraceDateTimeOut { get; init; } 
    
    
    #nullable disable
    
}
