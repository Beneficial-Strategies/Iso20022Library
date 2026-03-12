// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information on the securities quantity or bonds nominal amount.
    /// </summary>
    [KnownType(typeof(QuantityNominalValue2Choice.Quantity))]
    [KnownType(typeof(QuantityNominalValue2Choice.NominalValue))]
    [JsonDerivedType(typeof(QuantityNominalValue2Choice.Quantity),nameof(QuantityNominalValue2Choice.Quantity))]
    [JsonDerivedType(typeof(QuantityNominalValue2Choice.NominalValue),nameof(QuantityNominalValue2Choice.NominalValue))]
    [IsoId("_byObccpbEem6kd3Y9uIDqg")]
    [DisplayName("Quantity Nominal Value 2 Choice")]
    public abstract partial record QuantityNominalValue2Choice_
    {
    }
}
