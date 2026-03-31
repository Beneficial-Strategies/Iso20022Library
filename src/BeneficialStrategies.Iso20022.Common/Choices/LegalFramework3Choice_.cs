// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the legal framework.
    /// </summary>
    [KnownType(typeof(LegalFramework3Choice.Code))]
    [KnownType(typeof(LegalFramework3Choice.Proprietary))]
    [JsonDerivedType(typeof(LegalFramework3Choice.Code), nameof(LegalFramework3Choice.Code))]
    [JsonDerivedType(
        typeof(LegalFramework3Choice.Proprietary),
        nameof(LegalFramework3Choice.Proprietary)
    )]
    [IsoId("_-5gGQTqkEeWyoP0PbocV1Q")]
    [DisplayName("Legal Framework 3 Choice")]
    public abstract record LegalFramework3Choice_ { }
}
