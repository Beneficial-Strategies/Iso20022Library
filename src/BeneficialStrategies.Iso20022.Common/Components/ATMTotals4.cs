// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Totals4.
/// </summary>
[IsoId("_9IdqEZ9QEe-nbM0aSPcoiQ")]
[DisplayName("ATM Totals4")]
public record ATMTotals4
{
    /// <summary>
    /// ATM Balance.
    /// </summary>
    [DisplayName("ATM Balance")]
    [IsoXmlTag("ATMBal")]
    public ImpliedCurrencyAndAmount? ATMBalance { get; init; }

    /// <summary>
    /// ATM Balance Number.
    /// </summary>
    [DisplayName("ATM Balance Number")]
    [IsoXmlTag("ATMBalNb")]
    public IsoNumber? ATMBalanceNumber { get; init; }

    /// <summary>
    /// ATM Current.
    /// </summary>
    [DisplayName("ATM Current")]
    [IsoXmlTag("ATMCur")]
    public ImpliedCurrencyAndAmount? ATMCurrent { get; init; }

    /// <summary>
    /// ATM Current Number.
    /// </summary>
    [DisplayName("ATM Current Number")]
    [IsoXmlTag("ATMCurNb")]
    public IsoNumber? ATMCurrentNumber { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Media Type.
    /// </summary>
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public ATMMediaType4Code? MediaType { get; init; }
}
