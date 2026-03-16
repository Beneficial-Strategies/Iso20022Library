// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the source of the cash.
    /// </summary>
    [KnownType(typeof(SourceOfCash1Choice.Code))]
    [KnownType(typeof(SourceOfCash1Choice.Proprietary))]
    [JsonDerivedType(typeof(SourceOfCash1Choice.Code), nameof(SourceOfCash1Choice.Code))]
    [JsonDerivedType(
        typeof(SourceOfCash1Choice.Proprietary),
        nameof(SourceOfCash1Choice.Proprietary)
    )]
    [IsoId("_jxZG4DlEEealR6-8aQ15BA")]
    [DisplayName("Source Of Cash 1 Choice")]
    public abstract record SourceOfCash1Choice_ { }
}
