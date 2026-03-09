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
[IsoId("_SVywtdp-Ed-ak6NoX_4Aeg_-1500373473")]
[DisplayName("Balance Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceAmounts3
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
    [IsoId("_SVywttp-Ed-ak6NoX_4Aeg_1018333172")]
    [DisplayName("Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgVal")]
    #endif
    [IsoXmlTag("HldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection6? HoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection6? HoldingValue { get; init; } 
    #else
    public AmountAndDirection6? HoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_SVywt9p-Ed-ak6NoX_4Aeg_-1905008584")]
    [DisplayName("Previous Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsHldgVal")]
    #endif
    [IsoXmlTag("PrvsHldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection6? PreviousHoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection6? PreviousHoldingValue { get; init; } 
    #else
    public AmountAndDirection6? PreviousHoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_SVywuNp-Ed-ak6NoX_4Aeg_1019253264")]
    [DisplayName("Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookVal")]
    #endif
    [IsoXmlTag("BookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection6? BookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection6? BookValue { get; init; } 
    #else
    public AmountAndDirection6? BookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the position eligible for collateral purposes.
    /// </summary>
    [IsoId("_SV76oNp-Ed-ak6NoX_4Aeg_1019253419")]
    [DisplayName("Eligible Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblCollVal")]
    #endif
    [IsoXmlTag("ElgblCollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection6? EligibleCollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection6? EligibleCollateralValue { get; init; } 
    #else
    public AmountAndDirection6? EligibleCollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_SV76odp-Ed-ak6NoX_4Aeg_-611160519")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection6? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection6? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection6? AccruedInterestAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
