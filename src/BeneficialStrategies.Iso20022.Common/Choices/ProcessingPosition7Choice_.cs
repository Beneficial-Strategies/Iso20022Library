// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition7Choice.Code))]
    [KnownType(typeof(ProcessingPosition7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingPosition7Choice.Code),
        nameof(ProcessingPosition7Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessingPosition7Choice.Proprietary),
        nameof(ProcessingPosition7Choice.Proprietary)
    )]
    [IsoId("_nwmKyTnYEeWLJsP1cO-amg")]
    [DisplayName("Processing Position 7 Choice")]
    public abstract record ProcessingPosition7Choice_ { }
}
