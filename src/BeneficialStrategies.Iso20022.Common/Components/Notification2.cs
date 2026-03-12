// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the type of notification required.
/// </summary>
[IsoId("_j2Sv8DnmEeW7UoCHqpiMaQ")]
[DisplayName("Notification")]
public partial record Notification2
{
    #nullable enable
    
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_vifRUDnmEeW7UoCHqpiMaQ")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text NotificationType { get; init; } 
    
    /// <summary>
    /// Indicates whether the notification is required.
    /// </summary>
    [IsoId("_xG6RcDnmEeW7UoCHqpiMaQ")]
    [DisplayName("Required")]
    [IsoXmlTag("Reqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Required { get; init; } 
    
    /// <summary>
    /// Specifies how the notification is sent.
    /// </summary>
    [IsoId("_2IHhgTnmEeW7UoCHqpiMaQ")]
    [DisplayName("Distribution Type")]
    [IsoXmlTag("DstrbtnTp")]
    public InformationDistribution1Choice_? DistributionType { get; init; } 
    
    
    #nullable disable
    
}
