// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of value type.
    /// </summary>
    [KnownType(typeof(YieldedOrValueType1Choice.Yielded))]
    [KnownType(typeof(YieldedOrValueType1Choice.ValueType))]
    [JsonDerivedType(typeof(YieldedOrValueType1Choice.Yielded),nameof(YieldedOrValueType1Choice.Yielded))]
    [JsonDerivedType(typeof(YieldedOrValueType1Choice.ValueType),nameof(YieldedOrValueType1Choice.ValueType))]
    [IsoId("_RdBVptp-Ed-ak6NoX_4Aeg_510883553")]
    [DisplayName("Yielded Or Value Type 1 Choice")]
    public abstract partial record YieldedOrValueType1Choice_
    {
    }
}
