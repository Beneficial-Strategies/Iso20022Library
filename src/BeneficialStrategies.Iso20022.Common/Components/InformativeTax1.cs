// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_fH5lkDh7EeaH-93K5JKmzw")]
[DisplayName("Informative Tax")]
public partial record InformativeTax1
{
    #nullable enable
    
    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_mzHk0Th7EeaH-93K5JKmzw")]
    [DisplayName("Taxable Income Per Dividend")]
    [IsoXmlTag("TaxblIncmPerDvdd")]
    public ActiveCurrencyAndAmount? TaxableIncomePerDividend { get; init; } 
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_s8YCEjh7EeaH-93K5JKmzw")]
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGain3Choice_? EUCapitalGain { get; init; } 
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_F6qEkjh8EeaH-93K5JKmzw")]
    [DisplayName("EU Dividend Status")]
    [IsoXmlTag("EUDvddSts")]
    public EUDividendStatusType2Choice_? EUDividendStatus { get; init; } 
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_j7WRATh8EeaH-93K5JKmzw")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    
    /// <summary>
    /// Information related to a specific tax that is provided for information purposes.
    /// </summary>
    [IsoId("_n8kqwTh8EeaH-93K5JKmzw")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public Tax32? IndividualTax { get; init; } 
    
    
    #nullable disable
    
}
