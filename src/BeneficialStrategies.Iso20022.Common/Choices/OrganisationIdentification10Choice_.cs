// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(OrganisationIdentification10Choice.LEI))]
    [KnownType(typeof(OrganisationIdentification10Choice.Other))]
    [KnownType(typeof(OrganisationIdentification10Choice.AnyBIC))]
    [JsonDerivedType(typeof(OrganisationIdentification10Choice.LEI),nameof(OrganisationIdentification10Choice.LEI))]
    [JsonDerivedType(typeof(OrganisationIdentification10Choice.Other),nameof(OrganisationIdentification10Choice.Other))]
    [JsonDerivedType(typeof(OrganisationIdentification10Choice.AnyBIC),nameof(OrganisationIdentification10Choice.AnyBIC))]
    [IsoId("_H2dUKe9IEemVGdgB8P8uQQ")]
    [DisplayName("Organisation Identification 10 Choice")]
    public abstract partial record OrganisationIdentification10Choice_
    {
    }
}
