// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a linked meeting event.
/// </summary>
[IsoId("_M8fK-a7rEemG7MmivSuE5g")]
[DisplayName("Meeting Event Reference")]
public partial record MeetingEventReference1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the linked meeting event.
    /// </summary>
    [IsoId("_M8fK-q7rEemG7MmivSuE5g")]
    [DisplayName("Event Identification")]
    [IsoXmlTag("EvtId")]
    public required MeetingEventReference1Choice_ EventIdentification { get; init; } 
    
    /// <summary>
    /// Specifies when the event is to be processed relative to the linked event.
    /// </summary>
    [IsoId("_M8fK-67rEemG7MmivSuE5g")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition3Code? LinkageType { get; init; } 
    
    
    #nullable disable
    
}
