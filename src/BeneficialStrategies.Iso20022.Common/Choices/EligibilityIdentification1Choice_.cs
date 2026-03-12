// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the eligibility details.
    /// </summary>
    [KnownType(typeof(EligibilityIdentification1Choice.Country))]
    [KnownType(typeof(EligibilityIdentification1Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(EligibilityIdentification1Choice.IssuerCSDIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification1Choice.Country),nameof(EligibilityIdentification1Choice.Country))]
    [JsonDerivedType(typeof(EligibilityIdentification1Choice.FinancialInstrumentIdentification),nameof(EligibilityIdentification1Choice.FinancialInstrumentIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification1Choice.IssuerCSDIdentification),nameof(EligibilityIdentification1Choice.IssuerCSDIdentification))]
    [IsoId("_jBJ_8u5NEeCisYr99QEiWA_59531621")]
    [DisplayName("Eligibility Identification 1 Choice")]
    public abstract partial record EligibilityIdentification1Choice_
    {
    }
}
