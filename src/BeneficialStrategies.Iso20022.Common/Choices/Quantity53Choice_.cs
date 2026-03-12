// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity53Choice.Quantity))]
    [KnownType(typeof(Quantity53Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity53Choice.Quantity),nameof(Quantity53Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity53Choice.ProprietaryQuantity),nameof(Quantity53Choice.ProprietaryQuantity))]
    [IsoId("_peY01Ti7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 53 Choice")]
    public abstract partial record Quantity53Choice_
    {
    }
}
