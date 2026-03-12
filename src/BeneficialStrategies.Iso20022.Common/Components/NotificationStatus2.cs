// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies if the occurrence of the event contained in the notification is confirmed or unconfirmed. Details of the event can be complete or incomplete.
/// </summary>
[IsoId("_jMDpUXF2EeSuDsBOD9TlUw")]
[DisplayName("Notification Status")]
public partial record NotificationStatus2
{
    #nullable enable
    
    /// <summary>
    /// Status to define if the occurrence of the event contained in the notification is confirmed or unconfirmed.
    /// </summary>
    [IsoId("_jphBY3F2EeSuDsBOD9TlUw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required NotificationStatus2Code Status { get; init; } 
    
    
    #nullable disable
    
}
