// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of the financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.NameAndAddress),nameof(FinancialInstitutionIdentification7Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.BICFI),nameof(FinancialInstitutionIdentification7Choice.BICFI))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification7Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification7Choice.ProprietaryIdentification))]
    [IsoId("_TBZxQSGOEeW7gKYhAMEFCw")]
    [DisplayName("Financial Institution Identification 7 Choice")]
    public abstract partial record FinancialInstitutionIdentification7Choice_
    {
    }
}
