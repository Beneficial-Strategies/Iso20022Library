// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency conversion outcome from the service provider.
/// </summary>
[IsoId("_N12L0WpGEeSesPRRJV9fGQ")]
[DisplayName("Acceptor Currency Conversion Response")]
public partial record AcceptorCurrencyConversionResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_OCzpwWpGEeSesPRRJV9fGQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment33 Environment { get; init; } 
    
    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_OCzpw2pGEeSesPRRJV9fGQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction38 Transaction { get; init; } 
    
    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("_OCzpx2pGEeSesPRRJV9fGQ")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public required CurrencyConversion3 CurrencyConversion { get; init; } 
    
    
    #nullable disable
    
}
