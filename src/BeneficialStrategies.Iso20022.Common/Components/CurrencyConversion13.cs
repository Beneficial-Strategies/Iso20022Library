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
[IsoId("_yiVD8a_aEeaepNKtQMrGAQ")]
[DisplayName("Currency Conversion")]
public partial record CurrencyConversion13
{
    #nullable enable
    
    /// <summary>
    /// True if the cardholder has accepted the currency conversion that the acquirer has proposed.
    /// </summary>
    [IsoId("_yua_Ma_aEeaepNKtQMrGAQ")]
    [DisplayName("Accepted By Cardholder")]
    [IsoXmlTag("AccptdByCrdhldr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcceptedByCardholder { get; init; } 
    
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a cardholder, provided by a dedicated service provider.
    /// </summary>
    [IsoId("_yua_M6_aEeaepNKtQMrGAQ")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public CurrencyConversion12? Conversion { get; init; } 
    
    
    #nullable disable
    
}
