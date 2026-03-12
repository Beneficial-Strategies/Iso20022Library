// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the interest calculation.
/// </summary>
[IsoId("_Xfp5zSqWEeyR9JrVGfaMKw")]
[DisplayName("Interest Calculation")]
public partial record InterestCalculation5
{
    #nullable enable
    
    /// <summary>
    /// Indicates the calculation date of the interest amount.
    /// </summary>
    [IsoId("_X3pjASqWEeyR9JrVGfaMKw")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CalculationDate { get; init; } 
    
    /// <summary>
    /// Provides the identification of the collateral account.
    /// </summary>
    [IsoId("_X3pjAyqWEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_VtgmsyqWEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Provides the collateral amount used to calculate the interest amount and includes debit/short or credit/long positions.
    /// </summary>
    [IsoId("_X3pjBSqWEeyR9JrVGfaMKw")]
    [DisplayName("Effective Principal Amount")]
    [IsoXmlTag("FctvPrncplAmt")]
    public required AmountAndDirection20 EffectivePrincipalAmount { get; init; } 
    
    /// <summary>
    /// Provides the collateral amount posted before taking into account the collateral movement amount.
    /// </summary>
    [IsoId("_X3pjByqWEeyR9JrVGfaMKw")]
    [DisplayName("Principal Amount")]
    [IsoXmlTag("PrncplAmt")]
    public AmountAndDirection20? PrincipalAmount { get; init; } 
    
    /// <summary>
    /// Provides the additional amount of collateral posted between two calculation dates.
    /// </summary>
    [IsoId("_X3pjCSqWEeyR9JrVGfaMKw")]
    [DisplayName("Movement Amount")]
    [IsoXmlTag("MvmntAmt")]
    public AmountAndDirection20? MovementAmount { get; init; } 
    
    /// <summary>
    /// Indicates the number of days for the calculation of the interest.
    /// </summary>
    [IsoId("_X3pjCyqWEeyR9JrVGfaMKw")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDays { get; init; } 
    
    /// <summary>
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_X3pjDSqWEeyR9JrVGfaMKw")]
    [DisplayName("Effective Rate")]
    [IsoXmlTag("FctvRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate EffectiveRate { get; init; } 
    
    /// <summary>
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_X3pjDyqWEeyR9JrVGfaMKw")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; } 
    
    /// <summary>
    /// Indicates the differences in interest rates.
    /// </summary>
    [IsoId("_X3pjESqWEeyR9JrVGfaMKw")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Spread { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money representing an interest payment.
    /// </summary>
    [IsoId("_X3pjEyqWEeyR9JrVGfaMKw")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public required AmountAndDirection20 AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Specifies the total amount of money representing an interest payment.
    /// </summary>
    [IsoId("_X3pjFSqWEeyR9JrVGfaMKw")]
    [DisplayName("Aggregated Interest Amount")]
    [IsoXmlTag("AggtdIntrstAmt")]
    public ActiveCurrencyAndAmount? AggregatedInterestAmount { get; init; } 
    
    
    #nullable disable
    
}
