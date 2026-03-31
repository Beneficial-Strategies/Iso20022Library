// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType44Choice.Code))]
    [KnownType(typeof(IdentificationType44Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationType44Choice.Code),
        nameof(IdentificationType44Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationType44Choice.Proprietary),
        nameof(IdentificationType44Choice.Proprietary)
    )]
    [IsoId("_chc_CZKQEeWHWpTQn1FFVg")]
    [DisplayName("Identification Type 44 Choice")]
    public abstract record IdentificationType44Choice_ { }
}
