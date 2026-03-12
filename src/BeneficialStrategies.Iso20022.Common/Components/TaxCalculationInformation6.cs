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
[IsoId("_SllgONp-Ed-ak6NoX_4Aeg_-2134024285")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation6
{
    #nullable enable
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_SllgOdp-Ed-ak6NoX_4Aeg_-1720287506")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis2Code? Basis { get; init; } 
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_SllgOtp-Ed-ak6NoX_4Aeg_-1720287489")]
    [DisplayName("Extended Basis")]
    [IsoXmlTag("XtndedBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedBasis { get; init; } 
    
    /// <summary>
    /// Amount of money that it is to be taxed.
    /// </summary>
    [IsoId("_SllgO9p-Ed-ak6NoX_4Aeg_-2134024225")]
    [DisplayName("Taxable Amount")]
    [IsoXmlTag("TaxblAmt")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableAmount { get; init; } 
    
    
    #nullable disable
    
}
