// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the total amount of taxes.
/// </summary>
[IsoId("_SlbvM9p-Ed-ak6NoX_4Aeg_-655710552")]
[DisplayName("Total Taxes")]
public partial record TotalTaxes3
{
    #nullable enable
    
    /// <summary>
    /// Total value of the taxes for a specific order.
    /// </summary>
    [IsoId("_SlbvNNp-Ed-ak6NoX_4Aeg_-655709854")]
    [DisplayName("Total Amount Of Taxes")]
    [IsoXmlTag("TtlAmtOfTaxs")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; init; } 
    
    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_SlbvNdp-Ed-ak6NoX_4Aeg_-1861992641")]
    [DisplayName("Taxable Income Per Dividend")]
    [IsoXmlTag("TaxblIncmPerDvdd")]
    public ActiveCurrencyAndAmount? TaxableIncomePerDividend { get; init; } 
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvNtp-Ed-ak6NoX_4Aeg_1440938177")]
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvN9p-Ed-ak6NoX_4Aeg_1440938995")]
    [DisplayName("Extended EU Capital Gain")]
    [IsoXmlTag("XtndedEUCptlGn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedEUCapitalGain { get; init; } 
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvONp-Ed-ak6NoX_4Aeg_-1861992088")]
    [DisplayName("EU Dividend Status")]
    [IsoXmlTag("EUDvddSts")]
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlbvOdp-Ed-ak6NoX_4Aeg_-1861991218")]
    [DisplayName("Extended EU Dividend Status")]
    [IsoXmlTag("XtndedEUDvddSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedEUDividendStatus { get; init; } 
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_SllgMNp-Ed-ak6NoX_4Aeg_1230792355")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    
    /// <summary>
    /// Information related to a specific tax.
    /// </summary>
    [IsoId("_SllgMdp-Ed-ak6NoX_4Aeg_-655709586")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax14? TaxDetails { get; init; } 
    
    
    #nullable disable
    
}
