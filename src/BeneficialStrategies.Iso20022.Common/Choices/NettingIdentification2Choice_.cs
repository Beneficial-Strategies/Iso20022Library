// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a netting group identification or an individual trading party.
    /// </summary>
    [KnownType(typeof(NettingIdentification2Choice.TradeParty))]
    [KnownType(typeof(NettingIdentification2Choice.NettingGroupIdentification))]
    [JsonDerivedType(
        typeof(NettingIdentification2Choice.TradeParty),
        nameof(NettingIdentification2Choice.TradeParty)
    )]
    [JsonDerivedType(
        typeof(NettingIdentification2Choice.NettingGroupIdentification),
        nameof(NettingIdentification2Choice.NettingGroupIdentification)
    )]
    [IsoId("_CEeXwQN1Ee2-vqzwMUAewg")]
    [DisplayName("Netting Identification 2 Choice")]
    public abstract record NettingIdentification2Choice_ { }
}
