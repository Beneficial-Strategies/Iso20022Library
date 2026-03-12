// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(OrganisationIdentification7Choice.LEI))]
    [KnownType(typeof(OrganisationIdentification7Choice.Other))]
    [JsonDerivedType(typeof(OrganisationIdentification7Choice.LEI),nameof(OrganisationIdentification7Choice.LEI))]
    [JsonDerivedType(typeof(OrganisationIdentification7Choice.Other),nameof(OrganisationIdentification7Choice.Other))]
    [IsoId("_XJaK8ZQEEeiILOjNP8ro1w")]
    [DisplayName("Organisation Identification 7 Choice")]
    public abstract partial record OrganisationIdentification7Choice_
    {
    }
}
