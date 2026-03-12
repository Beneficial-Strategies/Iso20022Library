// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies various types of floating rates.
    /// </summary>
    [KnownType(typeof(FloatingRateIdentification8Choice.Code))]
    [KnownType(typeof(FloatingRateIdentification8Choice.Proprietary))]
    [JsonDerivedType(typeof(FloatingRateIdentification8Choice.Code),nameof(FloatingRateIdentification8Choice.Code))]
    [JsonDerivedType(typeof(FloatingRateIdentification8Choice.Proprietary),nameof(FloatingRateIdentification8Choice.Proprietary))]
    [IsoId("_IrIB4TNoEe2UWZuK9pqFtg")]
    [DisplayName("Floating Rate Identification 8 Choice")]
    public abstract partial record FloatingRateIdentification8Choice_
    {
    }
}
