// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the penalties for a given party.
/// </summary>
[IsoId("_xQ97UagzEfCXwLUUylXgrQ")]
[DisplayName("Penalty Per Counterparty4")]
public record PenaltyPerCounterparty4
{
    /// <summary>
    /// Party that manages the sub-level account on behalf of the account owner.
    /// </summary>
    [IsoId("_xUZp0agzEfCXwLUUylXgrQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification136? AccountServicer { get; init; }

    /// <summary>
    /// Unique identification of the party within the system.
    /// </summary>
    [IsoId("_xUaQ4agzEfCXwLUUylXgrQ")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PenaltyPartyIdentification1 PartyIdentification { get; init; }

    /// <summary>
    /// Bilateral net amount per party and counterparty.
    /// </summary>
    [IsoId("_xUaQ46gzEfCXwLUUylXgrQ")]
    [DisplayName("Aggregated Net Amount")]
    [IsoXmlTag("AggtdNetAmt")]
    public required AmountAndDirection5 AggregatedNetAmount { get; init; }

    /// <summary>
    /// Further details on the penalty.
    /// </summary>
    [IsoId("_xUaQ5agzEfCXwLUUylXgrQ")]
    [DisplayName("Penalty Details")]
    [IsoXmlTag("PnltyDtls")]
    public ValueList<PenaltyRecord4> PenaltyDetails { get; init; } = [];
}
