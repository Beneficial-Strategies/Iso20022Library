// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of the financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.BICFI))]
    [KnownType(
        typeof(FinancialInstitutionIdentification8Choice.ClearingSystemMemberIdentification)
    )]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification8Choice.NameAndAddress),
        nameof(FinancialInstitutionIdentification8Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification8Choice.BICFI),
        nameof(FinancialInstitutionIdentification8Choice.BICFI)
    )]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification8Choice.ClearingSystemMemberIdentification),
        nameof(FinancialInstitutionIdentification8Choice.ClearingSystemMemberIdentification)
    )]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification8Choice.ProprietaryIdentification),
        nameof(FinancialInstitutionIdentification8Choice.ProprietaryIdentification)
    )]
    [IsoId("_M0nFYTfAEeaijYcl4fyXoQ")]
    [DisplayName("Financial Institution Identification 8 Choice")]
    public abstract record FinancialInstitutionIdentification8Choice_ { }
}
