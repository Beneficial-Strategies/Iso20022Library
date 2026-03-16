// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the fund order type.
    /// </summary>
    [KnownType(typeof(FundOrderType1Choice.Type))]
    [KnownType(typeof(FundOrderType1Choice.Proprietary))]
    [JsonDerivedType(typeof(FundOrderType1Choice.Type), nameof(FundOrderType1Choice.Type))]
    [JsonDerivedType(
        typeof(FundOrderType1Choice.Proprietary),
        nameof(FundOrderType1Choice.Proprietary)
    )]
    [IsoId("_RC8V8RHcEeKVqeHljBM1MQ")]
    [DisplayName("Fund Order Type 1 Choice")]
    public abstract record FundOrderType1Choice_ { }
}
