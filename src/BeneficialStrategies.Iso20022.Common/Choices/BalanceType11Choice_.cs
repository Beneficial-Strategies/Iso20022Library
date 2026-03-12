// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType11Choice.Code))]
    [KnownType(typeof(BalanceType11Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType11Choice.Code),nameof(BalanceType11Choice.Code))]
    [JsonDerivedType(typeof(BalanceType11Choice.Proprietary),nameof(BalanceType11Choice.Proprietary))]
    [IsoId("_X7FWAXhZEeidzqjNEfehPg")]
    [DisplayName("Balance Type 11 Choice")]
    public abstract partial record BalanceType11Choice_
    {
    }
}
