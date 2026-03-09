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
/// Transparency calculation specific details for a freight commodity.
/// </summary>
[IsoId("_njM5VU-nEeiVsYLJl6hleg")]
[DisplayName("Commodity Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommodityDerivative5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommodityDerivative5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommodityDerivative5( System.String reqSize,System.String reqAverageTimeCharter )
    {
        Size = reqSize;
        AverageTimeCharter = reqAverageTimeCharter;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specification of the size related to the freight sub type. Field to be populated when the base product field is equal to freight.
    /// </summary>
    [IsoId("_nsafsU-nEeiVsYLJl6hleg")]
    [DisplayName("Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sz")]
    #endif
    [IsoXmlTag("Sz")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax25Text Size { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Size { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Size { get; init; } 
    #else
    public System.String Size { get; set; } 
    #endif
    
    /// <summary>
    /// Details the specific route or time charter average. Field to be populated when the base product field is equal to freight.
    /// </summary>
    [IsoId("_nsafs0-nEeiVsYLJl6hleg")]
    [DisplayName("Average Time Charter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgTmChrtr")]
    #endif
    [IsoXmlTag("AvrgTmChrtr")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax25Text AverageTimeCharter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AverageTimeCharter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AverageTimeCharter { get; init; } 
    #else
    public System.String AverageTimeCharter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
