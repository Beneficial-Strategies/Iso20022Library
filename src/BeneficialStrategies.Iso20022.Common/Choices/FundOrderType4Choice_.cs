// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the order type.
    /// </summary>
    [KnownType(typeof(FundOrderType4Choice.Code))]
    [KnownType(typeof(FundOrderType4Choice.Proprietary))]
    [JsonDerivedType(typeof(FundOrderType4Choice.Code), nameof(FundOrderType4Choice.Code))]
    [JsonDerivedType(
        typeof(FundOrderType4Choice.Proprietary),
        nameof(FundOrderType4Choice.Proprietary)
    )]
    [IsoId("_EYsKEThREeaRwdGFv45qTQ")]
    [DisplayName("Fund Order Type 4 Choice")]
    public abstract record FundOrderType4Choice_ { }
}
