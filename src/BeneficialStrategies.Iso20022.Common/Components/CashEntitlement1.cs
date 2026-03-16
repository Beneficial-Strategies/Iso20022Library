// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about cash entitlements.
/// </summary>
[IsoId("_UJbRgdp-Ed-ak6NoX_4Aeg_1924787885")]
[DisplayName("Cash Entitlement")]
public record CashEntitlement1
{
    /// <summary>
    /// Entitled cash amount.
    /// </summary>
    [IsoId("_UJbRgtp-Ed-ak6NoX_4Aeg_-1928735970")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public required ActiveCurrencyAndAmount CashAmount { get; init; }
}
