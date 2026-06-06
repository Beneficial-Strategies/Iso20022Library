// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the trade leg statement details.
/// </summary>
[IsoId("_2ptroao2EfCG2_q2WT-90w")]
[DisplayName("Trade Leg Statement5")]
public record TradeLegStatement5
{
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_2q6lhao2EfCG2_q2WT-90w")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public SecuritiesAccount18? ClearingAccount { get; init; }

    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// </summary>
    [IsoId("_2q6li6o2EfCG2_q2WT-90w")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification253Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    [IsoId("_2q6lkao2EfCG2_q2WT-90w")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount227? NonClearingMember { get; init; }

    /// <summary>
    /// Provides the lists of all trades during the period in consideration for the statement.
    /// </summary>
    [IsoId("_2q6ll6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Legs Details")]
    [IsoXmlTag("TradLegsDtls")]
    [MinLength(1)]
    public ValueList<TradeLeg15> TradeLegsDetails { get; init; } = [];
}
