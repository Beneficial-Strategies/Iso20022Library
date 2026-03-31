// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition22Choice.Code))]
    [KnownType(typeof(ProcessingPosition22Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingPosition22Choice.Code),
        nameof(ProcessingPosition22Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessingPosition22Choice.Proprietary),
        nameof(ProcessingPosition22Choice.Proprietary)
    )]
    [IsoId("_Vye1o5qLEeWcAIE4lEkF_Q")]
    [DisplayName("Processing Position 22 Choice")]
    public abstract record ProcessingPosition22Choice_ { }
}
