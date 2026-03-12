// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option or swaption related attributes.
/// </summary>
[IsoId("_bsvOheXmEemlzfnIR22x_w")]
[DisplayName("Option Or Swaption")]
public partial record OptionOrSwaption7
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the Option whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_b2aH4-XmEemlzfnIR22x_w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public OptionType2Code? Type { get; init; } 
    
    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style). This field does not have to be populated for ISIN instruments.
    /// </summary>
    [IsoId("_b2aH6eXmEemlzfnIR22x_w")]
    [DisplayName("Exercise Style")]
    [IsoXmlTag("ExrcStyle")]
    public OptionStyle6Code? ExerciseStyle { get; init; } 
    
    /// <summary>
    /// Specifies the earliest unadjusted date during the exercise period on which an option can be exercised.
    /// </summary>
    [IsoId("_bZtK0gbBEeqrW7Meu5r3kQ")]
    [DisplayName("Exercise Date")]
    [IsoXmlTag("ExrcDt")]
    public ExerciseDate1Choice_? ExerciseDate { get; init; } 
    
    /// <summary>
    /// Specifies the predetermined price at which the owner of the option can buy or sell the underlying instrument.
    /// Usage: For foreign exchange options, specifies the exchange rate at which the option can be exercised as the rate of exchange from converting the unit currency into the quoted currency.
    /// For volatility and variance swaps, specify the volatility strike price.
    /// </summary>
    [IsoId("_b2aH5eXmEemlzfnIR22x_w")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public SecuritiesTransactionPrice17Choice_? StrikePrice { get; init; } 
    
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions with strike prices varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_MKFDIfWjEemquc94423dxw")]
    [DisplayName("Strike Price Schedule")]
    [IsoXmlTag("StrkPricSchdl")]
    public Schedule4? StrikePriceSchedule { get; init; } 
    
    /// <summary>
    /// Indicates the amount and currency of a foreign exchange option that the option holder has the right to buy.
    /// </summary>
    [IsoId("_vBhssgbGEeqrW7Meu5r3kQ")]
    [DisplayName("Call Amount")]
    [IsoXmlTag("CallAmt")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? CallAmount { get; init; } 
    
    /// <summary>
    /// Indicates the amount and currency of a foreign exchange option that the option holder has the right to sell.
    /// </summary>
    [IsoId("_xXQ1AgbGEeqrW7Meu5r3kQ")]
    [DisplayName("Put Amount")]
    [IsoXmlTag("PutAmt")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PutAmount { get; init; } 
    
    /// <summary>
    /// Specifies the monetary amount of the premium paid by the buyer of the option.
    /// </summary>
    [IsoId("_uGgTEQa_EeqrW7Meu5r3kQ")]
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PremiumAmount { get; init; } 
    
    /// <summary>
    /// Specifies the date on which the option premium is paid.
    /// </summary>
    [IsoId("_8HAZYQa_EeqrW7Meu5r3kQ")]
    [DisplayName("Premium Payment Date")]
    [IsoXmlTag("PrmPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PremiumPaymentDate { get; init; } 
    
    /// <summary>
    /// In case of swaptions, maturity date of the underlying swap.
    /// </summary>
    [IsoId("_b2aH6-XmEemlzfnIR22x_w")]
    [DisplayName("Maturity Date Of Underlying")]
    [IsoXmlTag("MtrtyDtOfUndrlyg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDateOfUnderlying { get; init; } 
    
    
    #nullable disable
    
}
