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
/// Basic valuation details of a collateral position.
/// </summary>
[IsoId("_UAL1-dp-Ed-ak6NoX_4Aeg_-606746879")]
[DisplayName("Basic Collateral Valuation 1 Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BasicCollateralValuation1Details
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BasicCollateralValuation1Details instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BasicCollateralValuation1Details( System.Decimal reqValuationHaircut )
    {
        ValuationHaircut = reqValuationHaircut;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Haircut percentage applied to the market value of underlying assets used as collateral as a risk control measure. The institution valuating the collateral calculates the value of underlying assets based on its market value less a certain percentage (the haircut).
    /// </summary>
    [IsoId("_UAL1-tp-Ed-ak6NoX_4Aeg_-606746854")]
    [DisplayName("Valuation Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnHrcut")]
    #endif
    [IsoXmlTag("ValtnHrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate ValuationHaircut { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ValuationHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ValuationHaircut { get; init; } 
    #else
    public System.Decimal ValuationHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the valuation haircut was calculated.
    /// </summary>
    [IsoId("_UAVm8Np-Ed-ak6NoX_4Aeg_-606746837")]
    [DisplayName("Haircut Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HrcutSrc")]
    #endif
    [IsoXmlTag("HrcutSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification15? HaircutSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification15? HaircutSource { get; init; } 
    #else
    public PartyIdentification15? HaircutSource { get; set; } 
    #endif
    
    
    #nullable disable
    
}
