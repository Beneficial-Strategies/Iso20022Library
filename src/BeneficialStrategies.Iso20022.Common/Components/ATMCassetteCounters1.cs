// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM cassette counter per unit value or globally.
/// </summary>
[IsoId("_sVeosIqgEeS4a4abTJTSSw")]
[DisplayName("ATM Cassette Counters")]
public record ATMCassetteCounters1
{
    /// <summary>
    /// Amount of one media unit, if the media type is valued.
    /// </summary>
    [IsoId("_-kSigIqgEeS4a4abTJTSSw")]
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public ImpliedCurrencyAndAmount? UnitValue { get; init; }

    /// <summary>
    /// Currency of the media, if the media type is valued and different from the currency of the requested amount.
    /// </summary>
    [IsoId("_DeWBsIqhEeS4a4abTJTSSw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Type of notes.
    /// </summary>
    [IsoId("_kdC3YIqhEeS4a4abTJTSSw")]
    [DisplayName("Item Type")]
    [IsoXmlTag("ItmTp")]
    public ATMNoteType2Code? ItemType { get; init; }

    /// <summary>
    /// Counters of media inside the cassette.
    /// </summary>
    [IsoId("_-Ib3gIqhEeS4a4abTJTSSw")]
    [DisplayName("Counter")]
    [IsoXmlTag("Cntr")]
    public ValueList<ATMCassetteCounters2> Counter { get; init; } = [];

    /// <summary>
    /// Current number of media present in the cassette.
    /// </summary>
    [IsoId("_u-9sEIqjEeS4a4abTJTSSw")]
    [DisplayName("Current Number")]
    [IsoXmlTag("CurNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber CurrentNumber { get; init; }

    /// <summary>
    /// Current amount in the cassette.
    /// </summary>
    [IsoId("_zbbQUIqjEeS4a4abTJTSSw")]
    [DisplayName("Current Amount")]
    [IsoXmlTag("CurAmt")]
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; }
}
