// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between netting group identification of an individual trading party.
    /// </summary>
    [KnownType(typeof(NettingIdentification1Choice.TradeParty))]
    [KnownType(typeof(NettingIdentification1Choice.NettingGroupIdentification))]
    [JsonDerivedType(typeof(NettingIdentification1Choice.TradeParty),nameof(NettingIdentification1Choice.TradeParty))]
    [JsonDerivedType(typeof(NettingIdentification1Choice.NettingGroupIdentification),nameof(NettingIdentification1Choice.NettingGroupIdentification))]
    [IsoId("_mzHC8JUvEeaYkf5FCqYMeA")]
    [DisplayName("Netting Identification 1 Choice")]
    public abstract partial record NettingIdentification1Choice_
    {
    }
}
