// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the eligibility details.
    /// </summary>
    [KnownType(typeof(EligibilityIdentification2Choice.Country))]
    [KnownType(typeof(EligibilityIdentification2Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(EligibilityIdentification2Choice.IssuerCSDIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification2Choice.Country),nameof(EligibilityIdentification2Choice.Country))]
    [JsonDerivedType(typeof(EligibilityIdentification2Choice.FinancialInstrumentIdentification),nameof(EligibilityIdentification2Choice.FinancialInstrumentIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification2Choice.IssuerCSDIdentification),nameof(EligibilityIdentification2Choice.IssuerCSDIdentification))]
    [IsoId("_oDDY8eLXEeWFtOV72FbX9w")]
    [DisplayName("Eligibility Identification 2 Choice")]
    public abstract partial record EligibilityIdentification2Choice_
    {
    }
}
