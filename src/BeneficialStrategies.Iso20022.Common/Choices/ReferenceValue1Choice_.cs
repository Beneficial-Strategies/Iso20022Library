// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of options for references.
    /// </summary>
    [KnownType(typeof(ReferenceValue1Choice.UUID))]
    [KnownType(typeof(ReferenceValue1Choice.IRI))]
    [KnownType(typeof(ReferenceValue1Choice.Other))]
    [JsonDerivedType(typeof(ReferenceValue1Choice.UUID),nameof(ReferenceValue1Choice.UUID))]
    [JsonDerivedType(typeof(ReferenceValue1Choice.IRI),nameof(ReferenceValue1Choice.IRI))]
    [JsonDerivedType(typeof(ReferenceValue1Choice.Other),nameof(ReferenceValue1Choice.Other))]
    [IsoId("_Q6wqUMePEeysUoBKYz1Ytw")]
    [DisplayName("Reference Value 1 Choice")]
    public abstract partial record ReferenceValue1Choice_
    {
    }
}
