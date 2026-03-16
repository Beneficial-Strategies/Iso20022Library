// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Leg Statement4.
/// </summary>
[IsoId("_Vbog8YcREe-U27oWwgmhCQ")]
[DisplayName("Trade Leg Statement4")]
public record TradeLegStatement4
{
    /// <summary>
    /// Clearing Account.
    /// </summary>
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public SecuritiesAccount18? ClearingAccount { get; init; }

    /// <summary>
    /// Clearing Segment.
    /// </summary>
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification253Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Non Clearing Member.
    /// </summary>
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount227? NonClearingMember { get; init; }

    /// <summary>
    /// Trade Legs Details.
    /// </summary>
    [DisplayName("Trade Legs Details")]
    [IsoXmlTag("TradLegsDtls")]
    public ValueList<TradeLeg12> TradeLegsDetails { get; init; } = [];
}
