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
[IsoId("_Sk9sgZZ0EeWuSaWgzo19MQ")]
[DisplayName("Traceability")]
public partial record Traceability5
{
    #nullable enable
    
    /// <summary>
    /// Identification of a partner of a message exchange.
    /// </summary>
    [IsoId("_SxLjkZZ0EeWuSaWgzo19MQ")]
    [DisplayName("Relay Identification")]
    [IsoXmlTag("RlayId")]
    public required GenericIdentification76 RelayIdentification { get; init; } 
    
    /// <summary>
    /// Name of the outgoing protocol used by the node.
    /// </summary>
    [IsoId("_d0ticJZ0EeWuSaWgzo19MQ")]
    [DisplayName("Protocol Name")]
    [IsoXmlTag("PrtcolNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProtocolName { get; init; } 
    
    /// <summary>
    /// Version of the protocol.
    /// </summary>
    [IsoId("_hvgkEJZ0EeWuSaWgzo19MQ")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? ProtocolVersion { get; init; } 
    
    /// <summary>
    /// Date and time of incoming data exchange for relaying or processing.
    /// </summary>
    [IsoId("_SxLjk5Z0EeWuSaWgzo19MQ")]
    [DisplayName("Trace Date Time In")]
    [IsoXmlTag("TracDtTmIn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TraceDateTimeIn { get; init; } 
    
    /// <summary>
    /// Date and time of the outgoing exchange for relaying or processing.
    /// </summary>
    [IsoId("_SxLjlZZ0EeWuSaWgzo19MQ")]
    [DisplayName("Trace Date Time Out")]
    [IsoXmlTag("TracDtTmOut")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TraceDateTimeOut { get; init; } 
    
    
    #nullable disable
    
}
