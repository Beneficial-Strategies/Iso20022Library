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
[IsoId("_iNo2MYPLEeWLIolfk4fFwQ")]
[DisplayName("Interest Calculation")]
public partial record InterestCalculation4
{
    #nullable enable
    
    /// <summary>
    /// Indicates the calculation date of the interest amount.
    /// </summary>
    [IsoId("_ioRjwYPLEeWLIolfk4fFwQ")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CalculationDate { get; init; } 
    
    /// <summary>
    /// Provides the identification of the collateral account.
    /// </summary>
    [IsoId("_ioRjw4PLEeWLIolfk4fFwQ")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount2? CollateralAccountIdentification { get; init; } 
    
    /// <summary>
    /// Provides the collateral amount used to calculate the interest amount and includes debit/short or credit/long positions.
    /// </summary>
    [IsoId("_ioRjxYPLEeWLIolfk4fFwQ")]
    [DisplayName("Effective Principal Amount")]
    [IsoXmlTag("FctvPrncplAmt")]
    public required AmountAndDirection20 EffectivePrincipalAmount { get; init; } 
    
    /// <summary>
    /// Provides the collateral amount posted before taking into account the collateral movement amount.
    /// </summary>
    [IsoId("_ioRjx4PLEeWLIolfk4fFwQ")]
    [DisplayName("Principal Amount")]
    [IsoXmlTag("PrncplAmt")]
    public AmountAndDirection20? PrincipalAmount { get; init; } 
    
    /// <summary>
    /// Provides the additional amount of collateral posted between two calculation dates.
    /// </summary>
    [IsoId("_ioatsYPLEeWLIolfk4fFwQ")]
    [DisplayName("Movement Amount")]
    [IsoXmlTag("MvmntAmt")]
    public AmountAndDirection20? MovementAmount { get; init; } 
    
    /// <summary>
    /// Indicates the number of days for the calculation of the interest.
    /// </summary>
    [IsoId("_ioats4PLEeWLIolfk4fFwQ")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDays { get; init; } 
    
    /// <summary>
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_ioattYPLEeWLIolfk4fFwQ")]
    [DisplayName("Effective Rate")]
    [IsoXmlTag("FctvRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate EffectiveRate { get; init; } 
    
    /// <summary>
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_ioatt4PLEeWLIolfk4fFwQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; } 
    
    /// <summary>
    /// Indicates the differences in interest rates.
    /// </summary>
    [IsoId("_ioatuYPLEeWLIolfk4fFwQ")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Spread { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money representing an interest payment.
    /// </summary>
    [IsoId("_ioatu4PLEeWLIolfk4fFwQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public required AmountAndDirection20 AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Specifies the total amount of money representing an interest payment.
    /// </summary>
    [IsoId("_ioatvYPLEeWLIolfk4fFwQ")]
    [DisplayName("Aggregated Interest Amount")]
    [IsoXmlTag("AggtdIntrstAmt")]
    public ActiveCurrencyAndAmount? AggregatedInterestAmount { get; init; } 
    
    
    #nullable disable
    
}
