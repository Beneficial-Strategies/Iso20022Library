// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType15Choice.Code))]
    [KnownType(typeof(MarketType15Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType15Choice.Code),nameof(MarketType15Choice.Code))]
    [JsonDerivedType(typeof(MarketType15Choice.Proprietary),nameof(MarketType15Choice.Proprietary))]
    [IsoId("_JEeGkznWEeWV5sr121Fc8A")]
    [DisplayName("Market Type 15 Choice")]
    public abstract partial record MarketType15Choice_
    {
    }
}
