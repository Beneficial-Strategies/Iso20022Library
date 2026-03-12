// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType16Choice.Code))]
    [KnownType(typeof(MarketType16Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType16Choice.Code),nameof(MarketType16Choice.Code))]
    [JsonDerivedType(typeof(MarketType16Choice.Proprietary),nameof(MarketType16Choice.Proprietary))]
    [IsoId("_cj_VWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Market Type 16 Choice")]
    public abstract partial record MarketType16Choice_
    {
    }
}
