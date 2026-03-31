// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of individual or organisation details.
    /// </summary>
    [KnownType(typeof(OwnerIdentification3Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(OwnerIdentification3Choice.OrganisationOwnerIdentification))]
    [JsonDerivedType(
        typeof(OwnerIdentification3Choice.IndividualOwnerIdentification),
        nameof(OwnerIdentification3Choice.IndividualOwnerIdentification)
    )]
    [JsonDerivedType(
        typeof(OwnerIdentification3Choice.OrganisationOwnerIdentification),
        nameof(OwnerIdentification3Choice.OrganisationOwnerIdentification)
    )]
    [IsoId("_B1IjUZTREemC09f0MxYkRg")]
    [DisplayName("Owner Identification 3 Choice")]
    public abstract record OwnerIdentification3Choice_ { }
}
