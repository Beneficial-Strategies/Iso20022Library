// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party56Choice.
    /// </summary>
    [KnownType(typeof(Party56Choice.FinancialInstitutionIdentification))]
    [KnownType(typeof(Party56Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party56Choice.FinancialInstitutionIdentification),nameof(Party56Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(typeof(Party56Choice.OrganisationIdentification),nameof(Party56Choice.OrganisationIdentification))]
    [IsoId("_IV3yUTFKEe651u5xu3f5iw")]
    [DisplayName("Party56Choice")]
    public abstract partial record Party56Choice_
    {
    }
}
