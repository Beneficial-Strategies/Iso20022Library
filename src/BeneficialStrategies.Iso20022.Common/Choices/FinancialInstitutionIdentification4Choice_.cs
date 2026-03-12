// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification4Choice.BIC))]
    [KnownType(typeof(FinancialInstitutionIdentification4Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification4Choice.BIC),nameof(FinancialInstitutionIdentification4Choice.BIC))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification4Choice.NameAndAddress),nameof(FinancialInstitutionIdentification4Choice.NameAndAddress))]
    [IsoId("_QEzlhtp-Ed-ak6NoX_4Aeg_-827596048")]
    [DisplayName("Financial Institution Identification 4 Choice")]
    public abstract partial record FinancialInstitutionIdentification4Choice_
    {
    }
}
