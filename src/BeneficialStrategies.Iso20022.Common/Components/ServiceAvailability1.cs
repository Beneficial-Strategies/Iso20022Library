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
/// Provides details on the availability of a service.
/// </summary>
[IsoId("_bU4edtEWEeWfZsLg1wugTw")]
[DisplayName("Service Availability")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceAvailability1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceAvailability1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceAvailability1( SystemEventType3Choice_ reqAvailabilityStatus )
    {
        AvailabilityStatus = reqAvailabilityStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the applicable business service.
    /// </summary>
    [IsoId("_bU4eetEWEeWfZsLg1wugTw")]
    [DisplayName("Business Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizSvc")]
    #endif
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BusinessService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessService { get; init; } 
    #else
    public System.String? BusinessService { get; set; } 
    #endif
    
    /// <summary>
    /// Status of service availability.
    /// </summary>
    [IsoId("_bU4eeNEWEeWfZsLg1wugTw")]
    [DisplayName("Availability Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlbtySts")]
    #endif
    [IsoXmlTag("AvlbtySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemEventType3Choice_ AvailabilityStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemEventType3Choice_ AvailabilityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemEventType3Choice_ AvailabilityStatus { get; init; } 
    #else
    public SystemEventType3Choice_ AvailabilityStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
