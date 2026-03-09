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
/// Numeric variables calculated on market exposures.
/// </summary>
[IsoId("_e45Eca5QEeuo-IflVgGqiA")]
[DisplayName("Exposure Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExposureMetrics5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_fHfhIa5QEeuo-IflVgGqiA")]
    [DisplayName("Cash Collateral Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCollAmt")]
    #endif
    [IsoXmlTag("CshCollAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? CashCollateralAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? CashCollateralAmount { get; init; } 
    #else
    public AmountAndDirection53? CashCollateralAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_fHfhI65QEeuo-IflVgGqiA")]
    [DisplayName("Collateral Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMktVal")]
    #endif
    [IsoXmlTag("CollMktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? CollateralMarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? CollateralMarketValue { get; init; } 
    #else
    public AmountAndDirection53? CollateralMarketValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
