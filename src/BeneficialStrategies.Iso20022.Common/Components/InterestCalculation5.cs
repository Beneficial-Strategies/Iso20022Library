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
/// Provides the details of the interest calculation.
/// </summary>
[IsoId("_Xfp5zSqWEeyR9JrVGfaMKw")]
[DisplayName("Interest Calculation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestCalculation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestCalculation5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestCalculation5( System.DateOnly reqCalculationDate,AmountAndDirection20 reqEffectivePrincipalAmount,System.Decimal reqEffectiveRate,AmountAndDirection20 reqAccruedInterestAmount )
    {
        CalculationDate = reqCalculationDate;
        EffectivePrincipalAmount = reqEffectivePrincipalAmount;
        EffectiveRate = reqEffectiveRate;
        AccruedInterestAmount = reqAccruedInterestAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the calculation date of the interest amount.
    /// </summary>
    [IsoId("_X3pjASqWEeyR9JrVGfaMKw")]
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
    /// Provides the identification of the collateral account.
    /// </summary>
    [IsoId("_X3pjAyqWEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAcctId")]
    #endif
    [IsoXmlTag("CollAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    #else
    public CollateralAccount3? CollateralAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_VtgmsyqWEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the collateral amount used to calculate the interest amount and includes debit/short or credit/long positions.
    /// </summary>
    [IsoId("_X3pjBSqWEeyR9JrVGfaMKw")]
    [DisplayName("Effective Principal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvPrncplAmt")]
    #endif
    [IsoXmlTag("FctvPrncplAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection20 EffectivePrincipalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection20 EffectivePrincipalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20 EffectivePrincipalAmount { get; init; } 
    #else
    public AmountAndDirection20 EffectivePrincipalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the collateral amount posted before taking into account the collateral movement amount.
    /// </summary>
    [IsoId("_X3pjByqWEeyR9JrVGfaMKw")]
    [DisplayName("Principal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmt")]
    #endif
    [IsoXmlTag("PrncplAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection20? PrincipalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20? PrincipalAmount { get; init; } 
    #else
    public AmountAndDirection20? PrincipalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the additional amount of collateral posted between two calculation dates.
    /// </summary>
    [IsoId("_X3pjCSqWEeyR9JrVGfaMKw")]
    [DisplayName("Movement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntAmt")]
    #endif
    [IsoXmlTag("MvmntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection20? MovementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20? MovementAmount { get; init; } 
    #else
    public AmountAndDirection20? MovementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the number of days for the calculation of the interest.
    /// </summary>
    [IsoId("_X3pjCyqWEeyR9JrVGfaMKw")]
    [DisplayName("Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDays")]
    #endif
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDays { get; init; } 
    #else
    public System.UInt64? NumberOfDays { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_X3pjDSqWEeyR9JrVGfaMKw")]
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
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_X3pjDyqWEeyR9JrVGfaMKw")]
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
    /// Indicates the differences in interest rates.
    /// </summary>
    [IsoId("_X3pjESqWEeyR9JrVGfaMKw")]
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
    /// Specifies the amount of money representing an interest payment.
    /// </summary>
    [IsoId("_X3pjEyqWEeyR9JrVGfaMKw")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection20 AccruedInterestAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection20 AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20 AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection20 AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total amount of money representing an interest payment.
    /// </summary>
    [IsoId("_X3pjFSqWEeyR9JrVGfaMKw")]
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
