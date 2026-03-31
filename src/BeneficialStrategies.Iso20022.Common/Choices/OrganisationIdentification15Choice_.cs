// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(OrganisationIdentification15Choice.LEI))]
    [KnownType(typeof(OrganisationIdentification15Choice.Other))]
    [KnownType(typeof(OrganisationIdentification15Choice.AnyBIC))]
    [JsonDerivedType(
        typeof(OrganisationIdentification15Choice.LEI),
        nameof(OrganisationIdentification15Choice.LEI)
    )]
    [JsonDerivedType(
        typeof(OrganisationIdentification15Choice.Other),
        nameof(OrganisationIdentification15Choice.Other)
    )]
    [JsonDerivedType(
        typeof(OrganisationIdentification15Choice.AnyBIC),
        nameof(OrganisationIdentification15Choice.AnyBIC)
    )]
    [IsoId("_7J1bIMgmEeuGrNSsxk3B0A")]
    [DisplayName("Organisation Identification 15 Choice")]
    public abstract record OrganisationIdentification15Choice_ { }
}
