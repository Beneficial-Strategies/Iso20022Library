// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a code.
    /// </summary>
    [KnownType(typeof(ClosingDate1Choice.Date))]
    [KnownType(typeof(ClosingDate1Choice.Code))]
    [JsonDerivedType(typeof(ClosingDate1Choice.Date), nameof(ClosingDate1Choice.Date))]
    [JsonDerivedType(typeof(ClosingDate1Choice.Code), nameof(ClosingDate1Choice.Code))]
    [IsoId("_j2-tkNopEeCWg-hsBVGrDA_1110999750")]
    [DisplayName("Closing Date 1 Choice")]
    public abstract record ClosingDate1Choice_ { }
}
