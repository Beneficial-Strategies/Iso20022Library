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
/// Amounts linked to a securities balance, for example, holding value.
/// </summary>
[IsoId("_WQIfU9p-Ed-ak6NoX_4Aeg_1080208287")]
[DisplayName("Balance Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceAmounts4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQIfVNp-Ed-ak6NoX_4Aeg_1401606317")]
    [DisplayName("Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgVal")]
    #endif
    [IsoXmlTag("HldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? HoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? HoldingValue { get; init; } 
    #else
    public AmountAndDirection14? HoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQIfVdp-Ed-ak6NoX_4Aeg_-1475771676")]
    [DisplayName("Previous Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsHldgVal")]
    #endif
    [IsoXmlTag("PrvsHldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? PreviousHoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? PreviousHoldingValue { get; init; } 
    #else
    public AmountAndDirection14? PreviousHoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_WQIfVtp-Ed-ak6NoX_4Aeg_711211848")]
    [DisplayName("Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookVal")]
    #endif
    [IsoXmlTag("BookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? BookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? BookValue { get; init; } 
    #else
    public AmountAndDirection14? BookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the position eligible for collateral purposes.
    /// </summary>
    [IsoId("_WQIfV9p-Ed-ak6NoX_4Aeg_2128801151")]
    [DisplayName("Eligible Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblCollVal")]
    #endif
    [IsoXmlTag("ElgblCollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? EligibleCollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? EligibleCollateralValue { get; init; } 
    #else
    public AmountAndDirection14? EligibleCollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_WQIfWNp-Ed-ak6NoX_4Aeg_20817379")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection14? AccruedInterestAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
