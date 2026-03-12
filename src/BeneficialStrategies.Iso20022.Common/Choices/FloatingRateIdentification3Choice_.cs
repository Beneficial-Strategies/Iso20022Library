// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies various types of floating rates.
    /// </summary>
    [KnownType(typeof(FloatingRateIdentification3Choice.Code))]
    [KnownType(typeof(FloatingRateIdentification3Choice.Proprietary))]
    [JsonDerivedType(typeof(FloatingRateIdentification3Choice.Code),nameof(FloatingRateIdentification3Choice.Code))]
    [JsonDerivedType(typeof(FloatingRateIdentification3Choice.Proprietary),nameof(FloatingRateIdentification3Choice.Proprietary))]
    [IsoId("_GQZvjQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Floating Rate Identification 3 Choice")]
    public abstract partial record FloatingRateIdentification3Choice_
    {
    }
}
