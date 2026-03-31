// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Processed Status1Format1Choice.
    /// </summary>
    [KnownType(typeof(ProcessedStatus1Format1Choice.Code))]
    [KnownType(typeof(ProcessedStatus1Format1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessedStatus1Format1Choice.Code),
        nameof(ProcessedStatus1Format1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessedStatus1Format1Choice.Proprietary),
        nameof(ProcessedStatus1Format1Choice.Proprietary)
    )]
    [IsoId("_VtSm4VuxEe6gDOpEK7Q4ig")]
    [DisplayName("Processed Status1Format1Choice")]
    public abstract record ProcessedStatus1Format1Choice_ { }
}
