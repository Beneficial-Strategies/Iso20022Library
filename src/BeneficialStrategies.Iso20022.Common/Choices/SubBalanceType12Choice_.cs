// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType12Choice.Code))]
    [KnownType(typeof(SubBalanceType12Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType12Choice.Code), nameof(SubBalanceType12Choice.Code))]
    [JsonDerivedType(
        typeof(SubBalanceType12Choice.Proprietary),
        nameof(SubBalanceType12Choice.Proprietary)
    )]
    [IsoId("_-SHFQTnXEeWV5sr121Fc8A")]
    [DisplayName("Sub Balance Type 12 Choice")]
    public abstract record SubBalanceType12Choice_ { }
}
