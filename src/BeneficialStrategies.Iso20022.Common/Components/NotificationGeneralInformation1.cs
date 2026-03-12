// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event notification type and status.
/// </summary>
[IsoId("_9QWS-67OEemG7MmivSuE5g")]
[DisplayName("Notification General Information")]
public partial record NotificationGeneralInformation1
{
    #nullable enable
    
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_9QWS_a7OEemG7MmivSuE5g")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required NotificationType3Code NotificationType { get; init; } 
    
    /// <summary>
    /// Status of the details of the event.
    /// </summary>
    [IsoId("_9QgD8K7OEemG7MmivSuE5g")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public required EventStatus1 NotificationStatus { get; init; } 
    
    
    #nullable disable
    
}
