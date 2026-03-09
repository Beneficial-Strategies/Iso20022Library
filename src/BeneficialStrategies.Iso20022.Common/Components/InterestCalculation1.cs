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
/// Consideration, such as amount of money, paid or received in exchange for an amount of money that has been invested, loaned or borrowed for a certain period.
/// </summary>
[IsoId("_SQ30dNp-Ed-ak6NoX_4Aeg_-2020770164")]
[DisplayName("Interest Calculation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestCalculation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestCalculation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestCalculation1( System.DateOnly reqCalculationDate,ActiveCurrencyAndAmount reqEffectivePrincipalAmount,System.Decimal reqEffectiveRate,ActiveCurrencyAndAmount reqAccruedInterestAmount )
    {
        CalculationDate = reqCalculationDate;
        EffectivePrincipalAmount = reqEffectivePrincipalAmount;
        EffectiveRate = reqEffectiveRate;
        AccruedInterestAmount = reqAccruedInterestAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Calculation date of the interest amount.
    /// </summary>
    [IsoId("_SQ30ddp-Ed-ak6NoX_4Aeg_372379670")]
    [DisplayName("Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnDt")]
    #endif
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate CalculationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly CalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly CalculationDate { get; init; } 
    #else
    public System.DateOnly CalculationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the collateral amount used to calculate the interest amount.
    /// </summary>
    [IsoId("_SQ30dtp-Ed-ak6NoX_4Aeg_970930873")]
    [DisplayName("Effective Principal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvPrncplAmt")]
    #endif
    [IsoXmlTag("FctvPrncplAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount EffectivePrincipalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount EffectivePrincipalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount EffectivePrincipalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount EffectivePrincipalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the collateral amount posted before taking into account the collateral movement amount.
    /// </summary>
    [IsoId("_SQ30d9p-Ed-ak6NoX_4Aeg_166712219")]
    [DisplayName("Principal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmt")]
    #endif
    [IsoXmlTag("PrncplAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PrincipalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PrincipalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PrincipalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the additional amount of collateral posted between two calculation dates.
    /// </summary>
    [IsoId("_SQ30eNp-Ed-ak6NoX_4Aeg_-1006058254")]
    [DisplayName("Movement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntAmt")]
    #endif
    [IsoXmlTag("MvmntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MovementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MovementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MovementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the movement in the collateral posted is a debit or a credit amount.
    /// </summary>
    [IsoId("_SRBlcNp-Ed-ak6NoX_4Aeg_-1157078384")]
    [DisplayName("Movement Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntDrctn")]
    #endif
    [IsoXmlTag("MvmntDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? MovementDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? MovementDirection { get; init; } 
    #else
    public CreditDebitCode? MovementDirection { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_SRBlcdp-Ed-ak6NoX_4Aeg_-1215624024")]
    [DisplayName("Effective Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvRate")]
    #endif
    [IsoXmlTag("FctvRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate EffectiveRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal EffectiveRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal EffectiveRate { get; init; } 
    #else
    public System.Decimal EffectiveRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_SRBlctp-Ed-ak6NoX_4Aeg_1283660646")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestRate { get; init; } 
    #else
    public System.Decimal? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Used to express differences in interest rates.
    /// </summary>
    [IsoId("_SRBlc9p-Ed-ak6NoX_4Aeg_-1944656017")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Spread { get; init; } 
    #else
    public System.Decimal? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SRBldNp-Ed-ak6NoX_4Aeg_189372279")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SRBlddp-Ed-ak6NoX_4Aeg_-1133718841")]
    [DisplayName("Aggregated Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AggtdIntrstAmt")]
    #endif
    [IsoXmlTag("AggtdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AggregatedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AggregatedInterestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AggregatedInterestAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
