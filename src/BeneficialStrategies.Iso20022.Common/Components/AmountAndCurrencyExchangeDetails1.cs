// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information on the original amount and currency information.
/// </summary>
[IsoId("_SVf1wdp-Ed-ak6NoX_4Aeg_373768908")]
[DisplayName("Amount And Currency Exchange Details")]
public record AmountAndCurrencyExchangeDetails1
{
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_SVf1wtp-Ed-ak6NoX_4Aeg_417176703")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_SVf1w9p-Ed-ak6NoX_4Aeg_-1574466467")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange3? CurrencyExchange { get; init; }
}
