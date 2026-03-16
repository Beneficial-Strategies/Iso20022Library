// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType11Choice.Code))]
    [KnownType(typeof(SubBalanceType11Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType11Choice.Code), nameof(SubBalanceType11Choice.Code))]
    [JsonDerivedType(
        typeof(SubBalanceType11Choice.Proprietary),
        nameof(SubBalanceType11Choice.Proprietary)
    )]
    [IsoId("_kRCJATnXEeWV5sr121Fc8A")]
    [DisplayName("Sub Balance Type 11 Choice")]
    public abstract record SubBalanceType11Choice_ { }
}
