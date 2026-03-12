// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ranges of values in which a quantity is considered valid or a specified quantity value which has to be matched or unmatched to be valid.
    /// </summary>
    [KnownType(typeof(QuantityRange1Choice.FromQuantity))]
    [KnownType(typeof(QuantityRange1Choice.ToQuantity))]
    [KnownType(typeof(QuantityRange1Choice.FromToQuantity))]
    [KnownType(typeof(QuantityRange1Choice.EqualQuantity))]
    [KnownType(typeof(QuantityRange1Choice.NotEqualQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.FromQuantity),nameof(QuantityRange1Choice.FromQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.ToQuantity),nameof(QuantityRange1Choice.ToQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.FromToQuantity),nameof(QuantityRange1Choice.FromToQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.EqualQuantity),nameof(QuantityRange1Choice.EqualQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.NotEqualQuantity),nameof(QuantityRange1Choice.NotEqualQuantity))]
    [IsoId("_jtHuFO5NEeCisYr99QEiWA_-1373711231")]
    [DisplayName("Quantity Range 1 Choice")]
    public abstract partial record QuantityRange1Choice_
    {
    }
}
