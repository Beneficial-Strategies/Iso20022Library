// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of a person or an organisation.
    /// </summary>
    [KnownType(typeof(PersonOrOrganisation2Choice.LEI))]
    [KnownType(typeof(PersonOrOrganisation2Choice.Person))]
    [JsonDerivedType(typeof(PersonOrOrganisation2Choice.LEI),nameof(PersonOrOrganisation2Choice.LEI))]
    [JsonDerivedType(typeof(PersonOrOrganisation2Choice.Person),nameof(PersonOrOrganisation2Choice.Person))]
    [IsoId("_9-fNkQkiEeWGouz230Xp5Q")]
    [DisplayName("Person Or Organisation 2 Choice")]
    public abstract partial record PersonOrOrganisation2Choice_
    {
    }
}
