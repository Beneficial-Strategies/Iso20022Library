// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition23Choice.Code))]
    [KnownType(typeof(ProcessingPosition23Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingPosition23Choice.Code),
        nameof(ProcessingPosition23Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessingPosition23Choice.Proprietary),
        nameof(ProcessingPosition23Choice.Proprietary)
    )]
    [IsoId("_BQvScb-DEeW_u_CSZtGM1g")]
    [DisplayName("Processing Position 23 Choice")]
    public abstract record ProcessingPosition23Choice_ { }
}
