// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of individual or organisation details.
    /// </summary>
    [KnownType(typeof(OwnerIdentification2Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(OwnerIdentification2Choice.OrganisationOwnerIdentification))]
    [JsonDerivedType(typeof(OwnerIdentification2Choice.IndividualOwnerIdentification),nameof(OwnerIdentification2Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(typeof(OwnerIdentification2Choice.OrganisationOwnerIdentification),nameof(OwnerIdentification2Choice.OrganisationOwnerIdentification))]
    [IsoId("_Es6-ASGZEeWKAaDJcYGKLw")]
    [DisplayName("Owner Identification 2 Choice")]
    public abstract partial record OwnerIdentification2Choice_
    {
    }
}
