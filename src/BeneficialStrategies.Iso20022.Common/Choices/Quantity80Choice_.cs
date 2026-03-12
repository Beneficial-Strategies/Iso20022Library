// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity80Choice.QuantityChoice))]
    [KnownType(typeof(Quantity80Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity80Choice.QuantityChoice),nameof(Quantity80Choice.QuantityChoice))]
    [JsonDerivedType(typeof(Quantity80Choice.ProprietaryQuantity),nameof(Quantity80Choice.ProprietaryQuantity))]
    [IsoId("_pf0YuTi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 80 Choice")]
    public abstract partial record Quantity80Choice_
    {
    }
}
