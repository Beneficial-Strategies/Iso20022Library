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
/// Investor’s ability to bear losses.
/// </summary>
[IsoId("_jWdr8bSaEeq-6ssAXwSh-g")]
[DisplayName("Loss Bearing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LossBearing2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the product is compatible with a client who cannot bear loss of capital. Minor losses especially due to costs are possible. For a negative target (no), the product should not be sold to investors that cannot bear losses. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03010.
    /// </summary>
    [IsoId("_joeB8bSaEeq-6ssAXwSh-g")]
    [DisplayName("No Capital Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoCptlLoss")]
    #endif
    [IsoXmlTag("NoCptlLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? NoCapitalLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? NoCapitalLoss { get; init; } 
    #else
    public TargetMarket1Code? NoCapitalLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product is compatible with a client who is seeking to preserve capital or who can bear losses limited to a level specified by a structured security or structure fund product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03020. 
    /// </summary>
    [IsoId("_joeB87SaEeq-6ssAXwSh-g")]
    [DisplayName("Limited Capital Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtdCptlLoss")]
    #endif
    [IsoXmlTag("LtdCptlLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? LimitedCapitalLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? LimitedCapitalLoss { get; init; } 
    #else
    public TargetMarket1Code? LimitedCapitalLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the percentage of loss that can be carried by the investor. This is only specified when a clear partial capital guarantee is provided on the primary market. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03030.
    /// </summary>
    [IsoId("_joeB9bSaEeq-6ssAXwSh-g")]
    [DisplayName("Limited Capital Loss Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtdCptlLossLvl")]
    #endif
    [IsoXmlTag("LtdCptlLossLvl")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? LimitedCapitalLossLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LimitedCapitalLossLevel { get; init; } 
    #else
    public System.Decimal? LimitedCapitalLossLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product is compatible with a client who does not need capital guarantee nor protection. One hundred percent of the capital is at risk. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03040. 
    /// </summary>
    [IsoId("_joeB97SaEeq-6ssAXwSh-g")]
    [DisplayName("No Capital Guarantee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoCptlGrnt")]
    #endif
    [IsoXmlTag("NoCptlGrnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? NoCapitalGuarantee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? NoCapitalGuarantee { get; init; } 
    #else
    public TargetMarket1Code? NoCapitalGuarantee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product is compatible with a client who can bear loss beyond the capital. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03050. 
    /// </summary>
    [IsoId("_joeB-bSaEeq-6ssAXwSh-g")]
    [DisplayName("Loss Beyond Capital")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LossByndCptl")]
    #endif
    [IsoXmlTag("LossByndCptl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? LossBeyondCapital { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? LossBeyondCapital { get; init; } 
    #else
    public TargetMarket1Code? LossBeyondCapital { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies another type of loss bearing.
    /// </summary>
    [IsoId("_joeB-7SaEeq-6ssAXwSh-g")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTargetMarketLossBearing1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTargetMarketLossBearing1? Other { get; init; } 
    #else
    public OtherTargetMarketLossBearing1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
