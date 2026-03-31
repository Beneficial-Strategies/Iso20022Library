// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Party Identification Query10Choice.
    /// </summary>
    [KnownType(typeof(TradePartyIdentificationQuery10Choice.Identification))]
    [KnownType(typeof(TradePartyIdentificationQuery10Choice.NotReported))]
    [JsonDerivedType(
        typeof(TradePartyIdentificationQuery10Choice.Identification),
        nameof(TradePartyIdentificationQuery10Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(TradePartyIdentificationQuery10Choice.NotReported),
        nameof(TradePartyIdentificationQuery10Choice.NotReported)
    )]
    [IsoId("_htrKUfrfEe2mU4Wi2q3MzQ")]
    [DisplayName("Trade Party Identification Query10Choice")]
    public abstract record TradePartyIdentificationQuery10Choice_ { }
}
