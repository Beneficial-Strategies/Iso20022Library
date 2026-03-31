// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party51Choice.
    /// </summary>
    [KnownType(typeof(Party51Choice.FinancialInstitutionIdentification))]
    [KnownType(typeof(Party51Choice.OrganisationIdentification))]
    [JsonDerivedType(
        typeof(Party51Choice.FinancialInstitutionIdentification),
        nameof(Party51Choice.FinancialInstitutionIdentification)
    )]
    [JsonDerivedType(
        typeof(Party51Choice.OrganisationIdentification),
        nameof(Party51Choice.OrganisationIdentification)
    )]
    [IsoId("_zIGEcTEyEe6g-ffJsqGiSA")]
    [DisplayName("Party51Choice")]
    public abstract record Party51Choice_ { }
}
