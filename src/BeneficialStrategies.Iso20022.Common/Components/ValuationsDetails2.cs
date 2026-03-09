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
/// Valuation details for the cash position.
/// </summary>
[IsoId("_LuJTafGMEei2UYJ62ws-Fw")]
[DisplayName("Valuations Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationsDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValuationsDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValuationsDetails2( System.Decimal reqHaircut )
    {
        Haircut = reqHaircut;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Securities collateral position valuation amounts.
    /// </summary>
    [IsoId("_LuJTcfGMEei2UYJ62ws-Fw")]
    [DisplayName("Valuation Details Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtlsAmt")]
    #endif
    [IsoXmlTag("ValtnDtlsAmt")]
    public ValueList<CollateralAmount9> ValuationDetailsAmount { get; init; } = new ValueList<CollateralAmount9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _LuJTcfGMEei2UYJ62ws-Fw
    
    /// <summary>
    /// Haircut or margin on the security  expressed as a percentage.
    /// </summary>
    [IsoId("_ZyuksTYnEeuD7rm9md9zvg")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate Haircut { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Haircut { get; init; } 
    #else
    public System.Decimal Haircut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
