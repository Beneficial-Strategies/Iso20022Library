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
[IsoId("_-eWgAKMOEeCojJW5vEuTEQ_-52349864")]
[DisplayName("Variation Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VariationMargin3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VariationMargin3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VariationMargin3( Amount2 reqTotalMarkToMarket )
    {
        TotalMarkToMarket = reqTotalMarkToMarket;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_-eWgAaMOEeCojJW5vEuTEQ_-317540862")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
    /// </summary>
    [IsoId("_-eWgAqMOEeCojJW5vEuTEQ_-166188930")]
    [DisplayName("Total Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVartnMrgn")]
    #endif
    [IsoXmlTag("TtlVartnMrgn")]
    public ValueList<TotalVariationMargin1> TotalVariationMargin { get; init; } = new ValueList<TotalVariationMargin1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-eWgAqMOEeCojJW5vEuTEQ_-166188930
    
    /// <summary>
    /// Net unrealised profit or loss on the value of the netted, gross and failing positions.
    /// </summary>
    [IsoId("_-eWgA6MOEeCojJW5vEuTEQ_-1163261283")]
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
    [IsoId("_-eWgBKMOEeCojJW5vEuTEQ_2134633660")]
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
    [IsoId("_-eWgBaMOEeCojJW5vEuTEQ_1137561307")]
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
    [IsoId("_-eWgBqMOEeCojJW5vEuTEQ_1906471397")]
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
    [IsoId("_-eWgB6MOEeCojJW5vEuTEQ_909399044")]
    [DisplayName("Fails Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlsHrcut")]
    #endif
    [IsoXmlTag("FlsHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2? FailsHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2? FailsHaircut { get; init; } 
    #else
    public Amount2? FailsHaircut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
