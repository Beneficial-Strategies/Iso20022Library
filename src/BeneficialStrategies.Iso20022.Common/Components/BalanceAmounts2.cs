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
[IsoId("_SVywsdp-Ed-ak6NoX_4Aeg_-1968542123")]
[DisplayName("Balance Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceAmounts2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceAmounts2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceAmounts2( AmountAndDirection6 reqHoldingValue )
    {
        HoldingValue = reqHoldingValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_SVywstp-Ed-ak6NoX_4Aeg_935214468")]
    [DisplayName("Holding Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgVal")]
    #endif
    [IsoXmlTag("HldgVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection6 HoldingValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection6 HoldingValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection6 HoldingValue { get; init; } 
    #else
    public AmountAndDirection6 HoldingValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_SVyws9p-Ed-ak6NoX_4Aeg_935214776")]
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
    /// Difference between holding value and the book value.
    /// </summary>
    [IsoId("_SVywtNp-Ed-ak6NoX_4Aeg_935214846")]
    [DisplayName("Unrealised Gain Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UrlsdGnLoss")]
    #endif
    [IsoXmlTag("UrlsdGnLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection6? UnrealisedGainLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection6? UnrealisedGainLoss { get; init; } 
    #else
    public AmountAndDirection6? UnrealisedGainLoss { get; set; } 
    #endif
    
    
    #nullable disable
    
}
