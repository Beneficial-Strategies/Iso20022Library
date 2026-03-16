// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an order type.
    /// </summary>
    [KnownType(typeof(FundOrderType5Choice.Code))]
    [KnownType(typeof(FundOrderType5Choice.Proprietary))]
    [JsonDerivedType(typeof(FundOrderType5Choice.Code), nameof(FundOrderType5Choice.Code))]
    [JsonDerivedType(
        typeof(FundOrderType5Choice.Proprietary),
        nameof(FundOrderType5Choice.Proprietary)
    )]
    [IsoId("_IfVZwV8rEeicg40_9gK9vQ")]
    [DisplayName("Fund Order Type 5 Choice")]
    public abstract record FundOrderType5Choice_ { }
}
