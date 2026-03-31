// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus68Choice.Code))]
    [KnownType(typeof(ProcessingStatus68Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus68Choice.Code), nameof(ProcessingStatus68Choice.Code))]
    [JsonDerivedType(
        typeof(ProcessingStatus68Choice.Proprietary),
        nameof(ProcessingStatus68Choice.Proprietary)
    )]
    [IsoId("_TDntl-FWEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status 68 Choice")]
    public abstract record ProcessingStatus68Choice_ { }
}
