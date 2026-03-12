// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType3Choice.Code))]
    [KnownType(typeof(MarketType3Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType3Choice.Code),nameof(MarketType3Choice.Code))]
    [JsonDerivedType(typeof(MarketType3Choice.Proprietary),nameof(MarketType3Choice.Proprietary))]
    [IsoId("_Q08B9tp-Ed-ak6NoX_4Aeg_-1018350094")]
    [DisplayName("Market Type 3 Choice")]
    public abstract partial record MarketType3Choice_
    {
    }
}
