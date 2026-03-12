// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType9Choice.Code))]
    [KnownType(typeof(BalanceType9Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType9Choice.Code),nameof(BalanceType9Choice.Code))]
    [JsonDerivedType(typeof(BalanceType9Choice.Proprietary),nameof(BalanceType9Choice.Proprietary))]
    [IsoId("_77AUUaMgEeCJ6YNENx4h-w_-1046252511")]
    [DisplayName("Balance Type 9 Choice")]
    public abstract partial record BalanceType9Choice_
    {
    }
}
