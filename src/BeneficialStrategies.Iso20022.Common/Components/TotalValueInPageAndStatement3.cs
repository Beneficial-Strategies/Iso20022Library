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
[IsoId("_XN02o9p-Ed-ak6NoX_4Aeg_1095060082")]
[DisplayName("Total Value In Page And Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalValueInPageAndStatement3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalValueInPageAndStatement3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalValueInPageAndStatement3( AmountAndDirection14 reqTotalHoldingsValueOfStatement )
    {
        TotalHoldingsValueOfStatement = reqTotalHoldingsValueOfStatement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of positions reported in this message.
    /// </summary>
    [IsoId("_XN02pNp-Ed-ak6NoX_4Aeg_854357249")]
    [DisplayName("Total Holdings Value Of Page")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlHldgsValOfPg")]
    #endif
    [IsoXmlTag("TtlHldgsValOfPg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? TotalHoldingsValueOfPage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? TotalHoldingsValueOfPage { get; init; } 
    #else
    public AmountAndDirection14? TotalHoldingsValueOfPage { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XN02pdp-Ed-ak6NoX_4Aeg_-2023020744")]
    [DisplayName("Total Holdings Value Of Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlHldgsValOfStmt")]
    #endif
    [IsoXmlTag("TtlHldgsValOfStmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection14 TotalHoldingsValueOfStatement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection14 TotalHoldingsValueOfStatement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14 TotalHoldingsValueOfStatement { get; init; } 
    #else
    public AmountAndDirection14 TotalHoldingsValueOfStatement { get; set; } 
    #endif
    
    /// <summary>
    /// Total book value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XN02ptp-Ed-ak6NoX_4Aeg_163962780")]
    [DisplayName("Total Book Value Of Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlBookValOfStmt")]
    #endif
    [IsoXmlTag("TtlBookValOfStmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? TotalBookValueOfStatement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? TotalBookValueOfStatement { get; init; } 
    #else
    public AmountAndDirection14? TotalBookValueOfStatement { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of the holdings eligible for collateral purposes reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XN02p9p-Ed-ak6NoX_4Aeg_1581552083")]
    [DisplayName("Total Eligible Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlElgblCollVal")]
    #endif
    [IsoXmlTag("TtlElgblCollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? TotalEligibleCollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? TotalEligibleCollateralValue { get; init; } 
    #else
    public AmountAndDirection14? TotalEligibleCollateralValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
