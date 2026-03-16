// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Market Type19Choice.
    /// </summary>
    [KnownType(typeof(MarketType19Choice.Code))]
    [KnownType(typeof(MarketType19Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType19Choice.Code),nameof(MarketType19Choice.Code))]
    [JsonDerivedType(typeof(MarketType19Choice.Proprietary),nameof(MarketType19Choice.Proprietary))]
    [IsoId("_Xeb8oYVYEe-Pv9KR9bv9IA")]
    [DisplayName("Market Type19Choice")]
    public abstract partial record MarketType19Choice_
    {
    }
}
