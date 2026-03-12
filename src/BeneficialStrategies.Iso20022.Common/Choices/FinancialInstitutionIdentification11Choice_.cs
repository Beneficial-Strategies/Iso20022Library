// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of the financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.NameAndAddress),nameof(FinancialInstitutionIdentification11Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.BICFI),nameof(FinancialInstitutionIdentification11Choice.BICFI))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification11Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification11Choice.ProprietaryIdentification))]
    [IsoId("_RBDV4ZS7EemqYPWMBuVawg")]
    [DisplayName("Financial Institution Identification 11 Choice")]
    public abstract partial record FinancialInstitutionIdentification11Choice_
    {
    }
}
