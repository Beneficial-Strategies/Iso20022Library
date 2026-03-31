// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Currency Conversion Response12.
/// </summary>
[IsoId("_0Vf3gaEwEe-MRKYsaX6JDg")]
[DisplayName("Acceptor Currency Conversion Response12")]
public record AcceptorCurrencyConversionResponse12
{
    /// <summary>
    /// Currency Conversion Result.
    /// </summary>
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public required CurrencyConversion31 CurrencyConversionResult { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment81 Environment { get; init; }

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction137 Transaction { get; init; }
}
