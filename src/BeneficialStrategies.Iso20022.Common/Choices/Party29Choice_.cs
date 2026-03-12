// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party29Choice.OrganisationIdentification))]
    [KnownType(typeof(Party29Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(typeof(Party29Choice.OrganisationIdentification),nameof(Party29Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party29Choice.FinancialInstitutionIdentification),nameof(Party29Choice.FinancialInstitutionIdentification))]
    [IsoId("_5wjW80yhEeWw591U1lOHyQ")]
    [DisplayName("Party 29 Choice")]
    public abstract partial record Party29Choice_
    {
    }
}
