// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Consideration, such as amount of money, paid or received in exchange for an amount of money that has been invested, loaned or borrowed for a certain period.
/// </summary>
[IsoId("_SQ30dNp-Ed-ak6NoX_4Aeg_-2020770164")]
[DisplayName("Interest Calculation")]
public partial record InterestCalculation1
{
    #nullable enable
    
    /// <summary>
    /// Calculation date of the interest amount.
    /// </summary>
    [IsoId("_SQ30ddp-Ed-ak6NoX_4Aeg_372379670")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CalculationDate { get; init; } 
    
    /// <summary>
    /// Provides the collateral amount used to calculate the interest amount.
    /// </summary>
    [IsoId("_SQ30dtp-Ed-ak6NoX_4Aeg_970930873")]
    [DisplayName("Effective Principal Amount")]
    [IsoXmlTag("FctvPrncplAmt")]
    public required ActiveCurrencyAndAmount EffectivePrincipalAmount { get; init; } 
    
    /// <summary>
    /// Provides the collateral amount posted before taking into account the collateral movement amount.
    /// </summary>
    [IsoId("_SQ30d9p-Ed-ak6NoX_4Aeg_166712219")]
    [DisplayName("Principal Amount")]
    [IsoXmlTag("PrncplAmt")]
    public ActiveCurrencyAndAmount? PrincipalAmount { get; init; } 
    
    /// <summary>
    /// Provides the additional amount of collateral posted between two calculation dates.
    /// </summary>
    [IsoId("_SQ30eNp-Ed-ak6NoX_4Aeg_-1006058254")]
    [DisplayName("Movement Amount")]
    [IsoXmlTag("MvmntAmt")]
    public ActiveCurrencyAndAmount? MovementAmount { get; init; } 
    
    /// <summary>
    /// Indicates if the movement in the collateral posted is a debit or a credit amount.
    /// </summary>
    [IsoId("_SRBlcNp-Ed-ak6NoX_4Aeg_-1157078384")]
    [DisplayName("Movement Direction")]
    [IsoXmlTag("MvmntDrctn")]
    public CreditDebitCode? MovementDirection { get; init; } 
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_SRBlcdp-Ed-ak6NoX_4Aeg_-1215624024")]
    [DisplayName("Effective Rate")]
    [IsoXmlTag("FctvRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate EffectiveRate { get; init; } 
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_SRBlctp-Ed-ak6NoX_4Aeg_1283660646")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; } 
    
    /// <summary>
    /// Used to express differences in interest rates.
    /// </summary>
    [IsoId("_SRBlc9p-Ed-ak6NoX_4Aeg_-1944656017")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Spread { get; init; } 
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SRBldNp-Ed-ak6NoX_4Aeg_189372279")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SRBlddp-Ed-ak6NoX_4Aeg_-1133718841")]
    [DisplayName("Aggregated Interest Amount")]
    [IsoXmlTag("AggtdIntrstAmt")]
    public ActiveCurrencyAndAmount? AggregatedInterestAmount { get; init; } 
    
    
    #nullable disable
    
}
