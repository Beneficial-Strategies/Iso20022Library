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
/// Physical packaging of goods for transport.
/// </summary>
[IsoId("_Iue04TAPEeOKib24wnHaFg")]
[DisplayName("Consignment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Consignment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of packaging units, eg number of boxes, containers, pallets, etc.
    /// </summary>
    [IsoId("_JJRTcTAPEeOKib24wnHaFg")]
    [DisplayName("Total Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlQty")]
    #endif
    [IsoXmlTag("TtlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity10? TotalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity10? TotalQuantity { get; init; } 
    #else
    public Quantity10? TotalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Total volume of goods shipped, eg number of cubic meters.
    /// </summary>
    [IsoId("_JJRTczAPEeOKib24wnHaFg")]
    [DisplayName("Total Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVol")]
    #endif
    [IsoXmlTag("TtlVol")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity10? TotalVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity10? TotalVolume { get; init; } 
    #else
    public Quantity10? TotalVolume { get; set; } 
    #endif
    
    /// <summary>
    /// Total weight of goods shipped, eg number of kg, tons.
    /// </summary>
    [IsoId("_JJRTdTAPEeOKib24wnHaFg")]
    [DisplayName("Total Weight")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlWght")]
    #endif
    [IsoXmlTag("TtlWght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity10? TotalWeight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity10? TotalWeight { get; init; } 
    #else
    public Quantity10? TotalWeight { get; set; } 
    #endif
    
    
    #nullable disable
    
}
