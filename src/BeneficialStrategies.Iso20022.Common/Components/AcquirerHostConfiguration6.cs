// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer configuration parameters for a host.
/// </summary>
[IsoId("_R0Ox0dX2Eeia9rtBTv_9KA")]
[DisplayName("Acquirer Host Configuration")]
public partial record AcquirerHostConfiguration6
{
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_R93O8dX2Eeia9rtBTv_9KA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_R93O89X2Eeia9rtBTv_9KA")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public MessageFunction15Code? MessageToSend { get; init; } 
    
    /// <summary>
    /// Protocol version to use when using these parameters.
    /// </summary>
    [IsoId("_k27msNX2Eeia9rtBTv_9KA")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ProtocolVersion { get; init; } 
    
    
    #nullable disable
    
}
