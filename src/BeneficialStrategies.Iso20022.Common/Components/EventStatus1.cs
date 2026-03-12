// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Notification status of an event.
/// </summary>
[IsoId("_eXYv2a7QEemG7MmivSuE5g")]
[DisplayName("Event Status")]
public partial record EventStatus1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the details provided about an event are complete or incomplete.
    /// </summary>
    [IsoId("_eXYv2q7QEemG7MmivSuE5g")]
    [DisplayName("Event Completeness Status")]
    [IsoXmlTag("EvtCmpltnsSts")]
    public required EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
    
    /// <summary>
    /// Specifies the status of the occurrence of an event.
    /// </summary>
    [IsoId("_eXYv267QEemG7MmivSuE5g")]
    [DisplayName("Event Confirmation Status")]
    [IsoXmlTag("EvtConfSts")]
    public required EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
    
    
    #nullable disable
    
}
