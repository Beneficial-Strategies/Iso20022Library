// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an inflation index identification.
    /// </summary>
    [KnownType(typeof(InflationIndex1Choice.ISIN))]
    [KnownType(typeof(InflationIndex1Choice.Name))]
    [JsonDerivedType(typeof(InflationIndex1Choice.ISIN),nameof(InflationIndex1Choice.ISIN))]
    [JsonDerivedType(typeof(InflationIndex1Choice.Name),nameof(InflationIndex1Choice.Name))]
    [IsoId("_ZyZ21CS2EeWsI5Sp3-B3zg")]
    [DisplayName("Inflation Index 1 Choice")]
    public abstract partial record InflationIndex1Choice_
    {
    }
}
