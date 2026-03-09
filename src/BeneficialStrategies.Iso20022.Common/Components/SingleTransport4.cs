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
/// Specifies individually each leg of a transport of goods.
/// </summary>
[IsoId("_StL9Btp-Ed-ak6NoX_4Aeg_616484036")]
[DisplayName("Single Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SingleTransport4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_StL9B9p-Ed-ak6NoX_4Aeg_616484190")]
    [DisplayName("Transport By Air")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByAir")]
    #endif
    [IsoXmlTag("TrnsprtByAir")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByAir3? TransportByAir { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByAir3? TransportByAir { get; init; } 
    #else
    public TransportByAir3? TransportByAir { get; set; } 
    #endif
    
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("_StL9CNp-Ed-ak6NoX_4Aeg_616484251")]
    [DisplayName("Transport By Sea")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtBySea")]
    #endif
    [IsoXmlTag("TrnsprtBySea")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportBySea3? TransportBySea { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportBySea3? TransportBySea { get; init; } 
    #else
    public TransportBySea3? TransportBySea { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the transportation of goods by road.
    /// </summary>
    [IsoId("_StVuANp-Ed-ak6NoX_4Aeg_616484100")]
    [DisplayName("Transport By Road")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByRoad")]
    #endif
    [IsoXmlTag("TrnsprtByRoad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRoad3? TransportByRoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRoad3? TransportByRoad { get; init; } 
    #else
    public TransportByRoad3? TransportByRoad { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("_StVuAdp-Ed-ak6NoX_4Aeg_616484530")]
    [DisplayName("Transport By Rail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByRail")]
    #endif
    [IsoXmlTag("TrnsprtByRail")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRail3? TransportByRail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRail3? TransportByRail { get; init; } 
    #else
    public TransportByRail3? TransportByRail { get; set; } 
    #endif
    
    
    #nullable disable
    
}
