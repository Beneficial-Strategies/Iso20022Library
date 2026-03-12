// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies that the category of a product may be indicated by a code or by free text.
    /// </summary>
    [KnownType(typeof(ProductCharacteristics1Choice.StructuredProductCharacteristics))]
    [KnownType(typeof(ProductCharacteristics1Choice.OtherProductCharacteristics))]
    [JsonDerivedType(typeof(ProductCharacteristics1Choice.StructuredProductCharacteristics),nameof(ProductCharacteristics1Choice.StructuredProductCharacteristics))]
    [JsonDerivedType(typeof(ProductCharacteristics1Choice.OtherProductCharacteristics),nameof(ProductCharacteristics1Choice.OtherProductCharacteristics))]
    [IsoId("_RbrR09p-Ed-ak6NoX_4Aeg_-1771903850")]
    [DisplayName("Product Characteristics 1 Choice")]
    public abstract partial record ProductCharacteristics1Choice_
    {
    }
}
