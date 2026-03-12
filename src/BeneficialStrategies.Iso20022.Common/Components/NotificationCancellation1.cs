// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the cancellation of a notification advice or the withdrawal of a CA event.
/// </summary>
[IsoId("_Rjual9p-Ed-ak6NoX_4Aeg_493176942")]
[DisplayName("Notification Cancellation")]
public partial record NotificationCancellation1
{
    #nullable enable
    
    /// <summary>
    /// The function of the notification e.g. new notification.
    /// </summary>
    [IsoId("_RjuamNp-Ed-ak6NoX_4Aeg_959555478")]
    [DisplayName("Notification Cancellation Type")]
    [IsoXmlTag("NtfctnCxlTp")]
    public required CorporateActionNotificationType2Code NotificationCancellationType { get; init; } 
    
    /// <summary>
    /// The identification of the linked notification advice.
    /// </summary>
    [IsoId("_Rjuamdp-Ed-ak6NoX_4Aeg_959555509")]
    [DisplayName("Linked Agent CA Notification Advice Identification")]
    [IsoXmlTag("LkdAgtCANtfctnAdvcId")]
    public required DocumentIdentification8 LinkedAgentCANotificationAdviceIdentification { get; init; } 
    
    
    #nullable disable
    
}
