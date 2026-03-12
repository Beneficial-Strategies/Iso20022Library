// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the role of the party in the transaction.
    /// </summary>
    [KnownType(typeof(TradingPartyCapacity5Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity5Choice.Proprietary))]
    [JsonDerivedType(typeof(TradingPartyCapacity5Choice.Code),nameof(TradingPartyCapacity5Choice.Code))]
    [JsonDerivedType(typeof(TradingPartyCapacity5Choice.Proprietary),nameof(TradingPartyCapacity5Choice.Proprietary))]
    [IsoId("_r22iEMGxEeivTd4NUfCi2g")]
    [DisplayName("Trading Party Capacity 5 Choice")]
    public abstract partial record TradingPartyCapacity5Choice_
    {
    }
}
