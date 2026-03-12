// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of the financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.BIC))]
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.NameAndAddress),nameof(FinancialInstitutionIdentification3Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.BIC),nameof(FinancialInstitutionIdentification3Choice.BIC))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification3Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification3Choice.ProprietaryIdentification))]
    [IsoId("_QE8vcNp-Ed-ak6NoX_4Aeg_2089460166")]
    [DisplayName("Financial Institution Identification 3 Choice")]
    public abstract partial record FinancialInstitutionIdentification3Choice_
    {
    }
}
