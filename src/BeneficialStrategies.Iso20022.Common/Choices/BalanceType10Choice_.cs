// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the balance type.
    /// </summary>
    [KnownType(typeof(BalanceType10Choice.Code))]
    [KnownType(typeof(BalanceType10Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType10Choice.Code), nameof(BalanceType10Choice.Code))]
    [JsonDerivedType(
        typeof(BalanceType10Choice.Proprietary),
        nameof(BalanceType10Choice.Proprietary)
    )]
    [IsoId("_DOF0c4akEeeUws0ZryHQ2w")]
    [DisplayName("Balance Type 10 Choice")]
    public abstract record BalanceType10Choice_ { }
}
