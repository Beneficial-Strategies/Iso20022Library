// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for standardisation.
    /// </summary>
    [KnownType(typeof(Standardisation3Choice.Code))]
    [KnownType(typeof(Standardisation3Choice.Proprietary))]
    [JsonDerivedType(typeof(Standardisation3Choice.Code), nameof(Standardisation3Choice.Code))]
    [JsonDerivedType(
        typeof(Standardisation3Choice.Proprietary),
        nameof(Standardisation3Choice.Proprietary)
    )]
    [IsoId("_PbNAMWp7EemmaZLSPtWX5A")]
    [DisplayName("Standardisation 3 Choice")]
    public abstract record Standardisation3Choice_ { }
}
