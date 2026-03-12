// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType8Choice.Code))]
    [KnownType(typeof(BalanceType8Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType8Choice.Code),nameof(BalanceType8Choice.Code))]
    [JsonDerivedType(typeof(BalanceType8Choice.Proprietary),nameof(BalanceType8Choice.Proprietary))]
    [IsoId("_74nutaMgEeCJ6YNENx4h-w_-431996980")]
    [DisplayName("Balance Type 8 Choice")]
    public abstract partial record BalanceType8Choice_
    {
    }
}
