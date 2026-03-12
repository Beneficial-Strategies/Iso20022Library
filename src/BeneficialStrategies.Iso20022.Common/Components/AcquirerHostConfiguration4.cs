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
[IsoId("_A4Mg8bDFEeamYaqfhG1ZuA")]
[DisplayName("Acquirer Host Configuration")]
public partial record AcquirerHostConfiguration4
{
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_BCpdcbDFEeamYaqfhG1ZuA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_BCqEgLDFEeamYaqfhG1ZuA")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public MessageFunction12Code? MessageToSend { get; init; } 
    
    
    #nullable disable
    
}
