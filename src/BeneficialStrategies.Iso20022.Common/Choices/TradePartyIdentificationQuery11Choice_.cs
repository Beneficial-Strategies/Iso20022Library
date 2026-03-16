// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Party Identification Query11Choice.
    /// </summary>
    [KnownType(typeof(TradePartyIdentificationQuery11Choice.Identification))]
    [KnownType(typeof(TradePartyIdentificationQuery11Choice.NotReported))]
    [JsonDerivedType(
        typeof(TradePartyIdentificationQuery11Choice.Identification),
        nameof(TradePartyIdentificationQuery11Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(TradePartyIdentificationQuery11Choice.NotReported),
        nameof(TradePartyIdentificationQuery11Choice.NotReported)
    )]
    [IsoId("_C53CYfrgEe2mU4Wi2q3MzQ")]
    [DisplayName("Trade Party Identification Query11Choice")]
    public abstract record TradePartyIdentificationQuery11Choice_ { }
}
