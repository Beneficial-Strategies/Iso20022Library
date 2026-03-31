// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of a financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification10Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification10Choice.BICFI))]
    [KnownType(
        typeof(FinancialInstitutionIdentification10Choice.ClearingSystemMemberIdentification)
    )]
    [KnownType(typeof(FinancialInstitutionIdentification10Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification10Choice.NameAndAddress),
        nameof(FinancialInstitutionIdentification10Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification10Choice.BICFI),
        nameof(FinancialInstitutionIdentification10Choice.BICFI)
    )]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification10Choice.ClearingSystemMemberIdentification),
        nameof(FinancialInstitutionIdentification10Choice.ClearingSystemMemberIdentification)
    )]
    [JsonDerivedType(
        typeof(FinancialInstitutionIdentification10Choice.ProprietaryIdentification),
        nameof(FinancialInstitutionIdentification10Choice.ProprietaryIdentification)
    )]
    [IsoId("_RY0JwWAZEeiH9-hkDDXUHA")]
    [DisplayName("Financial Institution Identification 10 Choice")]
    public abstract record FinancialInstitutionIdentification10Choice_ { }
}
