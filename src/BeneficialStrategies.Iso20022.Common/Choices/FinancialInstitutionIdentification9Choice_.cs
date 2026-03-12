// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification ofa financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification9Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification9Choice.NameAndAddress),nameof(FinancialInstitutionIdentification9Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification9Choice.BICFI),nameof(FinancialInstitutionIdentification9Choice.BICFI))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification9Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification9Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification9Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification9Choice.ProprietaryIdentification))]
    [IsoId("__IfgtbNIEeejueAciesPMA")]
    [DisplayName("Financial Institution Identification 9 Choice")]
    public abstract partial record FinancialInstitutionIdentification9Choice_
    {
    }
}
