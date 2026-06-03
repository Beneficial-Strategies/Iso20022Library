// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the eligibility details.
    /// </summary>
    [KnownType(typeof(EligibilityIdentification3Choice.Country))]
    [KnownType(typeof(EligibilityIdentification3Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(EligibilityIdentification3Choice.IssuerCSDIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification3Choice.Country), nameof(EligibilityIdentification3Choice.Country))]
    [JsonDerivedType(typeof(EligibilityIdentification3Choice.FinancialInstrumentIdentification), nameof(EligibilityIdentification3Choice.FinancialInstrumentIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification3Choice.IssuerCSDIdentification), nameof(EligibilityIdentification3Choice.IssuerCSDIdentification))]
    [IsoId("_w8PAkWc-EemvNLufWGIVOQ")]
    [DisplayName("Eligibility Identification 3 Choice")]
    public abstract record EligibilityIdentification3Choice_ { }
}
