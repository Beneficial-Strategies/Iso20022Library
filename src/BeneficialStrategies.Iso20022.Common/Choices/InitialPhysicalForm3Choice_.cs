// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for initial physical form.
    /// </summary>
    [KnownType(typeof(InitialPhysicalForm3Choice.Code))]
    [KnownType(typeof(InitialPhysicalForm3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InitialPhysicalForm3Choice.Code),
        nameof(InitialPhysicalForm3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InitialPhysicalForm3Choice.Proprietary),
        nameof(InitialPhysicalForm3Choice.Proprietary)
    )]
    [IsoId("_mx0oUeLcEeWFtOV72FbX9w")]
    [DisplayName("Initial Physical Form 3 Choice")]
    public abstract record InitialPhysicalForm3Choice_ { }
}
