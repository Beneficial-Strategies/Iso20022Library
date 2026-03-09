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
/// Attributes of energy related derivatives.
/// </summary>
[IsoId("_b-a7sZjgEeqkLZLH6DK3UQ")]
[DisplayName("Energy Specific Attribute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnergySpecificAttribute6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the delivery point(s) of market area(s) for energy derivative contracts.
    /// </summary>
    [IsoId("_b-3noZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Point Or Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryPtOrZone")]
    #endif
    [IsoXmlTag("DlvryPtOrZone")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryInterconnectionPoint1Choice_? DeliveryPointOrZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryInterconnectionPoint1Choice_? DeliveryPointOrZone { get; init; } 
    #else
    public DeliveryInterconnectionPoint1Choice_? DeliveryPointOrZone { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the border(s) or border point(s) of a transportation contract.
    /// </summary>
    [IsoId("_b-3no5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Inter Connection Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrCnnctnPt")]
    #endif
    [IsoXmlTag("IntrCnnctnPt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryInterconnectionPoint1Choice_? InterConnectionPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryInterconnectionPoint1Choice_? InterConnectionPoint { get; init; } 
    #else
    public DeliveryInterconnectionPoint1Choice_? InterConnectionPoint { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the delivery profile.
    /// </summary>
    [IsoId("_b-3npZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Load Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LdTp")]
    #endif
    [IsoXmlTag("LdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnergyLoadType1Code? LoadType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnergyLoadType1Code? LoadType { get; init; } 
    #else
    public EnergyLoadType1Code? LoadType { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes related to delivery of derivative contracts.
    /// </summary>
    [IsoId("_b-3np5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Delivery Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryAttr")]
    #endif
    [IsoXmlTag("DlvryAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnergyDeliveryAttribute5? DeliveryAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnergyDeliveryAttribute5? DeliveryAttribute { get; init; } 
    #else
    public EnergyDeliveryAttribute5? DeliveryAttribute { get; set; } 
    #endif
    
    
    #nullable disable
    
}
