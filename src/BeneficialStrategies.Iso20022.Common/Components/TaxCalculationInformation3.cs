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
[IsoId("_VSSXCdp-Ed-ak6NoX_4Aeg_-2096389555")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation3
{
    #nullable enable
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_VScIANp-Ed-ak6NoX_4Aeg_-1881205935")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis1? Basis { get; init; } 
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_VScIAdp-Ed-ak6NoX_4Aeg_-2108006270")]
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGain1? EUCapitalGain { get; init; } 
    
    /// <summary>
    /// Amount of money that it is to be taxed.
    /// </summary>
    [IsoId("_VScIAtp-Ed-ak6NoX_4Aeg_-52512412")]
    [DisplayName("Taxable Amount")]
    [IsoXmlTag("TaxblAmt")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableAmount { get; init; } 
    
    
    #nullable disable
    
}
