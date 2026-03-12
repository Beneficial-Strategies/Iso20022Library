// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of an organisation.
    /// </summary>
    [KnownType(typeof(OrganisationIdentification8Choice.ClientIdentification))]
    [KnownType(typeof(OrganisationIdentification8Choice.AnyBIC))]
    [JsonDerivedType(typeof(OrganisationIdentification8Choice.ClientIdentification),nameof(OrganisationIdentification8Choice.ClientIdentification))]
    [JsonDerivedType(typeof(OrganisationIdentification8Choice.AnyBIC),nameof(OrganisationIdentification8Choice.AnyBIC))]
    [IsoId("_8vgCgZQEEeiILOjNP8ro1w")]
    [DisplayName("Organisation Identification 8 Choice")]
    public abstract partial record OrganisationIdentification8Choice_
    {
    }
}
