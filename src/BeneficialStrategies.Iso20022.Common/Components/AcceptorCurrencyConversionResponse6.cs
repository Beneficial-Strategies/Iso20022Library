// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency conversion outcome from the service provider.
/// </summary>
[IsoId("_fhlAwdelEeiJyp_aycJaTw")]
[DisplayName("Acceptor Currency Conversion Response")]
public record AcceptorCurrencyConversionResponse6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_frubQdelEeiJyp_aycJaTw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment69 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_frubQ9elEeiJyp_aycJaTw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction88 Transaction { get; init; }

    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("_frubRdelEeiJyp_aycJaTw")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public required CurrencyConversion16 CurrencyConversionResult { get; init; }
}
