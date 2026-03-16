// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an organisation and an individual person.
    /// </summary>
    [KnownType(typeof(AccountOwner2Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(AccountOwner2Choice.OrganisationOwnerIdentification))]
    [JsonDerivedType(
        typeof(AccountOwner2Choice.IndividualOwnerIdentification),
        nameof(AccountOwner2Choice.IndividualOwnerIdentification)
    )]
    [JsonDerivedType(
        typeof(AccountOwner2Choice.OrganisationOwnerIdentification),
        nameof(AccountOwner2Choice.OrganisationOwnerIdentification)
    )]
    [IsoId("_9wrfUYoVEeahcZ3Nzs1Qag")]
    [DisplayName("Account Owner 2 Choice")]
    public abstract record AccountOwner2Choice_ { }
}
