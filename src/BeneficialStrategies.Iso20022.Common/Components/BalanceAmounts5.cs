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
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_WQRpQtp-Ed-ak6NoX_4Aeg_1054605263")]
[DisplayName("Balance Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceAmounts5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceAmounts5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceAmounts5( AmountAndDirection14 reqHoldingValue )
    {
        HoldingValue = reqHoldingValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQRpQ9p-Ed-ak6NoX_4Aeg_1004561672")]
    [DisplayName("Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgVal")]
    #endif
    [IsoXmlTag("HldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection14 HoldingValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection14 HoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14 HoldingValue { get; init; } 
    #else
    public AmountAndDirection14 HoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQRpRNp-Ed-ak6NoX_4Aeg_-1103422100")]
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
    [IsoId("_WQRpRdp-Ed-ak6NoX_4Aeg_-425897652")]
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
    /// Difference between holding value and the book value.
    /// </summary>
    [IsoId("_WQRpRtp-Ed-ak6NoX_4Aeg_1761085872")]
    [DisplayName("Unrealised Gain Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UrlsdGnLoss")]
    #endif
    [IsoXmlTag("UrlsdGnLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection14? UnrealisedGainLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection14? UnrealisedGainLoss { get; init; } 
    #else
    public AmountAndDirection14? UnrealisedGainLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_WQRpR9p-Ed-ak6NoX_4Aeg_-1116292121")]
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
