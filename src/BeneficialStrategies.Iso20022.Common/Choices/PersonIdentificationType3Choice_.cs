// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of identification of a person.
    /// </summary>
    [KnownType(typeof(PersonIdentificationType3Choice.Code))]
    [KnownType(typeof(PersonIdentificationType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PersonIdentificationType3Choice.Code),
        nameof(PersonIdentificationType3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType3Choice.Proprietary),
        nameof(PersonIdentificationType3Choice.Proprietary)
    )]
    [IsoId("_Ri-zudp-Ed-ak6NoX_4Aeg_-206772035")]
    [DisplayName("Person Identification Type 3 Choice")]
    public abstract record PersonIdentificationType3Choice_ { }
}
