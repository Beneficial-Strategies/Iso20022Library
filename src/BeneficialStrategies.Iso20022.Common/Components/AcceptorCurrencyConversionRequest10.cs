// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the currency conversion request.
/// </summary>
[IsoId("_FZkiQXJ5Ee299ZbWCkdR_w")]
[DisplayName("Acceptor Currency Conversion Request")]
public record AcceptorCurrencyConversionRequest10
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Ff7B4XJ5Ee299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    [IsoId("_Ff7B43J5Ee299ZbWCkdR_w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardPaymentTransaction127? Transaction { get; init; }
}
