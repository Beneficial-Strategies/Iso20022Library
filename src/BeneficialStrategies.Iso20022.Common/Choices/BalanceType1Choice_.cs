// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements defining the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType1Choice.Code))]
    [KnownType(typeof(BalanceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType1Choice.Code),nameof(BalanceType1Choice.Code))]
    [JsonDerivedType(typeof(BalanceType1Choice.Proprietary),nameof(BalanceType1Choice.Proprietary))]
    [IsoId("_RcH9xdp-Ed-ak6NoX_4Aeg_-106550812")]
    [DisplayName("Balance Type 1 Choice")]
    public abstract partial record BalanceType1Choice_
    {
    }
}
