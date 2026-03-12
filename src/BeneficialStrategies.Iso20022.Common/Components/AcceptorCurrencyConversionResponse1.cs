// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currencey conversion outcome from the service provider.
/// </summary>
[IsoId("_-NOcMDVqEeOT2JATPlD1fA")]
[DisplayName("Acceptor Currency Conversion Response")]
public partial record AcceptorCurrencyConversionResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_I3EIsDVrEeOT2JATPlD1fA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment21 Environment { get; init; } 
    
    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_YENBQDVrEeOT2JATPlD1fA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction23 Transaction { get; init; } 
    
    /// <summary>
    /// Result of the currency conversion.
    /// </summary>
    [IsoId("_Htdm4DVsEeOT2JATPlD1fA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required Response1Code TransactionResponse { get; init; } 
    
    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("_T0kioDVsEeOT2JATPlD1fA")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public required CurrencyConversion1 CurrencyConversion { get; init; } 
    
    
    #nullable disable
    
}
