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
[IsoId("_K8dXQH1DEeCF8NjrBemJWQ_-885383868")]
[DisplayName("Acquirer Host Configuration")]
public partial record AcquirerHostConfiguration1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_K8nIQH1DEeCF8NjrBemJWQ_-2088821006")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_K8nIQX1DEeCF8NjrBemJWQ_-2022756489")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public SimpleValueList<MessageFunction3Code> MessageToSend { get; init; } = new SimpleValueList<MessageFunction3Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _K8nIQX1DEeCF8NjrBemJWQ_-2022756489
    
    
    #nullable disable
    
}
