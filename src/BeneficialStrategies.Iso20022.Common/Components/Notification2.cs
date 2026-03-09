// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the type of notification required.
/// </summary>
[IsoId("_j2Sv8DnmEeW7UoCHqpiMaQ")]
[DisplayName("Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Notification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Notification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Notification2( System.String reqNotificationType,System.String reqRequired )
    {
        NotificationType = reqNotificationType;
        Required = reqRequired;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_vifRUDnmEeW7UoCHqpiMaQ")]
    [DisplayName("Notification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnTp")]
    #endif
    [IsoXmlTag("NtfctnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text NotificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NotificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NotificationType { get; init; } 
    #else
    public System.String NotificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the notification is required.
    /// </summary>
    [IsoId("_xG6RcDnmEeW7UoCHqpiMaQ")]
    [DisplayName("Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Reqrd")]
    #endif
    [IsoXmlTag("Reqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Required { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Required { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Required { get; init; } 
    #else
    public System.String Required { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the notification is sent.
    /// </summary>
    [IsoId("_2IHhgTnmEeW7UoCHqpiMaQ")]
    [DisplayName("Distribution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnTp")]
    #endif
    [IsoXmlTag("DstrbtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InformationDistribution1Choice_? DistributionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationDistribution1Choice_? DistributionType { get; init; } 
    #else
    public InformationDistribution1Choice_? DistributionType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
