// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party9Choice.OrganisationIdentification))]
    [KnownType(typeof(Party9Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(
        typeof(Party9Choice.OrganisationIdentification),
        nameof(Party9Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party9Choice.FinancialInstitutionIdentification),
        nameof(Party9Choice.FinancialInstitutionIdentification)
    )]
    [IsoId("_PW59stp-Ed-ak6NoX_4Aeg_2024378743")]
    [DisplayName("Party 9 Choice")]
    public abstract record Party9Choice_ { }
}
