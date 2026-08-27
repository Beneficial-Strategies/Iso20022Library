// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money defined in cash notes and or cash coins.
/// </summary>
[IsoId("_UzKpJEFVEfCGo6pGJ7j7Eg")]
[DisplayName("Cash Breakdown1")]
public record CashBreakdown1
{
    /// <summary>
    /// Specifies the note details.
    /// </summary>
    [IsoId("_UzKpJUFVEfCGo6pGJ7j7Eg")]
    [DisplayName("Note Details")]
    [IsoXmlTag("NoteDtls")]
    public ValueList<CashNote1> NoteDetails { get; init; } = [];

    /// <summary>
    /// Specifies the coin details.
    /// </summary>
    [IsoId("_UzKpJkFVEfCGo6pGJ7j7Eg")]
    [DisplayName("Coin Details")]
    [IsoXmlTag("CoinDtls")]
    public ValueList<CashCoin1> CoinDetails { get; init; } = [];

    /// <summary>
    /// Total amount of all notes and coins.
    /// </summary>
    [IsoId("_UzKpJ0FVEfCGo6pGJ7j7Eg")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ActiveCurrencyAndAmount TotalAmount { get; init; }
}
