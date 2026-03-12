// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies various types of floating rates.
    /// </summary>
    [KnownType(typeof(FloatingRateIdentification4Choice.Code))]
    [KnownType(typeof(FloatingRateIdentification4Choice.Proprietary))]
    [JsonDerivedType(typeof(FloatingRateIdentification4Choice.Code),nameof(FloatingRateIdentification4Choice.Code))]
    [JsonDerivedType(typeof(FloatingRateIdentification4Choice.Proprietary),nameof(FloatingRateIdentification4Choice.Proprietary))]
    [IsoId("_LrWLESjFEeuKKc2MztSwPw")]
    [DisplayName("Floating Rate Identification 4 Choice")]
    public abstract partial record FloatingRateIdentification4Choice_
    {
    }
}
