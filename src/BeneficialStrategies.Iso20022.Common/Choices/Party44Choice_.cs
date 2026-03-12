// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party44Choice.OrganisationIdentification))]
    [KnownType(typeof(Party44Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(typeof(Party44Choice.OrganisationIdentification),nameof(Party44Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party44Choice.FinancialInstitutionIdentification),nameof(Party44Choice.FinancialInstitutionIdentification))]
    [IsoId("_9vWUh249EeiU9cctagi5ow")]
    [DisplayName("Party 44 Choice")]
    public abstract partial record Party44Choice_
    {
    }
}
