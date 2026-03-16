// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Processed Status2Format1Choice.
    /// </summary>
    [KnownType(typeof(ProcessedStatus2Format1Choice.Code))]
    [KnownType(typeof(ProcessedStatus2Format1Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessedStatus2Format1Choice.Code),nameof(ProcessedStatus2Format1Choice.Code))]
    [JsonDerivedType(typeof(ProcessedStatus2Format1Choice.Proprietary),nameof(ProcessedStatus2Format1Choice.Proprietary))]
    [IsoId("_7Venw22aEe6CnszSwbRwFg")]
    [DisplayName("Processed Status2Format1Choice")]
    public abstract partial record ProcessedStatus2Format1Choice_
    {
    }
}
