// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification5Choice.BIC))]
    [KnownType(typeof(FinancialInstitutionIdentification5Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification5Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification5Choice.ProprietaryIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification5Choice.CombinedIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification5Choice.BIC),nameof(FinancialInstitutionIdentification5Choice.BIC))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification5Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification5Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification5Choice.NameAndAddress),nameof(FinancialInstitutionIdentification5Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification5Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification5Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification5Choice.CombinedIdentification),nameof(FinancialInstitutionIdentification5Choice.CombinedIdentification))]
    [IsoId("_TFehNtp-Ed-ak6NoX_4Aeg_1268643654")]
    [DisplayName("Financial Institution Identification 5 Choice")]
    public abstract partial record FinancialInstitutionIdentification5Choice_
    {
    }
}
