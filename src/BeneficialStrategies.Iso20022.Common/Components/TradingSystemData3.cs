// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the trade system.
/// </summary>
[IsoId("_4HUkEYTREfClBYp_xDbOWg")]
[DisplayName("Trading System Data3")]
public record TradingSystemData3
{
    /// <summary>
    /// Type of trading system on which the instrument is traded.
    /// </summary>
    [IsoId("_4IK4oYTREfClBYp_xDbOWg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TradingSystemType1Code Type { get; init; }

    /// <summary>
    /// Type of trading phase of the trading system on which the instrument is traded.
    /// Usage: Only applicable for the Equity Consolidated Tape Provider (CTP).
    /// </summary>
    [IsoId("_4IK4o4TREfClBYp_xDbOWg")]
    [DisplayName("Phase")]
    [IsoXmlTag("Phs")]
    public TradingSystemPhase1Code? Phase { get; init; }
}
