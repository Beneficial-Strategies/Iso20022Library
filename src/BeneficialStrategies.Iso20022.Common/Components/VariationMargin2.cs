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
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards central counterparty.
/// </summary>
[IsoId("_Uk2CN9p-Ed-ak6NoX_4Aeg_1785473393")]
[DisplayName("Variation Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VariationMargin2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VariationMargin2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VariationMargin2( Amount2 reqTotalMarkToMarket,Amount2 reqFailsHaircut )
    {
        TotalMarkToMarket = reqTotalMarkToMarket;
        FailsHaircut = reqFailsHaircut;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
    /// </summary>
    [IsoId("_Uk2CONp-Ed-ak6NoX_4Aeg_-292711042")]
    [DisplayName("Total Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVartnMrgn")]
    #endif
    [IsoXmlTag("TtlVartnMrgn")]
    public ValueList<TotalVariationMargin1> TotalVariationMargin { get; init; } = new ValueList<TotalVariationMargin1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Uk2CONp-Ed-ak6NoX_4Aeg_-292711042
    
    /// <summary>
    /// Net unrealised profit or loss on the value of the netted, gross and failing positions.
    /// </summary>
    [IsoId("_Uk_MINp-Ed-ak6NoX_4Aeg_-514484433")]
    [DisplayName("Total Mark To Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlMrkToMkt")]
    #endif
    [IsoXmlTag("TtlMrkToMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2 TotalMarkToMarket { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2 TotalMarkToMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2 TotalMarkToMarket { get; init; } 
    #else
    public Amount2 TotalMarkToMarket { get; set; } 
    #endif
    
    /// <summary>
    /// Unrealised net loss calculated at the participant portfolio level.
    /// </summary>
    [IsoId("_Uk_MIdp-Ed-ak6NoX_4Aeg_526741485")]
    [DisplayName("Mark To Market Netted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrkToMktNetd")]
    #endif
    [IsoXmlTag("MrkToMktNetd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2? MarkToMarketNetted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2? MarkToMarketNetted { get; init; } 
    #else
    public Amount2? MarkToMarketNetted { get; set; } 
    #endif
    
    /// <summary>
    /// Unrealised net loss calculated in that market/boundary.
    /// </summary>
    [IsoId("_Uk_MItp-Ed-ak6NoX_4Aeg_-859385259")]
    [DisplayName("Mark To Market Gross")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrkToMktGrss")]
    #endif
    [IsoXmlTag("MrkToMktGrss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2? MarkToMarketGross { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2? MarkToMarketGross { get; init; } 
    #else
    public Amount2? MarkToMarketGross { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the unrealised loss without taking profit into consideration.
    /// </summary>
    [IsoId("_Uk_MI9p-Ed-ak6NoX_4Aeg_-781100489")]
    [DisplayName("Mark To Market Fails")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrkToMktFls")]
    #endif
    [IsoXmlTag("MrkToMktFls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2? MarkToMarketFails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2? MarkToMarketFails { get; init; } 
    #else
    public Amount2? MarkToMarketFails { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut applied to the absolute value of the participants net positions. Calculation depends on a participants credit rating.
    /// </summary>
    [IsoId("_Uk_MJNp-Ed-ak6NoX_4Aeg_1551318789")]
    [DisplayName("Fails Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlsHrcut")]
    #endif
    [IsoXmlTag("FlsHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2 FailsHaircut { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2 FailsHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2 FailsHaircut { get; init; } 
    #else
    public Amount2 FailsHaircut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
