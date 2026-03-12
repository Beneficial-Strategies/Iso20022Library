// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice between different types of derivative.
    /// </summary>
    [KnownType(typeof(DefinedAttributes1Choice.QuantityDefinedAttributes))]
    [KnownType(typeof(DefinedAttributes1Choice.ValueDefinedAttributes))]
    [JsonDerivedType(typeof(DefinedAttributes1Choice.QuantityDefinedAttributes),nameof(DefinedAttributes1Choice.QuantityDefinedAttributes))]
    [JsonDerivedType(typeof(DefinedAttributes1Choice.ValueDefinedAttributes),nameof(DefinedAttributes1Choice.ValueDefinedAttributes))]
    [IsoId("_wa3m8OPJEea7_eMQH225xA")]
    [DisplayName("Defined Attributes 1 Choice")]
    public abstract partial record DefinedAttributes1Choice_
    {
    }
}
