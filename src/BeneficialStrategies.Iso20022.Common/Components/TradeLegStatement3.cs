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
[IsoId("_dEWFES6XEeSQQqw1BT_aMg")]
[DisplayName("Trade Leg Statement")]
public record TradeLegStatement3
{
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_dXY84S6XEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public SecuritiesAccount18? ClearingAccount { get; init; }

    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_dXY84y6XEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification35Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    [IsoId("_dXY85S6XEeSQQqw1BT_aMg")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; }

    /// <summary>
    /// Provides the lists of all trades during the period in consideration for the statement.
    /// </summary>
    [IsoId("_dXY85y6XEeSQQqw1BT_aMg")]
    [DisplayName("Trade Legs Details")]
    [IsoXmlTag("TradLegsDtls")]
    public ValueList<TradeLeg9> TradeLegsDetails { get; init; } = [];
    // ID for the above is _dXY85y6XEeSQQqw1BT_aMg
}
