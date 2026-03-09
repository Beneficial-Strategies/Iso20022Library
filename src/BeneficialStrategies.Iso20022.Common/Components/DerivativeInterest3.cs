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
/// Specifies a multi-leg interest derivative.
/// </summary>
[IsoId("_HzdA2X5aEea2k7EBUopqxw")]
[DisplayName("Derivative Interest")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeInterest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativeInterest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativeInterest3( FloatingInterestRate8 reqInterestRate )
    {
        InterestRate = reqInterestRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the interest rate in number of days, weeks, months or years.
    /// </summary>
    [IsoId("_H7ydcX5aEea2k7EBUopqxw")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FloatingInterestRate8 InterestRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FloatingInterestRate8 InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FloatingInterestRate8 InterestRate { get; init; } 
    #else
    public FloatingInterestRate8 InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate of the notional currency.
    /// </summary>
    [IsoId("_H7ydc35aEea2k7EBUopqxw")]
    [DisplayName("First Leg Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstLegIntrstRate")]
    #endif
    [IsoXmlTag("FrstLegIntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate8Choice_? FirstLegInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate8Choice_? FirstLegInterestRate { get; init; } 
    #else
    public InterestRate8Choice_? FirstLegInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Notional currency in which leg 2 of the contract is denominated, in case of multi-currency or cross-currency swaps.
    /// Notional currency in which leg 2 of the swap is denominated, in case of swaptions where the underlying swap is multi-currency.
    /// </summary>
    [IsoId("_H7yddX5aEea2k7EBUopqxw")]
    [DisplayName("Other Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrNtnlCcy")]
    #endif
    [IsoXmlTag("OthrNtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? OtherNotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? OtherNotionalCurrency { get; init; } 
    #else
    public string? OtherNotionalCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the interest rate used for leg 2, if applicable.
    /// </summary>
    [IsoId("_H7ydd35aEea2k7EBUopqxw")]
    [DisplayName("Other Leg Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrLegIntrstRate")]
    #endif
    [IsoXmlTag("OthrLegIntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate8Choice_? OtherLegInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate8Choice_? OtherLegInterestRate { get; init; } 
    #else
    public InterestRate8Choice_? OtherLegInterestRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
