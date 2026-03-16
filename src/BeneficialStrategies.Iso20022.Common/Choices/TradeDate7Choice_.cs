// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// expressed as a ISO20022 code.
    /// </summary>
    [KnownType(typeof(TradeDate7Choice.Date))]
    [KnownType(typeof(TradeDate7Choice.Value))]
    [JsonDerivedType(typeof(TradeDate7Choice.Date), nameof(TradeDate7Choice.Date))]
    [JsonDerivedType(typeof(TradeDate7Choice.Value), nameof(TradeDate7Choice.Value))]
    [IsoId("_DKVckZBhEeakHoV5BVecAQ")]
    [DisplayName("Trade Date 7 Choice")]
    public abstract record TradeDate7Choice_ { }
}
