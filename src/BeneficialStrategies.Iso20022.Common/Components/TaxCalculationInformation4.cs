// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to calculate the tax.
/// </summary>
[IsoId("_SlvRNtp-Ed-ak6NoX_4Aeg_-1975400876")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation4
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlvRN9p-Ed-ak6NoX_4Aeg_-1975400840")]
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlvRONp-Ed-ak6NoX_4Aeg_-1153836760")]
    [DisplayName("Extended EU Capital Gain")]
    [IsoXmlTag("XtndedEUCptlGn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedEUCapitalGain { get; init; } 
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_SlvROdp-Ed-ak6NoX_4Aeg_-1975400668")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    
    /// <summary>
    /// Percentage of grandfathered debt claim.
    /// </summary>
    [IsoId("_SlvROtp-Ed-ak6NoX_4Aeg_-1975400608")]
    [DisplayName("Percentage Grandfathered Debt")]
    [IsoXmlTag("PctgGrdfthdDebt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageGrandfatheredDebt { get; init; } 
    
    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_Sl4bINp-Ed-ak6NoX_4Aeg_-962659901")]
    [DisplayName("Taxable Income Per Dividend")]
    [IsoXmlTag("TaxblIncmPerDvdd")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; init; } 
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Sl4bIdp-Ed-ak6NoX_4Aeg_-962659764")]
    [DisplayName("EU Dividend Status")]
    [IsoXmlTag("EUDvddSts")]
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Sl4bItp-Ed-ak6NoX_4Aeg_-962659408")]
    [DisplayName("Extended EU Dividend Status")]
    [IsoXmlTag("XtndedEUDvddSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedEUDividendStatus { get; init; } 
    
    
    #nullable disable
    
}
