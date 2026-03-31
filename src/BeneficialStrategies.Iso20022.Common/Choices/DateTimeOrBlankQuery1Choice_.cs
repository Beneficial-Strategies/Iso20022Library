// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date time period or blank elements.
    /// </summary>
    [KnownType(typeof(DateTimeOrBlankQuery1Choice.Range))]
    [KnownType(typeof(DateTimeOrBlankQuery1Choice.NotReported))]
    [JsonDerivedType(
        typeof(DateTimeOrBlankQuery1Choice.Range),
        nameof(DateTimeOrBlankQuery1Choice.Range)
    )]
    [JsonDerivedType(
        typeof(DateTimeOrBlankQuery1Choice.NotReported),
        nameof(DateTimeOrBlankQuery1Choice.NotReported)
    )]
    [IsoId("_HY688WE4Ee2S65ml6YCOtA")]
    [DisplayName("Date Time Or Blank Query 1 Choice")]
    public abstract record DateTimeOrBlankQuery1Choice_ { }
}
