// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the currency conversion advice.
/// </summary>
[IsoId("_aWLVoS5IEeunNvJlR_vCbg")]
[DisplayName("Acceptor Currency Conversion Advice")]
public record AcceptorCurrencyConversionAdvice5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_akXioS5IEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and a currency conversion provider.
    /// </summary>
    [IsoId("_akXioy5IEeunNvJlR_vCbg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction111 Transaction { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder and its result.
    /// </summary>
    [IsoId("_akXipS5IEeunNvJlR_vCbg")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion21? CurrencyConversionResult { get; init; }
}
