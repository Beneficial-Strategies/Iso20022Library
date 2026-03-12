// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider.
/// </summary>
[IsoId("_UKmxAY0mEeWzoK7sd7oTyw")]
[DisplayName("Currency Conversion")]
public partial record CurrencyConversion7
{
    #nullable enable
    
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_UW0oEY0mEeWzoK7sd7oTyw")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse1Code Result { get; init; } 
    
    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_UW0oE40mEeWzoK7sd7oTyw")]
    [DisplayName("Result Reason")]
    [IsoXmlTag("RsltRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ResultReason { get; init; } 
    
    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    [IsoId("_UW0oFY0mEeWzoK7sd7oTyw")]
    [DisplayName("Conversion Details")]
    [IsoXmlTag("ConvsDtls")]
    public CurrencyConversion6? ConversionDetails { get; init; } 
    
    
    #nullable disable
    
}
