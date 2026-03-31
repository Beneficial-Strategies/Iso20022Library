// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between specification of the data in structured or free text format.
    /// </summary>
    [KnownType(typeof(DataFormat1Choice.Structured))]
    [KnownType(typeof(DataFormat1Choice.Unstructured))]
    [JsonDerivedType(typeof(DataFormat1Choice.Structured), nameof(DataFormat1Choice.Structured))]
    [JsonDerivedType(
        typeof(DataFormat1Choice.Unstructured),
        nameof(DataFormat1Choice.Unstructured)
    )]
    [IsoId("_Uys4Bdp-Ed-ak6NoX_4Aeg_1324048594")]
    [DisplayName("Data Format 1 Choice")]
    public abstract record DataFormat1Choice_ { }
}
