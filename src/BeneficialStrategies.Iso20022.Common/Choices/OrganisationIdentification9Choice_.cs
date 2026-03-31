// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(OrganisationIdentification9Choice.LEI))]
    [KnownType(typeof(OrganisationIdentification9Choice.ClientIdentification))]
    [KnownType(typeof(OrganisationIdentification9Choice.AnyBIC))]
    [JsonDerivedType(
        typeof(OrganisationIdentification9Choice.LEI),
        nameof(OrganisationIdentification9Choice.LEI)
    )]
    [JsonDerivedType(
        typeof(OrganisationIdentification9Choice.ClientIdentification),
        nameof(OrganisationIdentification9Choice.ClientIdentification)
    )]
    [JsonDerivedType(
        typeof(OrganisationIdentification9Choice.AnyBIC),
        nameof(OrganisationIdentification9Choice.AnyBIC)
    )]
    [IsoId("_L_GVAZQMEeiILOjNP8ro1w")]
    [DisplayName("Organisation Identification 9 Choice")]
    public abstract record OrganisationIdentification9Choice_ { }
}
