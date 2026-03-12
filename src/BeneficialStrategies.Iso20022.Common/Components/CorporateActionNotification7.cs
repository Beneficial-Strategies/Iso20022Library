// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action event notification status and contents.
/// </summary>
[IsoId("_XYtE0TQREe2o-K1dwNg8Gg")]
[DisplayName("Corporate Action Notification")]
public partial record CorporateActionNotification7
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of notification.
    /// </summary>
    [IsoId("_XwQCIzQREe2o-K1dwNg8Gg")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required CorporateActionNotificationType1Code NotificationType { get; init; } 
    
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [IsoId("_XwQCKzQREe2o-K1dwNg8Gg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionProcessingStatus5Choice_ ProcessingStatus { get; init; } 
    
    
    #nullable disable
    
}
