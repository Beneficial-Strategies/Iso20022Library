// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information on the securities quantity or bonds nominal amount.
    /// </summary>
    [KnownType(typeof(QuantityNominalValue1Choice.Quantity))]
    [KnownType(typeof(QuantityNominalValue1Choice.NominalValue))]
    [JsonDerivedType(typeof(QuantityNominalValue1Choice.Quantity),nameof(QuantityNominalValue1Choice.Quantity))]
    [JsonDerivedType(typeof(QuantityNominalValue1Choice.NominalValue),nameof(QuantityNominalValue1Choice.NominalValue))]
    [IsoId("_kXBi4HaiEeavseMKyTsJEA")]
    [DisplayName("Quantity Nominal Value 1 Choice")]
    public abstract partial record QuantityNominalValue1Choice_
    {
    }
}
