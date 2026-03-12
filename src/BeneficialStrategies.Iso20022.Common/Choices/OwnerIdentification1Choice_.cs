// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of individual or organisation details.
    /// </summary>
    [KnownType(typeof(OwnerIdentification1Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(OwnerIdentification1Choice.OrganisationOwnerIdentification))]
    [JsonDerivedType(typeof(OwnerIdentification1Choice.IndividualOwnerIdentification),nameof(OwnerIdentification1Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(typeof(OwnerIdentification1Choice.OrganisationOwnerIdentification),nameof(OwnerIdentification1Choice.OrganisationOwnerIdentification))]
    [IsoId("_k3YxEQgrEeSqp5OpJ0aMmw")]
    [DisplayName("Owner Identification 1 Choice")]
    public abstract partial record OwnerIdentification1Choice_
    {
    }
}
