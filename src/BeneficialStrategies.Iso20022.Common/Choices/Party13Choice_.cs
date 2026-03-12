// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party13Choice.OrganisationIdentification))]
    [KnownType(typeof(Party13Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(typeof(Party13Choice.OrganisationIdentification),nameof(Party13Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party13Choice.FinancialInstitutionIdentification),nameof(Party13Choice.FinancialInstitutionIdentification))]
    [IsoId("_6Q10g5qlEeGSON8vddiWzQ_1947841823")]
    [DisplayName("Party 13 Choice")]
    public abstract partial record Party13Choice_
    {
    }
}
