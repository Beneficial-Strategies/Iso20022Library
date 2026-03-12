// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party43Choice.OrganisationIdentification))]
    [KnownType(typeof(Party43Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(typeof(Party43Choice.OrganisationIdentification),nameof(Party43Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party43Choice.FinancialInstitutionIdentification),nameof(Party43Choice.FinancialInstitutionIdentification))]
    [IsoId("_BgdrHW49EeiU9cctagi5ow")]
    [DisplayName("Party 43 Choice")]
    public abstract partial record Party43Choice_
    {
    }
}
