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
[IsoId("_Jem3MQujEeqw5uEXxQ9H4g")]
[DisplayName("Currency Conversion")]
public partial record CurrencyConversion18
{
    #nullable enable
    
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_JpGP8QujEeqw5uEXxQ9H4g")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse3Code Result { get; init; } 
    
    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_JpGP8wujEeqw5uEXxQ9H4g")]
    [DisplayName("Result Reason")]
    [IsoXmlTag("RsltRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ResultReason { get; init; } 
    
    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    [IsoId("_JpGP9QujEeqw5uEXxQ9H4g")]
    [DisplayName("Conversion Details")]
    [IsoXmlTag("ConvsDtls")]
    public CurrencyConversion19? ConversionDetails { get; init; } 
    
    
    #nullable disable
    
}
