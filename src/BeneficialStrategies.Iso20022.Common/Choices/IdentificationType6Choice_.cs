// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType6Choice.Code))]
    [KnownType(typeof(IdentificationType6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationType6Choice.Code),
        nameof(IdentificationType6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationType6Choice.Proprietary),
        nameof(IdentificationType6Choice.Proprietary)
    )]
    [IsoId("_QmCDQtp-Ed-ak6NoX_4Aeg_-1758873433")]
    [DisplayName("Identification Type 6 Choice")]
    public abstract record IdentificationType6Choice_ { }
}
