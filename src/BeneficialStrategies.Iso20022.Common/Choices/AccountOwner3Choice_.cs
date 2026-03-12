// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an organisation and an individual person.
    /// </summary>
    [KnownType(typeof(AccountOwner3Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(AccountOwner3Choice.OrganisationOwnerIdentification))]
    [JsonDerivedType(typeof(AccountOwner3Choice.IndividualOwnerIdentification),nameof(AccountOwner3Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(typeof(AccountOwner3Choice.OrganisationOwnerIdentification),nameof(AccountOwner3Choice.OrganisationOwnerIdentification))]
    [IsoId("_6NYocZTIEemqYPWMBuVawg")]
    [DisplayName("Account Owner 3 Choice")]
    public abstract partial record AccountOwner3Choice_
    {
    }
}
