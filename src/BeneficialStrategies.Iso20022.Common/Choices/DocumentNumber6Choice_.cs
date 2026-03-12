// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber6Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber6Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber6Choice.ProprietaryNumber))]
    [JsonDerivedType(typeof(DocumentNumber6Choice.ShortNumber),nameof(DocumentNumber6Choice.ShortNumber))]
    [JsonDerivedType(typeof(DocumentNumber6Choice.LongNumber),nameof(DocumentNumber6Choice.LongNumber))]
    [JsonDerivedType(typeof(DocumentNumber6Choice.ProprietaryNumber),nameof(DocumentNumber6Choice.ProprietaryNumber))]
    [IsoId("_celQ0ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Document Number 6 Choice")]
    public abstract partial record DocumentNumber6Choice_
    {
    }
}
