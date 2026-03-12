// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement system/method.
    /// </summary>
    [KnownType(typeof(SettlementSystemMethod1Choice.Code))]
    [KnownType(typeof(SettlementSystemMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementSystemMethod1Choice.Code),nameof(SettlementSystemMethod1Choice.Code))]
    [JsonDerivedType(typeof(SettlementSystemMethod1Choice.Proprietary),nameof(SettlementSystemMethod1Choice.Proprietary))]
    [IsoId("_QvkZxNp-Ed-ak6NoX_4Aeg_-1971430733")]
    [DisplayName("Settlement System Method 1 Choice")]
    public abstract partial record SettlementSystemMethod1Choice_
    {
    }
}
