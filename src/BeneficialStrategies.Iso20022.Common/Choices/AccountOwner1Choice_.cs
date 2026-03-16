// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an organisation and an individual person.
    /// </summary>
    [KnownType(typeof(AccountOwner1Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(AccountOwner1Choice.OrganisationOwnerIdentification))]
    [JsonDerivedType(
        typeof(AccountOwner1Choice.IndividualOwnerIdentification),
        nameof(AccountOwner1Choice.IndividualOwnerIdentification)
    )]
    [JsonDerivedType(
        typeof(AccountOwner1Choice.OrganisationOwnerIdentification),
        nameof(AccountOwner1Choice.OrganisationOwnerIdentification)
    )]
    [IsoId("_Mo3jsCFTEeWgV9SQSyaAog")]
    [DisplayName("Account Owner 1 Choice")]
    public abstract record AccountOwner1Choice_ { }
}
