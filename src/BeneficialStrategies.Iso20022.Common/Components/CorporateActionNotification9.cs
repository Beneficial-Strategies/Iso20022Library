// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Notification9.
/// </summary>
[IsoId("_Cy0dQWHNEe6yt_d72zQZeQ")]
[DisplayName("Corporate Action Notification9")]
public partial record CorporateActionNotification9
{
    #nullable enable

    /// <summary>
    /// Notification Identification.
    /// </summary>
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public IsoMax35Text? NotificationIdentification { get; init; } 

    /// <summary>
    /// Notification Type.
    /// </summary>
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required CorporateActionNotificationType1Code NotificationType { get; init; } 

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionProcessingStatus5Choice_ ProcessingStatus { get; init; } 

    
    #nullable disable
    
}
