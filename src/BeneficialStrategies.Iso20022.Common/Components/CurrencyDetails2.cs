// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a currency.
/// </summary>
[IsoId("_uN0q0YomEeSaAcF2oE2GNQ")]
[DisplayName("Currency Details")]
public partial record CurrencyDetails2
{
    #nullable enable
    
    /// <summary>
    /// Alpha currency code (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_ubGR0YomEeSaAcF2oE2GNQ")]
    [DisplayName("Alpha Code")]
    [IsoXmlTag("AlphaCd")]
    public ActiveCurrencyCode? AlphaCode { get; init; } 
    
    /// <summary>
    /// Numeric currency code (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_ubGR04omEeSaAcF2oE2GNQ")]
    [DisplayName("Numeric Code")]
    [IsoXmlTag("NmrcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? NumericCode { get; init; } 
    
    /// <summary>
    /// Maximal number of digits after the decimal separator for the currency.
    /// </summary>
    [IsoId("_ubGR1YomEeSaAcF2oE2GNQ")]
    [DisplayName("Decimal")]
    [IsoXmlTag("Dcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Decimal { get; init; } 
    
    /// <summary>
    /// Full name of the currency.
    /// </summary>
    [IsoId("_ubGR14omEeSaAcF2oE2GNQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    
    #nullable disable
    
}
