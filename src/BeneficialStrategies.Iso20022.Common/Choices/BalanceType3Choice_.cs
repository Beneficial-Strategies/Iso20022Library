// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements defining the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType3Choice.Code))]
    [KnownType(typeof(BalanceType3Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType3Choice.Code),nameof(BalanceType3Choice.Code))]
    [JsonDerivedType(typeof(BalanceType3Choice.Proprietary),nameof(BalanceType3Choice.Proprietary))]
    [IsoId("_RcRuw9p-Ed-ak6NoX_4Aeg_-1428945866")]
    [DisplayName("Balance Type 3 Choice")]
    public abstract partial record BalanceType3Choice_
    {
    }
}
