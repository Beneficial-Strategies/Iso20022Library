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
/// Option or swaption related attributes.
/// </summary>
[IsoId("_bsvOheXmEemlzfnIR22x_w")]
[DisplayName("Option Or Swaption")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionOrSwaption7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the Option whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_b2aH4-XmEemlzfnIR22x_w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType2Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType2Code? Type { get; init; } 
    #else
    public OptionType2Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style). This field does not have to be populated for ISIN instruments.
    /// </summary>
    [IsoId("_b2aH6eXmEemlzfnIR22x_w")]
    [DisplayName("Exercise Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcStyle")]
    #endif
    [IsoXmlTag("ExrcStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle6Code? ExerciseStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle6Code? ExerciseStyle { get; init; } 
    #else
    public OptionStyle6Code? ExerciseStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the earliest unadjusted date during the exercise period on which an option can be exercised.
    /// </summary>
    [IsoId("_bZtK0gbBEeqrW7Meu5r3kQ")]
    [DisplayName("Exercise Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcDt")]
    #endif
    [IsoXmlTag("ExrcDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExerciseDate1Choice_? ExerciseDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExerciseDate1Choice_? ExerciseDate { get; init; } 
    #else
    public ExerciseDate1Choice_? ExerciseDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the predetermined price at which the owner of the option can buy or sell the underlying instrument.
    /// Usage: For foreign exchange options, specifies the exchange rate at which the option can be exercised as the rate of exchange from converting the unit currency into the quoted currency.
    /// For volatility and variance swaps, specify the volatility strike price.
    /// </summary>
    [IsoId("_b2aH5eXmEemlzfnIR22x_w")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice17Choice_? StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice17Choice_? StrikePrice { get; init; } 
    #else
    public SecuritiesTransactionPrice17Choice_? StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions with strike prices varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_MKFDIfWjEemquc94423dxw")]
    [DisplayName("Strike Price Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPricSchdl")]
    #endif
    [IsoXmlTag("StrkPricSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Schedule4? StrikePriceSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Schedule4? StrikePriceSchedule { get; init; } 
    #else
    public Schedule4? StrikePriceSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the amount and currency of a foreign exchange option that the option holder has the right to buy.
    /// </summary>
    [IsoId("_vBhssgbGEeqrW7Meu5r3kQ")]
    [DisplayName("Call Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallAmt")]
    #endif
    [IsoXmlTag("CallAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? CallAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? CallAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? CallAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the amount and currency of a foreign exchange option that the option holder has the right to sell.
    /// </summary>
    [IsoId("_xXQ1AgbGEeqrW7Meu5r3kQ")]
    [DisplayName("Put Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutAmt")]
    #endif
    [IsoXmlTag("PutAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PutAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PutAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PutAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the monetary amount of the premium paid by the buyer of the option.
    /// </summary>
    [IsoId("_uGgTEQa_EeqrW7Meu5r3kQ")]
    [DisplayName("Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmAmt")]
    #endif
    [IsoXmlTag("PrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PremiumAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date on which the option premium is paid.
    /// </summary>
    [IsoId("_8HAZYQa_EeqrW7Meu5r3kQ")]
    [DisplayName("Premium Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmPmtDt")]
    #endif
    [IsoXmlTag("PrmPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PremiumPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PremiumPaymentDate { get; init; } 
    #else
    public System.DateOnly? PremiumPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// In case of swaptions, maturity date of the underlying swap.
    /// </summary>
    [IsoId("_b2aH6-XmEemlzfnIR22x_w")]
    [DisplayName("Maturity Date Of Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDtOfUndrlyg")]
    #endif
    [IsoXmlTag("MtrtyDtOfUndrlyg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDateOfUnderlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDateOfUnderlying { get; init; } 
    #else
    public System.DateOnly? MaturityDateOfUnderlying { get; set; } 
    #endif
    
    
    #nullable disable
    
}
