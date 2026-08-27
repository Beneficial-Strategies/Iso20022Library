// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal or deposit of an amount of money defined in cash notes.
/// </summary>
[IsoId("_zy9x4OR-Ee-NFYIkYc90gw")]
[DisplayName("Cash Note1")]
public record CashNote1
{
    /// <summary>
    /// Type of cash.
    /// </summary>
    [IsoId("_7my5sVDeEfCRhs5qxCujTw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashType1Choice_? Type { get; init; }

    /// <summary>
    /// Reference for the box holding these notes.
    /// </summary>
    [IsoId("_NYtbUKtkEfC6tbn8zOl_iw")]
    [DisplayName("Box Reference")]
    [IsoXmlTag("BxRef")]
    public IsoMax35Text? BoxReference { get; init; }

    /// <summary>
    /// Specifies the note denomination, including the currency, such as a 50 euro note.
    /// </summary>
    [IsoId("_yn8JM-R-Ee-NFYIkYc90gw")]
    [DisplayName("Note Denomination")]
    [IsoXmlTag("NoteDnmtn")]
    public ActiveCurrencyAndAmount? NoteDenomination { get; init; }

    /// <summary>
    /// Specifies the number of notes of the same denomination.
    /// </summary>
    [IsoId("_yn8JNOR-Ee-NFYIkYc90gw")]
    [DisplayName("Number Of Notes")]
    [IsoXmlTag("NbOfNotes")]
    public IsoMax15NumericText? NumberOfNotes { get; init; }

    /// <summary>
    /// Specifies the total amount of money for this note denomination, that is the note denomination times the number of notes.
    /// </summary>
    [IsoId("_yn8JNeR-Ee-NFYIkYc90gw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
