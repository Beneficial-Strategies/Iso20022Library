// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Sets of elements to identify a name of the organisation identification scheme.
    /// </summary>
    [KnownType(typeof(FinancialIdentificationSchemeName1Choice.Code))]
    [KnownType(typeof(FinancialIdentificationSchemeName1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FinancialIdentificationSchemeName1Choice.Code),
        nameof(FinancialIdentificationSchemeName1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FinancialIdentificationSchemeName1Choice.Proprietary),
        nameof(FinancialIdentificationSchemeName1Choice.Proprietary)
    )]
    [IsoId("_QALkMNp-Ed-ak6NoX_4Aeg_-2021925461")]
    [DisplayName("Financial Identification Scheme Name 1 Choice")]
    public abstract record FinancialIdentificationSchemeName1Choice_ { }
}
