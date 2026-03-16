// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a multi-leg interest derivative.
/// </summary>
[IsoId("_pMapccnYEeWpf-ImB_F2gQ")]
[DisplayName("Derivative Interest")]
public record DerivativeInterest2
{
    /// <summary>
    /// Currency in which leg 2 of the contract is denominated, in case of multi-currency or cross-currency swaps.
    /// Currency in which leg 2 of the swap is denominated, in case of swaptions where the underlying swap is multi-currency.
    /// </summary>
    [IsoId("_pqvkNcnYEeWpf-ImB_F2gQ")]
    [DisplayName("Other Notional Currency")]
    [IsoXmlTag("OthrNtnlCcy")]
    public required ActiveOrHistoricCurrencyCode OtherNotionalCurrency { get; init; }
}
