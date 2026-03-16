// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition5Choice.Code))]
    [KnownType(typeof(ProcessingPosition5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingPosition5Choice.Code),
        nameof(ProcessingPosition5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessingPosition5Choice.Proprietary),
        nameof(ProcessingPosition5Choice.Proprietary)
    )]
    [IsoId("_hPiaUQ4AEeKN_Y-2Awiamw")]
    [DisplayName("Processing Position 5 Choice")]
    public abstract record ProcessingPosition5Choice_ { }
}
