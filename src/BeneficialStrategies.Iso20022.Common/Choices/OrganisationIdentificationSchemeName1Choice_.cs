// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Sets of elements to identify a name of the organisation identification scheme.
    /// </summary>
    [KnownType(typeof(OrganisationIdentificationSchemeName1Choice.Code))]
    [KnownType(typeof(OrganisationIdentificationSchemeName1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OrganisationIdentificationSchemeName1Choice.Code),
        nameof(OrganisationIdentificationSchemeName1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OrganisationIdentificationSchemeName1Choice.Proprietary),
        nameof(OrganisationIdentificationSchemeName1Choice.Proprietary)
    )]
    [IsoId("_QACaQtp-Ed-ak6NoX_4Aeg_362604391")]
    [DisplayName("Organisation Identification Scheme Name 1 Choice")]
    public abstract record OrganisationIdentificationSchemeName1Choice_ { }
}
