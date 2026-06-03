// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Calculation basis for the charge or fee.
    /// </summary>
    [KnownType(typeof(CalculationBasis2Choice.Code))]
    [KnownType(typeof(CalculationBasis2Choice.Proprietary))]
    [JsonDerivedType(typeof(CalculationBasis2Choice.Code), nameof(CalculationBasis2Choice.Code))]
    [JsonDerivedType(typeof(CalculationBasis2Choice.Proprietary), nameof(CalculationBasis2Choice.Proprietary))]
    [IsoId("2ab7a9e2-cd84-4250-af38-6aea4dd34b2b")]
    [DisplayName("CalculationBasis2Choice")]
    public abstract record CalculationBasis2Choice_ { }
}
