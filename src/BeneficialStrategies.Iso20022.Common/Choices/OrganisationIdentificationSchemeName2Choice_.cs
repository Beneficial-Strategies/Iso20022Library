// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Sets of elements to identify a name of the organisation identification scheme.
    /// </summary>
    [KnownType(typeof(OrganisationIdentificationSchemeName2Choice.Code))]
    [KnownType(typeof(OrganisationIdentificationSchemeName2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OrganisationIdentificationSchemeName2Choice.Code),
        nameof(OrganisationIdentificationSchemeName2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OrganisationIdentificationSchemeName2Choice.Proprietary),
        nameof(OrganisationIdentificationSchemeName2Choice.Proprietary)
    )]
    [IsoId("_WgEDQRBBEeGyZLI6olyk-Q")]
    [DisplayName("Organisation Identification Scheme Name 2 Choice")]
    public abstract record OrganisationIdentificationSchemeName2Choice_ { }
}
