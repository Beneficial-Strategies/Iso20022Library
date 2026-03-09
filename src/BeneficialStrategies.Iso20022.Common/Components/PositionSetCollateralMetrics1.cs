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
/// Variables used to quantify the different calculations for collateral position sets and currency collateral position sets reports.
/// </summary>
[IsoId("_imt2X8WJEeiRga8tPu1L4Q")]
[DisplayName("Position Set Collateral Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetCollateralMetrics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total values by the reporting counterparty to the other counterparty. 
    /// Usage: Where the value is on a portfolio basis, this field should include the overall value  posted for the portfolio.
    /// </summary>
    [IsoId("_2AU54sWKEeiRga8tPu1L4Q")]
    [DisplayName("Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ttl")]
    #endif
    [IsoXmlTag("Ttl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetCollateralTotal1? Total { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetCollateralTotal1? Total { get; init; } 
    #else
    public PositionSetCollateralTotal1? Total { get; set; } 
    #endif
    
    /// <summary>
    /// Clean values by the reporting counterparty to the other counterparty with outliers removed. 
    /// Usage: Where the value is on a portfolio basis, this field should include the overall value posted for the portfolio.
    /// </summary>
    [IsoId("_2AU548WKEeiRga8tPu1L4Q")]
    [DisplayName("Clean")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clean")]
    #endif
    [IsoXmlTag("Clean")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetCollateralTotal1? Clean { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetCollateralTotal1? Clean { get; init; } 
    #else
    public PositionSetCollateralTotal1? Clean { get; set; } 
    #endif
    
    
    #nullable disable
    
}
