// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(BalanceType6Choice.Code))]
    [KnownType(typeof(BalanceType6Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType6Choice.Code), nameof(BalanceType6Choice.Code))]
    [JsonDerivedType(
        typeof(BalanceType6Choice.Proprietary),
        nameof(BalanceType6Choice.Proprietary)
    )]
    [IsoId("_nArEUfNBEeCuA5Tr22BnwA_-520393977")]
    [DisplayName("Balance Type 6 Choice")]
    public abstract record BalanceType6Choice_ { }
}
