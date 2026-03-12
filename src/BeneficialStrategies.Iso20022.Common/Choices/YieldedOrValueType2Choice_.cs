// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of value type.
    /// </summary>
    [KnownType(typeof(YieldedOrValueType2Choice.Yielded))]
    [KnownType(typeof(YieldedOrValueType2Choice.ValueType))]
    [JsonDerivedType(typeof(YieldedOrValueType2Choice.Yielded),nameof(YieldedOrValueType2Choice.Yielded))]
    [JsonDerivedType(typeof(YieldedOrValueType2Choice.ValueType),nameof(YieldedOrValueType2Choice.ValueType))]
    [IsoId("_UyctRQycEeuG8M5giQ2e0w")]
    [DisplayName("Yielded Or Value Type 2 Choice")]
    public abstract partial record YieldedOrValueType2Choice_
    {
    }
}
