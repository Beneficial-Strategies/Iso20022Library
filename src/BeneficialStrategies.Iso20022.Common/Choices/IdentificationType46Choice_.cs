// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification Type46Choice.
    /// </summary>
    [KnownType(typeof(IdentificationType46Choice.Code))]
    [KnownType(typeof(IdentificationType46Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationType46Choice.Code),
        nameof(IdentificationType46Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationType46Choice.Proprietary),
        nameof(IdentificationType46Choice.Proprietary)
    )]
    [IsoId("_g_0AYaDcEe-CRv8HNM1RKw")]
    [DisplayName("Identification Type46Choice")]
    public abstract record IdentificationType46Choice_ { }
}
