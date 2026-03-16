// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType14Choice.Code))]
    [KnownType(typeof(SubBalanceType14Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType14Choice.Code), nameof(SubBalanceType14Choice.Code))]
    [JsonDerivedType(
        typeof(SubBalanceType14Choice.Proprietary),
        nameof(SubBalanceType14Choice.Proprietary)
    )]
    [IsoId("_5W6c6ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Sub Balance Type 14 Choice")]
    public abstract record SubBalanceType14Choice_ { }
}
