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
/// Totals for the value of the holdings reported in the statement or page.
/// </summary>
[IsoId("_L7GM8MRrEeij-rSPpvD-Tw")]
[DisplayName("Total Value In Page And Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalValueInPageAndStatement5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of exposure reported in this message.
    /// </summary>
    [IsoId("_8TX0sMRrEeij-rSPpvD-Tw")]
    [DisplayName("Total Exposure Value Of Page")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlXpsrValOfPg")]
    #endif
    [IsoXmlTag("TtlXpsrValOfPg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalExposureValueOfPage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalExposureValueOfPage { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalExposureValueOfPage { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of collateral held reported in this message.
    /// </summary>
    [IsoId("_Hzfo8MRsEeij-rSPpvD-Tw")]
    [DisplayName("Total Collateral Held Value Of Page")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCollHeldValOfPg")]
    #endif
    [IsoXmlTag("TtlCollHeldValOfPg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralHeldValueOfPage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralHeldValueOfPage { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralHeldValueOfPage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
