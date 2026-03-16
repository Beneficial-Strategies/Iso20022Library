// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original amount and currency exchange.
/// </summary>
[IsoId("_SV76qNp-Ed-ak6NoX_4Aeg_1857747132")]
[DisplayName("Amount And Currency Exchange Details")]
public record AmountAndCurrencyExchangeDetails3
{
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_SV76qdp-Ed-ak6NoX_4Aeg_1857747134")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the currency exchange.
    /// </summary>
    [IsoId("_SV76qtp-Ed-ak6NoX_4Aeg_1857747164")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange5? CurrencyExchange { get; init; }
}
